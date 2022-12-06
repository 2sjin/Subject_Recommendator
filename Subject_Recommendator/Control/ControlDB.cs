using System.Data.OleDb;

namespace Subject_Recommendator {
    // Control 클래스: 데이터베이스 연결을 위한 제어 클래스(추상 클래스)
    abstract public class ControlDB {
        // 필드
        string conStr = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=schema.mdb";
        OleDbConnection conn;

        // 메소드: Connection 생성 및 Open(데이터베이스 연결)
        public void OpenConnection() {
            conn = new OleDbConnection(conStr);
            conn.Open();
        }

        // 메소드: 매개변수의 SQL문 실행(SELECT 연산)
        public OleDbDataReader ExecuteQuery(string sql) {
            OleDbCommand comm = new OleDbCommand(sql, conn);
            return comm.ExecuteReader();
        }

        // 메소드: 매개변수의 SQL문 실행(INSERT, DELETE, UPDATE 등의 연산)
        public int ExecuteUpdate(string sql) {
            OleDbCommand comm = new OleDbCommand(sql, conn);
            return comm.ExecuteNonQuery();
        }

        // 추상 메소드 선언: 데이터 새로고침 실행
        abstract public void RefreshData();

        // 추상 메소드 선언: 데이터 새로고침 실행 후처리
        abstract public void RunPostRefreshData();

        // 메소드: Connection 닫기
        public void CloseConnection() {
            conn.Close();
        }
    }
}
