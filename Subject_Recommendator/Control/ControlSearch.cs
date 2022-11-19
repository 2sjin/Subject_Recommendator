﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.OleDb;

namespace Subject_Recommendator {
    public class ControlSearch : ControlDB {
        // 필드
        OleDbDataReader reader;

        // 교과목 List 프로퍼티
        public List<Subject> SubjectList { get; set; }

        // 생성자
        public ControlSearch() {
            SubjectList = new List<Subject>();

            OpenConnection();
            reader = ExecuteQuery("SELECT * FROM SUBJECT");
            RunAfterExecute();
            CloseConnection();
        }

        // 메소드: 검색
        public void Search(string name, string filter) {
            string sql = $"SELECT * FROM SUBJECT WHERE SUBJECT_NAME LIKE '%{name}%'" + filter;
            OpenConnection();
            reader = ExecuteQuery(sql);
            RunAfterExecute();
            CloseConnection();
        }

        // 추상 메소드 재정의
        public override void RunAfterExecute() {
            SubjectList.Clear();
            while (reader.Read()) {
                Subject subject = new Subject();
                int dummy = reader.GetInt32(0);
                subject.Name = reader.GetString(1);
                subject.Year = reader.GetInt32(2);
                subject.Term = reader.GetInt32(3);
                subject.LectureType = reader.GetString(4);
                subject.TeamProject = reader.GetString(5);
                SubjectList.Add(subject);
            }
            reader.Close();
        }
    }
}
