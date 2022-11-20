using System;
using System.Windows.Forms;

namespace Subject_Recommendator {
    public partial class FormMain : Form {
        public FormMain() {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e) {
            FormTest frmTest = new FormTest();
            frmTest.ShowDialog();
        }

        private void btnDebug_Click(object sender, EventArgs e) {
            new FormResult().Show();
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
    }
}
