using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Subject_Recommendator {
    public partial class FormFavorite : Subject_Recommendator.FormSubjectListView {
        // 필드
        ControlFavorite ctrl = new ControlFavorite();     // 제어 객체

        public FormFavorite() {
            InitializeComponent();
            RefreshListView();
        }

        // 즐겨찾기 리스트뷰 갱신
        public void RefreshListView() {
            ctrl.Refresh();
            SubjectListView.Items.Clear();
            foreach (Subject s in ctrl.FavoriteList) {
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
            FormSearch frmSearch = new FormSearch();
            frmSearch.Text = "즐겨찾기 추가";
            frmSearch.ShowDialog();
            RefreshListView();
        }

        // 삭제 버튼 클릭 시
        private void btnDelete_Click(object sender, EventArgs e) {
            MessageBox.Show("교과목을 즐겨찾기에서 삭제하시겠습니까?", "교과목 즐겨찾기 삭제");
            ctrl.DeleteFavorite(int.Parse(lvSubject.SelectedItems[0].Text));
            RefreshListView();
        }
    }
}
