using System.Data.OleDb;

namespace Subject_Recommendator {
    // Control 클래스: FormDetail과 Subject를 연결하고 제어하기 위한 클래스 (ControlDB의 파생 클래스)
    class ControlDetail : ControlDB {
        // 필드
        OleDbDataReader reader;
        int subjectId;

        // 프로퍼티: 교과목
        public Subject SelectedSubject { get; set; }

        // 생성자
        public ControlDetail(int subjectId) {
            this.subjectId = subjectId;
            RefreshData();
        }

        // 추상 메소드 재정의: 데이터 새로고침 실행
        override public void RefreshData() {
            OpenConnection();
            reader = ExecuteQuery($"SELECT * FROM SUBJECT WHERE ID={subjectId}");   // SELECT문 실행(특정 교과목번호에 대한 교과목 정보)
            RunPostRefreshData();
            CloseConnection();
        }

        // 추상 메소드 재정의: SQL문 실행 후처리
        public override void RunPostRefreshData() {
            // SELECT 결과로 객체를 만들고 설정함(교과목 객체 1개만 필요하므로 리스트는 정의하지 않음)
            while (reader.Read()) {
                SelectedSubject = new Subject();
                SelectedSubject.Id = reader.GetInt32(0);
                SelectedSubject.Name = reader.GetString(1);
                SelectedSubject.Year = reader.GetInt32(2);
                SelectedSubject.Term = reader.GetInt32(3);
                SelectedSubject.LectureType = reader.GetString(4);
                SelectedSubject.TeamProject = reader.GetString(5);
                SelectedSubject.Outline = reader.GetString(6);
            }
            reader.Close();
        }
    }
}
