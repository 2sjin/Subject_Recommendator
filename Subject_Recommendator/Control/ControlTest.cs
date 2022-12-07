using System.Collections.Generic;
using System.Data.OleDb;

namespace Subject_Recommendator {
    // Control 클래스: FormTest와 Question을 연결하고 제어하기 위한 클래스 (ControlDB의 파생 클래스)
    class ControlTest : ControlDB {
        // 필드
        OleDbDataReader reader;     // DB의 데이터를 읽기 위한 Reader

        // 프로퍼티
        public List<Question> QuestionList { get; set; }    // 진단검사 문항 List(제네릭 컬렉션)
        public int CurrentQuestionId { get; set; }          // 현재 문항의 ID를 나타내는 프로퍼티   

        // 생성자
        public ControlTest() {
            CurrentQuestionId = 0;
            QuestionList = new List<Question>();
            RefreshData();
        }

        // 추상 메소드 재정의: 데이터 새로고침 실행
        public override void RefreshData() {
            OpenConnection();
            reader = ExecuteQuery("SELECT * FROM QUESTION");    // SELECT문 실행(문항 모두 조회)
            RunPostRefreshData();
            CloseConnection();
        }

        // 추상 메소드 재정의: 데이터 새로고침 실행 후처리
        public override void RunPostRefreshData() {
            QuestionList.Clear();   // 리스트 초기화
            // SELECT 결과로 객체를 만들어 리스트에 추가
            while (reader.Read()) {
                Question question = new Question();
                question.Id = int.Parse(reader["ID"].ToString());
                question.Content = reader["CONTENT"].ToString();
                QuestionList.Add(question);
            }
            reader.Close();
        }

        // 메소드: DB에 저장된 진단검사 점수 초기화
        public void initScore() {
            OpenConnection();
            ExecuteUpdate("UPDATE SUBJECT SET SCORE=0");    // UPDATE문 실행(모든 교과목의 진단검사 점수를 0으로 변경)
            CloseConnection();
        }

        // 메소드: 특정 문항(questionId)에서 가중치가 부여된 과목들의 점수 증가
        public void increaseScore(int questionId, int answer) {
            string localSql1 = $"SELECT SUBJECT_ID, WEIGHT FROM SCORE_WEIGHT WHERE QUESTION_ID={questionId}";

            OpenConnection();
            reader = ExecuteQuery(localSql1);   // SELECT문 실행(특정 문항에 대한 과목 ID와 점수 가중치를 가져옴)

            while (reader.Read()) {
                int subjectId = reader.GetInt32(0);
                int scoreIncrease = reader.GetInt32(1) * answer;    // 교과목별 점수 가중치 * 클릭(응답)한 버튼의 점수
                string localSql2 = $"UPDATE SUBJECT SET SCORE=SCORE+{scoreIncrease} " +
                                    $"WHERE ID={subjectId}";
                ExecuteUpdate(localSql2);   // 교과목별 점수 증가
            }

            reader.Close();
            CloseConnection();
        }
    }
}
