using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace Subject_Recommendator {
    internal class ControlFavorite : ControlDB {
        // 필드
        OleDbDataReader reader;

        // 즐겨찾기 교과목 List(제네릭 컬렉션) 프로퍼티
        public List<Subject> FavoriteList { get; set; }

        // 생성자
        public ControlFavorite() {
            FavoriteList = new List<Subject>();
            RefreshData();
        }

        // 추상 메소드 재정의: 데이터 새로고침 실행
        public override void RefreshData() {
            string sql = "SELECT SUBJECT_ID, SUBJECT_NAME, LIMIT_YEAR, TERM, LECTURE_TYPE, TEAM_PROJECT " +
                        "FROM FAVORITE, SUBJECT " +
                        "WHERE FAVORITE.SUBJECT_ID=SUBJECT.ID";
            OpenConnection();
            reader = ExecuteQuery(sql);
            RunPostRefreshData();
            CloseConnection();
        }

        // 추상 메소드 재정의: 데이터 새로고침 실행 후처리
        public override void RunPostRefreshData() {
            FavoriteList.Clear();
            while (reader.Read()) {
                Subject subject = new Subject();
                subject.Id = reader.GetInt32(0);
                subject.Name = reader.GetString(1);
                subject.Year = reader.GetInt32(2);
                subject.Term = reader.GetInt32(3);
                subject.LectureType = reader.GetString(4);
                subject.TeamProject = reader.GetString(5);
                FavoriteList.Add(subject);
            }
            reader.Close();
        }

        // 즐겨찾기 추가
        public void AddFavorite(int subjectId) {
            OpenConnection();
            ExecuteUpdate($"INSERT INTO FAVORITE(SUBJECT_ID) VALUES({subjectId})");
            CloseConnection();
        }

        // 즐겨찾기 삭제
        public void DeleteFavorite(int subjectId) {
            OpenConnection();
            ExecuteUpdate($"DELETE FROM FAVORITE WHERE SUBJECT_ID={subjectId}");
            CloseConnection();
        }
    }
}
