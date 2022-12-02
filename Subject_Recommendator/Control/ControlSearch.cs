using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace Subject_Recommendator {
    public class ControlSearch : ControlDB {
        // 필드
        OleDbDataReader reader;

        // 교과목 List(제네릭 컬렉션) 프로퍼티
        public List<Subject> SubjectList { get; set; }

        // 생성자
        public ControlSearch() {
            SubjectList = new List<Subject>();
            RefreshData();
        }

        // 추상 메소드 재정의: 데이터 새로고침 실행(전체 교과목)
        public override void RefreshData() {
            OpenConnection();
            reader = ExecuteQuery("SELECT * FROM SUBJECT");
            RunPostRefreshData();
            CloseConnection();
        }

        // 메소드 중복: 데이터 새로고침 실행(교과목 필터링)
        public void RefreshData(string filter) {
            string sql = $"SELECT * FROM SUBJECT WHERE 1=1 " + filter;
            OpenConnection();
            reader = ExecuteQuery(sql);
            RunPostRefreshData();
            CloseConnection();
        }

        // 메소드 중복: 데이터 새로고침 실행(교과목 검색 및 필터링)
        public void RefreshData(string filter, string name) {
            string sql = $"SELECT * FROM SUBJECT WHERE SUBJECT_NAME LIKE '%{name}%'" + filter;
            OpenConnection();
            reader = ExecuteQuery(sql);
            RunPostRefreshData();
            CloseConnection();
        }

        // 추상 메소드 재정의: 데이터 새로고침 실행 후처리
        public override void RunPostRefreshData() {
            SubjectList.Clear();
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
            reader = ExecuteQuery(sql);

            // 람다 (객체 변수 => 조건식)
            // 교과목 객체의 ID 프로퍼티가 reader의 값과 일치하면 해당 객체 모두 삭제
            while (reader.Read())
                SubjectList.RemoveAll(s => s.Id == reader.GetInt32(0));

            reader.Close();
            CloseConnection();
        }
    }
}
