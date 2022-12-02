using System;
using System.IO;
using System.Windows.Forms;

namespace Subject_Recommendator {
    public partial class FormResult : Subject_Recommendator.FormSubjectListView {
        // 필드
        ControlResult ctrl = new ControlResult();     // 제어 객체
        SaveFileDialog saveFileDialog;   // 파일 저장 다이얼로그

        // 생성자
        public FormResult() {
            InitializeComponent();
            RefreshListView();
            InitSaveFileDialog();
        }

        // 메소드: 파일 저장 다이얼로그 초기화(생성자 호출 시 실행)
        public void InitSaveFileDialog() {
            saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "텍스트 파일로 저장";
            saveFileDialog.FileName = "";
            saveFileDialog.InitialDirectory = Application.StartupPath;  // 초기 디렉터리를 exe 파일의 위치로 설정
            saveFileDialog.OverwritePrompt = true;
            saveFileDialog.Filter = "텍스트 파일(*.txt)|*.txt|모든 파일|*.*";    
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

        // 메소드: [텍스트 파일로 저장] 클릭 시
        private void btnSaveToTextFile_Click(object sender, EventArgs e) {
            saveFileDialog.FileName = "";
            DialogResult dialogResult = saveFileDialog.ShowDialog();
            if (dialogResult == DialogResult.OK) {
                string errMsg = ctrl.SaveToTextFile(saveFileDialog.FileName);
                if (errMsg == null)
                    MessageBox.Show("파일 저장을 완료하였습니다.\n(" + saveFileDialog.FileName + ")", "텍스트 파일로 저장",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("파일 저장에 실패하였습니다.\n(" + errMsg + ")", "텍스트 파일로 저장",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
