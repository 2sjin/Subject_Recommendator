namespace Subject_Recommendator.EntityClass {

    // 교과목 엔티티 클래스
    class Subject {
        string Name { get; set; }   // 교과목명
        int Year { get; set; }      // 학년
        int Term { get; set; }      // 개설학기
        int TeamProject { get; set; }   // 팀 과제(0=없음, 1=있음, 2=불확실함)
        string Outline { get; set; }    // 교과목개요
    }
}
