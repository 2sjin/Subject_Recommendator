using System;
using System.Drawing;
using System.Windows.Forms;

namespace Subject_Recommendator {
    public partial class FormTest : Form {
        // 필드
        ControlTest ctrl = new ControlTest();   // 제어 객체
        int[] arrayOfBtnClickCount = { 0, 0, 0, 0, 0 };        // 각 버튼이 몇번 눌렀는지를 저장할 배열

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

            // 마지막 문항일 경우
            if (ctrl.CurrentQuestionId >= ctrl.QuestionList.Count) {
                completeTest();
                return;
            }

            // 다음 문항으로 이동
            txtQuestion.Text = ctrl.QuestionList[ctrl.CurrentQuestionId].Content;
            ctrl.CurrentQuestionId++;
        }

        // 진단검사 완료 처리
        public void completeTest() {
            // 응답 버튼 비활성화
            btnAnswer1.Enabled = false;
            btnAnswer2.Enabled = false;
            btnAnswer3.Enabled = false;
            btnAnswer4.Enabled = false;
            btnAnswer5.Enabled = false;

            // 이스터에그 조건(같은 버튼만 계속 클릭)을 만족할 경우, 이스터에그 예외 처리
            for (int i = 0; i < 5; i++) {
                if (arrayOfBtnClickCount[i] >= ctrl.QuestionList.Count) {
                    try {
                        throw new EasterEggException(i);     // 이스터에그 예외 실행
                    } catch (EasterEggException e) {
                        return;     // 교과목 추천 결과 Form을 출력하지 않고 리턴함
                    } finally {
                        txtQuestion.Text = "버튼 하나만 계속 눌러서 응답하셨나요? " +
                            "모든 교과목이 공동 1위가 되어 교과목을 추천할 수 없었습니다. " +
                            "마음을 가다듬고, 메인 화면의 유의사항을 잘 읽어본 후 다시 시도해보세요!";
                        progressBar1.Style = ProgressBarStyle.Marquee;
                        lblProgress.Text = "(×﹏×)";
                        lblProgress.ForeColor = System.Drawing.Color.Blue;
                        lblProgress.Font = new Font("맑은 고딕", 13, FontStyle.Bold);
                        btnAnswer1.Hide();
                        btnAnswer2.Hide();
                        btnAnswer3.Hide();
                        btnAnswer4.Hide();
                        btnAnswer5.Hide();
                    }
                }
            }

            // 교과목 추천 결과 Form 출력
            this.Close();
            FormResult frmResult = new FormResult();
            frmResult.ShowDialog();
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
            ctrl.increaseScore(ctrl.CurrentQuestionId, 5);
            arrayOfBtnClickCount[0] += 1;
            RefreshQuestion();
        }

        private void btnAnswer4_Click(object sender, EventArgs e) {
            ctrl.increaseScore(ctrl.CurrentQuestionId, 4);
            arrayOfBtnClickCount[1] += 1;
            RefreshQuestion();
        }

        private void btnAnswer3_Click(object sender, EventArgs e) {
            ctrl.increaseScore(ctrl.CurrentQuestionId, 3);
            arrayOfBtnClickCount[2] += 1;
            RefreshQuestion();
        }

        private void btnAnswer2_Click(object sender, EventArgs e) {
            ctrl.increaseScore(ctrl.CurrentQuestionId, 2);
            arrayOfBtnClickCount[3] += 1;
            RefreshQuestion();
        }

        private void btnAnswer1_Click(object sender, EventArgs e) {
            ctrl.increaseScore(ctrl.CurrentQuestionId, 1);
            arrayOfBtnClickCount[4] += 1;
            RefreshQuestion();
        }

        // 중첩 클래스: 사용자 정의 예외(이스터에그)
        public class EasterEggException : ApplicationException {
            public EasterEggException(int i) : base() {
                string strEasterEggMsg = "";
                switch (i) {
                    case 0: case 1:
                        strEasterEggMsg = "모든 것을 긍정적으로 바라보는 마음가짐이 삶을 아름답게 변화시키죠. ";
                        strEasterEggMsg += "하지만 살다보면 비판적인 생각도 조금은 필요하지 않을까요?";
                        break;
                    case 2:
                        strEasterEggMsg = "당신은 그냥 보통 사람입니다.";
                        break;
                    case 3: case 4:
                        strEasterEggMsg = "모든 것에 아니라고 솔직하게 말할 수 있는 당신의 용기에 감탄하였습니다. ";
                        strEasterEggMsg += "하지만 가끔씩 긍정적인 생각도 한다면 삶이 더욱 행복해지지 않을까요?";
                        break;
                }
                MessageBox.Show(strEasterEggMsg, "(×﹏×)", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
