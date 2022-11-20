using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace Subject_Recommendator {
    internal class ControlResult : ControlDB {
        // 필드
        OleDbDataReader reader;

        // 교과목 List(제네릭 컬렉션) 프로퍼티
        public List<Subject> SubjectList { get; set; }

        // 생성자
        public ControlResult() {
            SubjectList = new List<Subject>();
            RefreshData();
        }

        // 추상 메소드 재정의: 데이터 새로고침 실행
        public override void RefreshData() {
            string sql = "SELECT * FROM SUBJECT ORDER BY SCORE DESC";
            OpenConnection();
            reader = ExecuteQuery(sql);
            RunPostRefreshData();
            CloseConnection();
        }

        // 추상 메소드 재정의: 데이터 새로고침 실행 후처리
        public override void RunPostRefreshData() {
            int limitCount = 0;
            SubjectList.Clear();
            while (reader.Read() && limitCount < 10) {
                Subject subject = new Subject();
                subject.Id = reader.GetInt32(0);
                subject.Name = reader.GetString(1);
                subject.Year = reader.GetInt32(2);
                subject.Term = reader.GetInt32(3);
                subject.LectureType = reader.GetString(4);
                subject.TeamProject = reader.GetString(5);
                SubjectList.Add(subject);
                limitCount++;
            }
            reader.Close();
        }
    }
}
