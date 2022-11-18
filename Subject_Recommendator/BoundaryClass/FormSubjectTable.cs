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
    public partial class FormSubjectTable : Form {
        public FormSubjectTable() {
            InitializeComponent();
        }

        private void btnDetail_Click(object sender, EventArgs e) {
            FormDetail frmDetail = new FormDetail();
            frmDetail.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
