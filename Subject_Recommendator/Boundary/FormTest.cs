using System;
using System.Windows.Forms;

namespace Subject_Recommendator {
    public partial class FormTest : Form {
        // 필드
        ControlTest ctrl = new ControlTest();   // 제어 객체

        public FormTest() {
            InitializeComponent();
            this.MaximizeBox = false;   // 최대화 버튼 비활성화
            ctrl.initScore();
            RefreshQuestion();
        }

        // 문항 갱신
        public void RefreshQuestion() {
            // 프로그레스 바 및 레이블 갱신
            progressBar1.Value = (ctrl.CurrentQuestionId * 100) / ctrl.QuestionList.Count;
            lblProgress.Text = $"{ctrl.QuestionList.Count} 중 {ctrl.CurrentQuestionId} 응답 ({progressBar1.Value} %)";

            // 마지막 문항일 경우 결과 Form 출력
            if (ctrl.CurrentQuestionId >= ctrl.QuestionList.Count) {
                this.Close();
                FormResult frmResult = new FormResult();
                frmResult.ShowDialog();
                return;
            }

            // 다음 문항으로 이동
            txtQuestion.Text = ctrl.QuestionList[ctrl.CurrentQuestionId].Content;
            ctrl.CurrentQuestionId++;
        }

        private void btnExit_Click(object sender, EventArgs e) {
            DialogResult rs = MessageBox.Show("진단검사 종료 시, 진행중인 데이터는 저장되지 않습니다." +
                                                "\n정말로 종료하시겠습니까?",
                                                "진단검사 종료",
                                                MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Question,
                                                MessageBoxDefaultButton.Button2);

            if (rs == DialogResult.Yes)
                this.Close();
        }

        private void btnAnswer5_Click(object sender, EventArgs e) {
            ctrl.abc(ctrl.CurrentQuestionId, 5);
            RefreshQuestion();
        }

        private void btnAnswer4_Click(object sender, EventArgs e) {
            ctrl.abc(ctrl.CurrentQuestionId, 4);
            RefreshQuestion();
        }

        private void btnAnswer3_Click(object sender, EventArgs e) {
            ctrl.abc(ctrl.CurrentQuestionId, 3);
            RefreshQuestion();
        }

        private void btnAnswer2_Click(object sender, EventArgs e) {
            ctrl.abc(ctrl.CurrentQuestionId, 2);
            RefreshQuestion();
        }

        private void btnAnswer1_Click(object sender, EventArgs e) {
            ctrl.abc(ctrl.CurrentQuestionId, 1);
            RefreshQuestion();
        }
    }
}
