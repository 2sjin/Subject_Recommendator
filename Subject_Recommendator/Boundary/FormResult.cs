using System;
using System.Windows.Forms;

namespace Subject_Recommendator {
    public partial class FormResult : Subject_Recommendator.FormSubjectListView {
        // 필드
        ControlResult ctrl = new ControlResult();     // 제어 객체

        // 생성자
        public FormResult() {
            InitializeComponent();
            RefreshListView();
        }

        // 메소드: 교과목 리스트뷰 갱신
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

        private void button1_Click(object sender, EventArgs e) {

        }
    }
}
