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
            frmSearch.ShowDialog();
        }

        private void 즐겨찾기ToolStripMenuItem_Click(object sender, EventArgs e) {
            FormFavorite frmFavorite = new FormFavorite();
            frmFavorite.ShowDialog();
        }
    }
}
