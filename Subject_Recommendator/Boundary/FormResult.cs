using System;
using System.IO;
using System.Windows.Forms;

namespace Subject_Recommendator {
    // Boundary 클래스: 교과목 추천 결과 Form (FormSubjectlistView의 파생 클래스)
    public partial class FormResult : Subject_Recommendator.FormSubjectListView {
        // 필드
        ControlResult ctrl = new ControlResult();     // 제어 객체
        SaveFileDialog saveFileDialog;                // 파일 저장 다이얼로그

        // 생성자
        public FormResult() {
            InitializeComponent();
            RefreshListView();
            InitSaveFileDialog();
        }

        // 메소드: 파일 저장 다이얼로그 초기화(생성자 호출 시 실행)
        public void InitSaveFileDialog() {
            saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "텍스트 파일로 저장";        // 다이얼로그 제목
            saveFileDialog.FileName = "";                      // 다이얼로그가 띄워질 때 초기 파일명은 비워놓음
            saveFileDialog.InitialDirectory = Application.StartupPath;  // 초기 디렉터리를 exe 파일 위치로
            saveFileDialog.OverwritePrompt = true;          // 파일명 중복 시, 덮어쓸지 묻는 다이얼로그 출력
            saveFileDialog.Filter = "텍스트 파일(*.txt)|*.txt|모든 파일|*.*";    
        }

        // 메소드 재정의: 교과목 리스트뷰 새로고침(리스트뷰 초기화 후 처음부터 새로 추가하는 방식)
        public new void RefreshListView() {
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

        // 메소드: [텍스트 파일로 저장] 클릭 시, 파일 저장 다이얼로그를 띄움
        private void btnSaveToTextFile_Click(object sender, EventArgs e) {
            saveFileDialog.FileName = "";
            DialogResult dialogResult = saveFileDialog.ShowDialog();
            if (dialogResult == DialogResult.OK) {      // 파일 저장 다이얼로그에서 [저장] 버튼을 눌렀을 경우
                string errMsg = ctrl.SaveToTextFile(saveFileDialog.FileName);   // 파일 쓰기 실행 후 에러 메시지 리턴(쓰기 성공 시 null 리턴)
                if (errMsg == null)
                    MessageBox.Show("파일 저장을 완료하였습니다.\n(" + saveFileDialog.FileName + ")", "텍스트 파일로 저장",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("파일 저장에 실패하였습니다.\n(" + errMsg + ")", "텍스트 파일로 저장",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // 메소드: Form을 닫기 전에 종료할지 묻는 메시지박스 출력
        private void FormResult_FormClosing(object sender, FormClosingEventArgs e) {
            DialogResult rs = MessageBox.Show("이 창을 종료하고 나면, 현재 출력된 교과목 추천 결과를 더 이상 확인할 수 없습니다." +
                        "\n정말로 종료하시겠습니까?" +
                        "\n\n※ [텍스트 파일로 저장] 버튼을 눌러 txt 파일로 저장 가능",
                        "교과목 추천 결과 닫기",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button2);

            if (rs == DialogResult.No)  // [아니오] 선택 시
                e.Cancel = true;        // 종료 이벤트를 취소함
        }
    }
}
