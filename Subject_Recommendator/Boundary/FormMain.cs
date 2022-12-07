using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Subject_Recommendator {
    // Boundary 클래스: 메인 Form
    public partial class FormMain : Form {
        // 생성자
        public FormMain() {
            InitializeComponent();
            this.MaximizeBox = false;   // 최대화 버튼 비활성화
        }

        // 메소드: [진단검사 시작] 버튼 클릭 시, 진단검사 Form 생성
        private void btnStart_Click(object sender, EventArgs e) {
            FormTest frmTest = new FormTest();
            frmTest.ShowDialog();
        }

        // 메소드: 교과목검색 메뉴 클릭 시, 검색 Form 생성
        private void 교과목검색ToolStripMenuItem_Click(object sender, EventArgs e) {
            FormSearch frmSearch = new FormSearch();
            frmSearch.BtnAddFavorite.Visible = false;   // 단순 검색이므로, [즐겨찾기 추가] 버튼 비활성화
            frmSearch.ShowDialog();
        }

        // 메소드: 즐겨찾기 메뉴 클릭 시, 즐겨찾기 Form 생성
        private void 즐겨찾기ToolStripMenuItem_Click(object sender, EventArgs e) {
            FormFavorite frmFavorite = new FormFavorite();
            frmFavorite.ShowDialog();
        }

        // 메소드: 끝내기 메뉴 클릭 시, 프로그램(메인 Form) 종료
        private void 끝내기ToolStripMenuItem_Click(object sender, EventArgs e) {
            this.Close();
        }

        // 메소드: 프로그램(메인 Form)을 닫기 전에 종료할지 묻는 메시지박스 출력
        private void FormMain_FormClosing(object sender, FormClosingEventArgs e) {
            DialogResult rs =  MessageBox.Show("프로그램을 종료할까요?", "끝내기", MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (rs == DialogResult.No)  // [아니오] 선택 시
                e.Cancel = true;        // 종료 이벤트를 취소함
        }

        // 메소드: 링크 클릭 시, 동의대학교 홈페이지로 이동
        private void linkDeu_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            Process.Start("https://deu.ac.kr");
        }
        // 메소드: 링크 클릭 시, 동의대학교 컴퓨터공학과 홈페이지로 이동
        private void linkDeuCom_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            Process.Start("https://computer.deu.ac.kr");
        }
        // 메소드: 링크 클릭 시, 개발자 Tistory로 이동
        private void linkMyTistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            Process.Start("https://2sjin.tistory.com");
        }
        // 메소드: 링크 클릭 시, 게발자 GitHub로 이동
        private void linkMyGithub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            Process.Start("https://github.com/2sjin");
        }

    }
}
