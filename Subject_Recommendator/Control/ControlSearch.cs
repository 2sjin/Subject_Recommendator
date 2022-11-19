using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.OleDb;

namespace Subject_Recommendator {
    public class ControlSearch : ControlDB {
        // 교과목 List 프로퍼티
        public List<Subject> SubjectList { get; set; }

        // 생성자
        public ControlSearch() {
            SubjectList = new List<Subject>();
            OpenConnection();
            CreateReader("SELECT * FROM SUBJECT");
            RunQuery();
            Close();
        }

        // 추상 메소드 재정의
        public override void RunQuery() {
            while (Reader.Read()) {
                Subject subject = new Subject();
                int dummy = Reader.GetInt32(0);
                subject.Name = Reader.GetString(1);
                subject.Year = Reader.GetInt32(2);
                subject.Term = Reader.GetInt32(3);
                subject.LectureType = Reader.GetString(4);
                subject.TeamProject = Reader.GetString(5);
                SubjectList.Add(subject);
            }
        }
    }
}
