using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Subject_Recommendator {
    public partial class FormMain : Form {
        public FormMain() {
            InitializeComponent();
            this.MaximizeBox = false;   // 최대화 버튼 비활성화
        }

        private void btnStart_Click(object sender, EventArgs e) {
            FormTest frmTest = new FormTest();
            frmTest.ShowDialog();
        }

        private void 교과목검색ToolStripMenuItem_Click(object sender, EventArgs e) {
            FormSearch frmSearch = new FormSearch();
            frmSearch.BtnAddFavorite.Visible = false;
            frmSearch.ShowDialog();
        }

        private void 즐겨찾기ToolStripMenuItem_Click(object sender, EventArgs e) {
            FormFavorite frmFavorite = new FormFavorite();
            frmFavorite.ShowDialog();
        }

        private void linkDeu_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            Process.Start("https://deu.ac.kr");
        }

        private void linkDeuCom_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            Process.Start("https://computer.deu.ac.kr");
        }

        private void linkMyTistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            Process.Start("https://2sjin.tistory.com");
        }

        private void linkMyGithub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            Process.Start("https://github.com/2sjin");
        }

        private void 끝내기ToolStripMenuItem_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e) {
            DialogResult rs =  MessageBox.Show("프로그램을 종료할까요?", "끝내기", MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (rs == DialogResult.No)
                e.Cancel = true;
        }
    }
}
