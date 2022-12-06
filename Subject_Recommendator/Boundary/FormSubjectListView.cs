using System;
using System.Windows.Forms;

namespace Subject_Recommendator {
    // Boundary 클래스: 교과목 ListView가 있는 Form (상속을 위해 만들어진 Form)
    public partial class FormSubjectListView : Form {
        // 생성자
        public FormSubjectListView() {
            InitializeComponent();
            this.MaximizeBox = false;   // 최대화 버튼 비활성화
        }

        // 프로퍼티: 교과목 테이블
        public ListView SubjectListView {
            get { return lvSubject; }
        }

        // 메소드: 리스트뷰 새로고침(파생 클래스에서 재정의하여 사용할 것)
        public void RefreshListView() { }

        // 메소드: 리스트뷰에서 항목을 더블클릭 하였을 때, 상세정보 Form 생성
        private void lvSubject_MouseDoubleClick(object sender, MouseEventArgs e) {
            FormDetail frmDetail = new FormDetail(int.Parse(lvSubject.SelectedItems[0].Text));
            frmDetail.ShowDialog();
        }

        // 메소드: [상세 정보 보기] 버튼을 눌렀을 때, 선택된 항목에 대한 상세정보 Form 생성
        private void btnDetail_Click(object sender, EventArgs e) {
            // 항목을 선택하지 않고 버튼을 누를 수도 있으므로, 예외 처리함
            try {
                FormDetail frmDetail = new FormDetail(int.Parse(lvSubject.SelectedItems[0].Text));
                frmDetail.ShowDialog();
            } catch (ArgumentOutOfRangeException err) {
                MessageBox.Show("교과목을 선택한 후 [상세 정보 보기] 버튼을 눌러주세요.", "교과목 상세 정보 보기",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 메소드: [닫기] 버튼을 눌렀을 때, Form 종료
        private void btnClose_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
