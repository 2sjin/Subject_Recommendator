﻿using System.Data.OleDb;

namespace Subject_Recommendator {
    internal class ControlDetail : ControlDB {
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
            SelectedSubject = new Subject();
            OpenConnection();
            reader = ExecuteQuery($"SELECT * FROM SUBJECT WHERE ID={subjectId}");   // SELECT문 실행
            RunPostRefreshData();
            CloseConnection();
        }

        // 추상 메소드 재정의: SQL문 실행 후처리
        public override void RunPostRefreshData() {
            while (reader.Read()) {
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
