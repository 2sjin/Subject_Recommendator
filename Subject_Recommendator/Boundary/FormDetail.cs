using System;
using System.Windows.Forms;

namespace Subject_Recommendator {
    // Boundary 클래스: 교과목 상세정보 보기 Form
    public partial class FormDetail : Form {
        // 필드
        ControlDetail ctrl;     // 제어 객체

        // 생성자
        public FormDetail(int subjectId) {
            ctrl = new ControlDetail(subjectId);
            InitializeComponent();
            ShowSubjectInfo();
            this.MaximizeBox = false;   // 최대화 버튼 비활성화
            this.Text = labelSubjectName.Text;  // 교과목명을 Form 제목으로 표시
        }

        // 메소드: 제어 클래스에서 '선택된 교과목' 객체의 정보를 가져와 컨트롤에 텍스트 출력함
        private void ShowSubjectInfo() {
            labelSubjectId.Text = ctrl.SelectedSubject.Id.ToString();
            labelSubjectName.Text = ctrl.SelectedSubject.Name;
            labelYear.Text = ctrl.SelectedSubject.Year.ToString() + "학년";
            labelTerm.Text = ctrl.SelectedSubject.Term.ToString() + "학기";
            labelLectureType.Text = ctrl.SelectedSubject.LectureType;
            labelTeamProject.Text = ctrl.SelectedSubject.TeamProject;
            txtOutline.Text = ctrl.SelectedSubject.Outline;
        }

        // 메소드: [닫기] 버튼을 눌렀을 때, Form 종료
        private void btnClose_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
