using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Subject_Recommendator {
    public partial class FormSearch : Subject_Recommendator.FormSubjectTable {
        ControlSearch ctrl = new ControlSearch();     // 제어 객체
        bool isShowPlaceHolder = true;  // PlaceHolder이 보이고 있는가를 나타내는 필드

        public FormSearch() {
            InitializeComponent();
            UpdateTable();
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

        // 교과목 테이블 갱신
        public void UpdateTable() {
            Table.Items.Clear();
            foreach (Subject s in ctrl.SubjectList) {
                ListViewItem item = new ListViewItem();
                item.Text = s.Name;
                item.SubItems.Add(s.Year.ToString());
                item.SubItems.Add(s.Term.ToString());
                item.SubItems.Add(s.LectureType);
                item.SubItems.Add(s.TeamProject);
                Table.Items.Add(item);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e) {
            if (isShowPlaceHolder)
                ctrl.Search("");
            else
                ctrl.Search(txtSearch.Text);
            UpdateTable();
        }
    }
}
