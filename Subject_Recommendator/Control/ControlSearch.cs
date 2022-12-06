using System.Collections.Generic;
using System.Data.OleDb;

namespace Subject_Recommendator {
    // Control 클래스: FormSearch와 Subject를 연결하고 제어하기 위한 클래스 (ControlDB의 파생 클래스)
    class ControlSearch : ControlDB {
        // 필드
        OleDbDataReader reader;     // DB의 데이터를 읽기 위한 Reader

        // 프로퍼티: 교과목 List(제네릭 컬렉션)
        public List<Subject> SubjectList { get; set; }

        // 생성자
        public ControlSearch() {
            SubjectList = new List<Subject>();
            RefreshData();
        }

        // 추상 메소드 재정의: 데이터 새로고침 실행(전체 교과목)
        public override void RefreshData() {
            OpenConnection();
            reader = ExecuteQuery("SELECT * FROM SUBJECT");     // SELECT문 실행(전체 교과목)
            RunPostRefreshData();
            CloseConnection();
        }

        // 메소드 중복: 데이터 새로고침 실행(교과목 필터링)
        public void RefreshData(string filter) {
            string sql = $"SELECT * FROM SUBJECT WHERE 1=1 " + filter;  // SELECT문 실행(필터만 적용, WHERE 1=1은 무조건 참인 형식적인 조건)
            OpenConnection();
            reader = ExecuteQuery(sql);
            RunPostRefreshData();
            CloseConnection();
        }

        // 메소드 중복: 데이터 새로고침 실행(교과목명/교과목개요 검색 및 필터링)
        public void RefreshData(string filter, string selectedInCombobox, string keyword) {
            // 검색 카테고리(검색 Form의 콤보박스의 텍스트)가 무엇인지를 저장함
            string category = "";
            if (selectedInCombobox.Equals("교과목명"))
                category = "SUBJECT_NAME";
            else if (selectedInCombobox.Equals("교과목 개요"))
                category = "OUTLINE";

            string sql = $"SELECT * FROM SUBJECT WHERE {category} LIKE '%{keyword}%'" + filter;     // SELECT문 실행(카테고리+키워드+필터)
            OpenConnection();
            reader = ExecuteQuery(sql);
            RunPostRefreshData();
            CloseConnection();
        }

        // 추상 메소드 재정의: 데이터 새로고침 실행 후처리
        public override void RunPostRefreshData() {
            SubjectList.Clear();    // 리스트 초기화
            // SELECT 결과로 객체를 만들어 리스트에 추가
            while (reader.Read()) {
                Subject subject = new Subject();
                subject.Id = reader.GetInt32(0);
                subject.Name = reader.GetString(1);
                subject.Year = reader.GetInt32(2);
                subject.Term = reader.GetInt32(3);
                subject.LectureType = reader.GetString(4);
                subject.TeamProject = reader.GetString(5);
                SubjectList.Add(subject);
            }
            reader.Close();
        }

        // 메소드: 이미 즐겨찾기에 추가된 교과목을 리스트에서 제거
        public void removeAlreadyFavorite() {
            string sql = "SELECT SUBJECT_ID FROM FAVORITE";
            OpenConnection();
            reader = ExecuteQuery(sql);     // 즐겨찾기 테이블에 있는 모든 교과목의 ID 조회

            // 람다 함수 (객체 변수 => 조건식)
            // 리스트 내 교과목 객체(s)를 모두 조회함
            //     => ID 프로퍼티(s.Id)가 reader의 ID 값(reader.GetInt32(0))과 일치하는 객체를 찾아 모두 삭제
            while (reader.Read())
                SubjectList.RemoveAll(s => s.Id == reader.GetInt32(0));

            reader.Close();
            CloseConnection();
        }
    }
}
