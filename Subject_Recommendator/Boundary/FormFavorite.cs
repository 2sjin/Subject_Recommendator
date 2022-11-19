using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Subject_Recommendator {
    public partial class FormFavorite : Subject_Recommendator.FormSubjectTable {
        // 필드
        ControlFavorite ctrl = new ControlFavorite();     // 제어 객체

        public FormFavorite() {
            InitializeComponent();
            UpdateTable();
        }

        // 교과목 테이블 갱신
        public void UpdateTable() {
            Table.Items.Clear();
            foreach (Subject s in ctrl.FavoriteList) {
                ListViewItem item = new ListViewItem();
                item.Text = s.Id.ToString();
                item.SubItems.Add(s.Name);
                item.SubItems.Add(s.Year.ToString());
                item.SubItems.Add(s.Term.ToString());
                item.SubItems.Add(s.LectureType);
                item.SubItems.Add(s.TeamProject);
                Table.Items.Add(item);
            }
        }

        private void button1_Click(object sender, EventArgs e) {
            FormSearch frmSearch = new FormSearch();
            frmSearch.Text = "즐겨찾기 추가";
            frmSearch.ShowDialog();
        }
    }
}
