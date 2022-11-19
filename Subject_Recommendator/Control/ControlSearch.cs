using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.OleDb;

namespace Subject_Recommendator {
    public class ControlSearch {
        // 교과목 List 프로퍼티
        public List<Subject> SubjectList { get; set; }

        // 생성자
        public ControlSearch() {
            SubjectList = new List<Subject>();
            ConnDB();
        }

        // DB 연결 메소드(연결 지향)
        public void ConnDB() {
            // Connection 생성 및 Open
            string conStr = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=test.mdb";
            OleDbConnection conn = new OleDbConnection(conStr);
            conn.Open();

            OleDbCommand comm = new OleDbCommand("SELECT * FROM SUBJECT", conn);

            // OleDbDataReader 생성
            OleDbDataReader reader = comm.ExecuteReader();

            // OleDbDataReader로 데이터 읽기
            while (reader.Read()) {
                Subject subject = new Subject();
                int dummy = reader.GetInt32(0);
                subject.Name = reader.GetString(1);
                subject.Year = reader.GetInt32(2);
                subject.Term = reader.GetInt32(3);
                subject.LectureType = reader.GetString(4);
                subject.TeamProject = reader.GetString(5);
                SubjectList.Add(subject);
            }
        
            // Reader 및 Connection 닫기
            reader.Close();
            conn.Close();
        }
    }
}
