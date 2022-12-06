using System;
using System.Collections.Generic;
using System.Data.OleDb;

namespace Subject_Recommendator {
    // Control 클래스: FormFavorite와 Subject를 연결하고 제어하기 위한 클래스 (ControlDB의 파생 클래스)
    class ControlFavorite : ControlDB {
        // 필드
        OleDbDataReader reader;

        // 프로퍼티: 즐겨찾기 교과목 List(제네릭 컬렉션)
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
            reader = ExecuteQuery(sql);     // SELECT문 실행(FAVORITE 테이블과 SUBJECT 테이블의 JOIN)
            RunPostRefreshData();
            CloseConnection();
        }

        // 추상 메소드 재정의: 데이터 새로고침 실행 후처리
        public override void RunPostRefreshData() {
            FavoriteList.Clear();    // 리스트 초기화
            // SELECT 결과로 객체를 만들어 리스트에 추가
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

        // 연산자 중복: 즐겨찾기 추가
        public static bool operator +(ControlFavorite ctrl, int subjectId) {
            try {
                ctrl.OpenConnection();
                ctrl.ExecuteUpdate($"INSERT INTO FAVORITE(SUBJECT_ID) VALUES({subjectId})");    // INSERT문 실행(즐겨찾기 추가)
                ctrl.CloseConnection();
            } catch (Exception e) {
                return false;   // 예외가 발생하면 false 리턴
            }
            return true;        // 예외가 발생하지 않으면 true 리턴
        }

        // 연산자 중복: 즐겨찾기 삭제
        public static bool operator -(ControlFavorite ctrl, int subjectId) {
            try {
                ctrl.OpenConnection();
                ctrl.ExecuteUpdate($"DELETE FROM FAVORITE WHERE SUBJECT_ID={subjectId}");   // DELETE문 실행(즐겨찾기 삭제)
                ctrl.CloseConnection();
            } catch (Exception e) {
                return false;   // 예외가 발생하면 false 리턴
            }
            return true;        // 예외가 발생하지 않으면 true 리턴
        }
    }
}
