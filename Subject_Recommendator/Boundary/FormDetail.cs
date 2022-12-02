using System;
using System.Windows.Forms;

namespace Subject_Recommendator {
    public partial class FormDetail : Form {
        // 필드
        ControlDetail ctrl;     // 제어 객체

        public FormDetail(int subjectId) {
            ctrl = new ControlDetail(subjectId);
            InitializeComponent();
            UpdateInfo();
            this.MaximizeBox = false;   // 최대화 버튼 비활성화
            this.Text = labelSubjectName.Text;  // 교과목명을 Form 제목으로 표시
        }

        private void UpdateInfo() {
            labelSubjectId.Text = ctrl.SelectedSubject.Id.ToString();
            labelSubjectName.Text = ctrl.SelectedSubject.Name;
            labelYear.Text = ctrl.SelectedSubject.Year.ToString() + "학년";
            labelTerm.Text = ctrl.SelectedSubject.Term.ToString() + "학기";
            labelLectureType.Text = ctrl.SelectedSubject.LectureType;
            labelTeamProject.Text = ctrl.SelectedSubject.TeamProject;
            txtOutline.Text = ctrl.SelectedSubject.Outline;
        }

        private void btnClose_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
