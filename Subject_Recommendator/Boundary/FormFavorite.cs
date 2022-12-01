using System;
using System.Windows.Forms;

namespace Subject_Recommendator {
    public partial class FormFavorite : Subject_Recommendator.FormSubjectListView {
        // 필드
        ControlFavorite ctrlFavorite = new ControlFavorite();     // 제어 객체

        public FormFavorite() {
            InitializeComponent();
            RefreshListView();
        }

        // 즐겨찾기 리스트뷰 갱신
        public void RefreshListView() {
            ctrlFavorite.RefreshData();
            SubjectListView.Items.Clear();
            foreach (Subject s in ctrlFavorite.FavoriteList) {
                ListViewItem item = new ListViewItem();
                item.Text = s.Id.ToString();
                item.SubItems.Add(s.Name);
                item.SubItems.Add(s.Year.ToString());
                item.SubItems.Add(s.Term.ToString());
                item.SubItems.Add(s.LectureType);
                item.SubItems.Add(s.TeamProject);
                SubjectListView.Items.Add(item);
            }
        }

        // 추가 버튼 클릭 시
        private void btnAdd_Click(object sender, EventArgs e) {
            FormSearch frmSearch = new FormSearch("FAVORITE");
            frmSearch.Text = "즐겨찾기 추가";
            frmSearch.BtnAddFavorite.Visible = true;
            frmSearch.ShowDialog();
            RefreshListView();
        }

        // 삭제 버튼 클릭 시
        private void btnDelete_Click(object sender, EventArgs e) {
            DialogResult rs = MessageBox.Show("교과목을 즐겨찾기에서 삭제하시겠습니까?", "교과목 즐겨찾기 삭제",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            if (rs == DialogResult.Yes) {
                try {
                    // 즐겨찾기 삭제(중복된 연산자 사용)
                    if (ctrlFavorite - int.Parse(lvSubject.SelectedItems[0].Text)) {
                        MessageBox.Show("교과목을 삭제하였습니다.", "교과목 즐겨찾기 삭제",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                } catch (ArgumentOutOfRangeException err) {
                    MessageBox.Show("교과목을 선택한 후 [삭제] 버튼을 눌러주세요.", "교과목 즐겨찾기 삭제",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                } finally {
                    RefreshListView();  // 삭제 반영된 즐겨찾기 목록 새로고침
                }
            }
        }
    }
}
