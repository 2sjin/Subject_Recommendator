using System;
using System.Windows.Forms;

namespace Subject_Recommendator {
    public partial class FormSubjectListView : Form {
        public FormSubjectListView() {
            InitializeComponent();
            this.MaximizeBox = false;   // 최대화 버튼 비활성화
        }

        // 교과목 테이블 프로퍼티
        public ListView SubjectListView {
            get { return lvSubject; }
        }

        // 리스트뷰에서 항목을 더블클릭 하였을 때
        private void lvSubject_MouseDoubleClick(object sender, MouseEventArgs e) {
            FormDetail frmDetail = new FormDetail(int.Parse(lvSubject.SelectedItems[0].Text));
            frmDetail.ShowDialog();
        }

        // [상세 정보 보기] 버튼을 눌렀을 때
        private void btnDetail_Click(object sender, EventArgs e) {
            try {
                FormDetail frmDetail = new FormDetail(int.Parse(lvSubject.SelectedItems[0].Text));
                frmDetail.ShowDialog();
            } catch (ArgumentOutOfRangeException err) {
                MessageBox.Show("교과목을 선택한 후 [상세 정보 보기] 버튼을 눌러주세요.", "교과목 상세 정보 보기",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // [닫기] 버튼을 눌렀을 때
        private void btnClose_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
