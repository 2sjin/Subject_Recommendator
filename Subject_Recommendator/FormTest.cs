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
        public FormTest() {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e) {
            // 메시지박스에서 입력한 버튼을 
            DialogResult rs = MessageBox.Show("진단검사를 정말로 종료하시겠습니까?",
                                                "진단검사 종료",
                                                MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Question,
                                                MessageBoxDefaultButton.Button2);

            if (rs == DialogResult.Yes)
                this.Close();
        }
    }
}
