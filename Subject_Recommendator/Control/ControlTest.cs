using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subject_Recommendator {
    internal class ControlTest : ControlDB {
        // 필드
        OleDbDataReader reader;

        // 진단검사 문항 List(제네릭 컬렉션) 프로퍼티
        public List<Question> QuestionList { get; set; }

        // 생성자
        public ControlTest() {
            QuestionList = new List<Question>();
            RefreshData();
        }

        // 추상 메소드 재정의: 데이터 새로고침 실행
        public override void RefreshData() {
            OpenConnection();
            reader = ExecuteQuery("SELECT * FROM QUESTION");
            RunPostRefreshData();
            CloseConnection();
        }

        // 추상 메소드 재정의: 데이터 새로고침 실행 후처리
        public override void RunPostRefreshData() {
            QuestionList.Clear();
            while (reader.Read()) {
                Question question = new Question();
                question.Id = reader.GetInt32(0);
                question.Content = reader.GetString(1);
                QuestionList.Add(question);
            }
            reader.Close();
        }
    }
}
