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

        // 교과목 List 프로퍼티
        public List<Subject> FavoriteList { get; set; }

        // 생성자
        public ControlFavorite() {
            string sql = "SELECT SUBJECT_ID, SUBJECT_NAME, LIMIT_YEAR, TERM, LECTURE_TYPE, TEAM_PROJECT " +
                        "FROM FAVORITE, SUBJECT " +
                        "WHERE FAVORITE.SUBJECT_ID=SUBJECT.ID";
            FavoriteList = new List<Subject>();
            OpenConnection();
            reader = ExecuteQuery(sql);
            RunAfterExecute();
            CloseConnection();
        }

        // 추상 메소드 재정의: SQL문 실행 후처리
        public override void RunAfterExecute() {
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
    }
}
