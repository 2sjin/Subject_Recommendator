using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.OleDb;

namespace Subject_Recommendator.ControlClass {
    public class ControlSearch {

        public DataRowCollection TableRows { get; set; }

        public ControlSearch() {
            ConnDB();
        }

        public void ConnDB() {
            // Connection 생성 및 Open
            string conStr = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=test.mdb";
            OleDbConnection conn = new OleDbConnection(conStr);
            conn.Open();

            // OleDbDataAdapter 생성
            OleDbDataAdapter adapter = new OleDbDataAdapter();

            // Adapter에 SelectCommand 할당
            string query = "SELECT * FROM SUBJECT";
            adapter.SelectCommand = new OleDbCommand(query, conn);

            // DataSet 생성
            DataSet ds = new DataSet();

            // Adapter를 통해서 DataSet 채우기
            adapter.Fill(ds);

            // Connection 닫기
            conn.Close();

            // DataSet으로 작업하기
            DataTable table = ds.Tables[0];
            TableRows = table.Rows;
        }
    }
}
