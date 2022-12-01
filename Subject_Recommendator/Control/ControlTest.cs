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

        // 프로퍼티
        public int CurrentQuestionId { get; set; }          // 현재 문항ID를 나타내는 프로퍼티
        public List<Question> QuestionList { get; set; }    // 진단검사 문항 List(제네릭 컬렉션)

        // 생성자
        public ControlTest() {
            CurrentQuestionId = 0;
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
                question.Id = int.Parse(reader["ID"].ToString());
                question.Content = reader["CONTENT"].ToString();
                QuestionList.Add(question);
            }
            reader.Close();
        }

        // 메소드: 진단검사 점수 초기화
        public void initScore() {
            OpenConnection();
            ExecuteUpdate("UPDATE SUBJECT SET SCORE=0");
            CloseConnection();
        }

        // 메소드: 과목별 점수 증가
        public void increaseScore(int questionId, int answer) {
            string localSql1 = $"SELECT SUBJECT_ID, WEIGHT FROM SCORE_WEIGHT WHERE QUESTION_ID={questionId}";

            OpenConnection();
            reader = ExecuteQuery(localSql1);

            while (reader.Read()) {
                int subjectId = reader.GetInt32(0);
                int scoreIncrease = reader.GetInt32(1) * answer;
                string localSql2 = $"UPDATE SUBJECT SET SCORE=SCORE+{scoreIncrease} " +
                                    $"WHERE ID={subjectId}";
                ExecuteUpdate(localSql2);
            }

            reader.Close();
            CloseConnection();
        }
    }
}
