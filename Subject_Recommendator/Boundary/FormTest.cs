using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Subject_Recommendator {
    public partial class FormTest : Form {
        // 필드
        ControlTest ctrl = new ControlTest();   // 제어 객체
        int questionIndex = 0;                  // 문항 인덱스

        public FormTest() {
            InitializeComponent();
            RefreshQuestion();
        }

        // 문항 갱신
        public void RefreshQuestion() {
            // 마지막 문항일 경우 결과 Form 출력
            if (questionIndex >= ctrl.QuestionList.Count) {
                this.Close();
                FormResult frmResult = new FormResult();
                frmResult.ShowDialog();
                return;
            }

            // 다음 문항으로 이동
            txtQuestion.Text = ctrl.QuestionList[questionIndex].Content;
            questionIndex++;
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

        private void btnAnswer1_Click(object sender, EventArgs e) {
            RefreshQuestion();
        }

        private void btnAnswer2_Click(object sender, EventArgs e) {
            RefreshQuestion();
        }

        private void btnAnswer3_Click(object sender, EventArgs e) {
            RefreshQuestion();
        }

        private void btnAnswer4_Click(object sender, EventArgs e) {
            RefreshQuestion();
        }

        private void btnAnswer5_Click(object sender, EventArgs e) {
            RefreshQuestion();
        }
    }
}
