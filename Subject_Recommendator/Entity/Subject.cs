namespace Subject_Recommendator {
    // 교과목 엔티티 클래스
    public class Subject {
        // 프로퍼티
        public int Id { get; set; }     // 교과목번호
        public string Name { get; set; }   // 교과목명
        public int Year { get; set; }      // 학년
        public int Term { get; set; }      // 개설학기
        public string LectureType { get; set; }   // 강의유형
        public string TeamProject { get; set; }   // 팀 과제 여부    
        public string Outline { get; set; }    // 교과목개요
    }
}
