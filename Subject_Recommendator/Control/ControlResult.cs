using System;
using System.IO;
using System.Collections.Generic;
using System.Data.OleDb;

namespace Subject_Recommendator {
    // Control 클래스: FormResult와 Subject를 연결하고 제어하기 위한 클래스 (ControlDB의 파생 클래스)
    class ControlResult : ControlDB {
        // 필드
        OleDbDataReader reader;

        // 프로퍼티: 교과목 List(제네릭 컬렉션)
        public List<Subject> SubjectList { get; set; }

        // 생성자
        public ControlResult() {
            SubjectList = new List<Subject>();
            RefreshData();
        }

        // 추상 메소드 재정의: 데이터 새로고침 실행
        public override void RefreshData() {
            string sql = "SELECT * FROM SUBJECT ORDER BY SCORE DESC";   // SELECT문 실행(점수 내림차순)
            OpenConnection();
            reader = ExecuteQuery(sql);
            RunPostRefreshData();
            CloseConnection();
        }

        // 추상 메소드 재정의: 데이터 새로고침 실행 후처리
        public override void RunPostRefreshData() {
            SubjectList.Clear();    // 리스트 초기화
            // SELECT 결과로 객체를 만들어 리스트에 추가(단, 상위 7개 교과목으로 제한함)
            while (reader.Read() && SubjectList.Count < 7) {
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

        // 메소드: 교과목 추천 결과 데이터를 텍스트 파일로 저장(쓰기)
        // 저장 성공 시 null 리턴, 예외 발생 시 예외 메시지 리턴
        public string SaveToTextFile(string filepath) {
            int rank = 0;
            FileStream fs = null;
            StreamWriter sw = null;
            try {
                fs = new FileStream(filepath, FileMode.Create, FileAccess.Write);   // 쓰기 모드로 파일 스트림(바이트 스트림) 생성
                sw = new StreamWriter(fs, System.Text.Encoding.Default);            // 바이트 스트림을 문자 스트림으로 변환
                // 교과목 리스트 내 객체 정보를 하나씩 파일에 쓰기
                foreach (Subject subject in SubjectList) {
                    sw.WriteLine("{0}위: {1} {2} ", ++rank, subject.Id, subject.Name);
                    sw.WriteLine("({0}학년 {1}학기, {2}, 팀 과제 {3})",
                        subject.Year, subject.Term, subject.LectureType, subject.TeamProject);
                    sw.WriteLine();
                }
                return null;        // 파일 읽기 성공 시, null 리턴
            } catch (Exception e) {
                return e.Message;   // 파일 읽기 중 예외 발생 시, 예외 메시지 리턴
            } finally {
                sw.Close();
                fs.Close();
            }
        }
    }
}
