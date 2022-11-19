using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.OleDb;

namespace Subject_Recommendator.ControlClass {
    abstract public class Control {
        // 필드
        OleDbConnection conn;

        // 프로퍼티
        public DataRowCollection TableRows { get; set; }

        public abstract void setQuery();

        // Connection 생성 및 Open
        public void ConnDB() {
            string conStr = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=test.mdb";
            conn = new OleDbConnection(conStr);
            conn.Open();
            runQuery();
        }

        // 연결형
        public void runQuery() {
            string sql = "SELECT * FROM SUBJECT";
            OleDbCommand comm = new OleDbCommand(sql, conn);
            int i = comm.ExecuteNonQuery();

            OleDbDataReader reader = comm.ExecuteReader();

            while (reader.Read()) {
                EntityClass.Subject subject = new EntityClass.Subject();
                subject.Name = reader[1].ToString();
                subject.Year = (int) reader[2];
                subject.Term = (int) reader[3];
                subject.TeamProject = (int) reader[4];
                TableRows.Add(subject);
            }

            reader.Close();
            conn.Close();
        }
    }
}
