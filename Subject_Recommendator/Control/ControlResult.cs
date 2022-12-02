using System;
using System.IO;
using System.Collections.Generic;
using System.Data.OleDb;

namespace Subject_Recommendator {
    internal class ControlResult : ControlDB {
        // 필드
        OleDbDataReader reader;

        // 교과목 List(제네릭 컬렉션) 프로퍼티
        public List<Subject> SubjectList { get; set; }

        // 생성자
        public ControlResult() {
            SubjectList = new List<Subject>();
            RefreshData();
        }

        // 추상 메소드 재정의: 데이터 새로고침 실행
        public override void RefreshData() {
            string sql = "SELECT * FROM SUBJECT ORDER BY SCORE DESC";
            OpenConnection();
            reader = ExecuteQuery(sql);
            RunPostRefreshData();
            CloseConnection();
        }

        // 추상 메소드 재정의: 데이터 새로고침 실행 후처리
        public override void RunPostRefreshData() {
            int limitCount = 0;
            SubjectList.Clear();
            while (reader.Read() && limitCount < 7) {
                Subject subject = new Subject();
                subject.Id = reader.GetInt32(0);
                subject.Name = reader.GetString(1);
                subject.Year = reader.GetInt32(2);
                subject.Term = reader.GetInt32(3);
                subject.LectureType = reader.GetString(4);
                subject.TeamProject = reader.GetString(5);
                SubjectList.Add(subject);
                limitCount++;
            }
            reader.Close();
        }


        // 메소드: 교과목 추천 결과 데이터를 텍스트 파일로 저장(쓰기)
        // 저장 성공 시 null 리턴, 예외 발생 시 예외 메시지 리턴
        public string SaveToTextFile(string filepath) {
            FileStream fs = null;
            StreamWriter sw = null;
            try {
                fs = new FileStream(filepath, FileMode.Create, FileAccess.Write);
                sw = new StreamWriter(fs, System.Text.Encoding.Default);
                sw.WriteLine("12345678");
                return null;
            } catch (Exception e) {
                return e.Message;
            } finally {
                sw.Close();
                fs.Close();
            }
        }
    }
}
