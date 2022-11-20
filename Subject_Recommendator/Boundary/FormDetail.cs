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
        }

        private void UpdateInfo() {
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
