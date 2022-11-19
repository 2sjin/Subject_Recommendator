using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.OleDb;

namespace Subject_Recommendator {
    abstract public class ControlDB {
        // 필드
        string conStr = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=test.mdb";
        OleDbConnection conn;
        OleDbDataReader reader;

        // 프로퍼티
        public OleDbDataReader Reader {
            get { return reader; }
        }

        // Connection 생성 및 Open
        public void OpenConnection() {
            conn = new OleDbConnection(conStr);
            conn.Open();
        }

        // OleDbDataReader 생성
        public void CreateReader(string sql) {
            OleDbCommand comm = new OleDbCommand(sql, conn);
            reader = comm.ExecuteReader();
        }

        // 쿼리 실행
        abstract public void RunQuery();


        // Reader 및 Connection 닫기
        public void Close() {
            reader.Close();
            conn.Close();
        }
    }
}
