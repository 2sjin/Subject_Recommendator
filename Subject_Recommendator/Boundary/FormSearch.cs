using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Subject_Recommendator {
    public partial class FormSearch : Subject_Recommendator.FormSubjectListView {
        // 필드
        ControlSearch ctrl = new ControlSearch();     // 제어 객체
        bool isShowPlaceHolder = true;  // PlaceHolder이 보이고 있는가를 나타내는 필드

        // 생성자
        public FormSearch() {
            InitializeComponent();
            RefreshListView();
        }

        // 프로퍼티: 즐겨찾기에 추가 버튼
        public Button BtnAddFavorite {
            get { return btnAddFavorite; }
        }


        // PlaceHolder 구현: 검색창에 포커싱 되었을 때
        private void txtSearch_Enter(object sender, EventArgs e) {
            if (isShowPlaceHolder) {
                txtSearch.Text = "";
                txtSearch.ForeColor = SystemColors.WindowText;
                isShowPlaceHolder = false;
            }
        }

        // PlaceHolder 구현: 검색창에서 포커싱 해제가 되었을 때
        private void txtSearch_Leave(object sender, EventArgs e) {
            if ((isShowPlaceHolder == false) && txtSearch.Text.Equals("")) {
                txtSearch.Text = "(검색어를 입력하세요)";
                txtSearch.ForeColor = SystemColors.GrayText;
                isShowPlaceHolder = true;
            }
        }

        // 교과목 리스트뷰 갱신
        public void RefreshListView() {
            SubjectListView.Items.Clear();
            foreach (Subject s in ctrl.SubjectList) {
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

        // 체크박스 체크 여부에 따른 필터링 문자열 리턴(SQL의 WHERE절)
        private string GetFilterSQL() {
            string filterStr = "";

            filterStr += " AND LIMIT_YEAR IN(";
            filterStr += cbYear2.Checked ? "2" : "null";
            filterStr += ",";
            filterStr += cbYear3.Checked ? "3" : "null";
            filterStr += ",";
            filterStr += cbYear4.Checked ? "4" : "null";

            filterStr += ") AND TERM IN(";
            filterStr += cbTerm1.Checked ? "1" : "null";
            filterStr += ",";
            filterStr += cbTerm2.Checked ? "2" : "null";

            filterStr += ") AND LECTURE_TYPE IN(";
            filterStr += cbType1.Checked ? "'이론'" : "null";
            filterStr += ",";
            filterStr += cbType2.Checked ? "'이론/실습'" : "null";

            filterStr += ") AND TEAM_PROJECT IN(";
            filterStr += cbTeamYes.Checked ? "'있음'" : "null";
            filterStr += ",";
            filterStr += cbTeamNo.Checked ? "'없음'" : "null";
            filterStr += ",";
            filterStr += cbTeamUnknown.Checked ? "'불확실함'" : "null";
            filterStr += ")";

            return filterStr;
        }

        // 검색 버튼 클릭 시 이벤트
        private void btnSearch_Click(object sender, EventArgs e) {
            if (isShowPlaceHolder)
                ctrl.Search("", GetFilterSQL());
            else
                ctrl.Search(txtSearch.Text, GetFilterSQL());
            RefreshListView();
        }

        // 즐겨찾기에 추가 버튼 클릭 시 이벤트
        private void btnAddFavorite_Click(object sender, EventArgs e) {
            ControlFavorite ctrlFavorite = new ControlFavorite();
            ctrlFavorite.AddFavorite(int.Parse(lvSubject.SelectedItems[0].Text));
            MessageBox.Show("교과목을 즐겨찾기에 추가하였습니다.", "교과목 즐겨찾기 추가",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
