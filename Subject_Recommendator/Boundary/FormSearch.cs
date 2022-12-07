using System;
using System.Drawing;
using System.Windows.Forms;

namespace Subject_Recommendator {
    // Boundary 클래스: 교과목 검색 Form (FormSubjectlistView의 파생 클래스)
    public partial class FormSearch : Subject_Recommendator.FormSubjectListView {
        // 필드
        ControlSearch ctrl = new ControlSearch();     // 제어 객체
        ControlFavorite ctrlFavorite = new ControlFavorite();   // 즐겨찾기 제어 객체(즐겨찾기 추가할 때 사용)
        bool isShowPlaceHolder = true;     // PlaceHolder가 보이고 있는지 표시
        bool isFavoriteAddMode = false;    // 지금 실행중인 검색 Form이 즐겨찾기 추가 모드로 실행중인지 표시

        // 프로퍼티: [즐겨찾기에 추가] 버튼(읽기 전용)
        public Button BtnAddFavorite {
            get { return btnAddFavorite; }
        }

        // 생성자
        public FormSearch(string mode="") {
            if (mode == "FAVORITE")         // 즐겨찾기 모드로 Form이 실행된 경우
                isFavoriteAddMode = true;   // 즐겨찾기 모드임을 표시함
            InitializeComponent();
            RefreshListView();
        }

        // 메소드 재정의: 교과목 리스트뷰 새로고침(리스트뷰 초기화 후 처음부터 새로 추가하는 방식)
        public new void RefreshListView() {
            if (isFavoriteAddMode)                  // 즐겨찾기 추가 모드로 Form 실행중이면
                ctrl.removeAlreadyFavorite();       // 즐겨찾기 추가 불가능한 교과목은 제거

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

        // 메소드: 체크박스 체크 여부에 따른 필터링 문자열 리턴(SQL의 WHERE절)
        private string GetFilterSQL() {
            string filterStr = "";

            // 학년 체크박스 확인
            filterStr += " AND LIMIT_YEAR IN(";
            filterStr += cbYear2.Checked ? "2" : "null";
            filterStr += ",";
            filterStr += cbYear3.Checked ? "3" : "null";
            filterStr += ",";
            filterStr += cbYear4.Checked ? "4" : "null";

            // 개설학기 체크박스 확인
            filterStr += ") AND TERM IN(";
            filterStr += cbTerm1.Checked ? "1" : "null";
            filterStr += ",";
            filterStr += cbTerm2.Checked ? "2" : "null";

            // 강의유형 체크박스 확인
            filterStr += ") AND LECTURE_TYPE IN(";
            filterStr += cbType1.Checked ? "'이론'" : "null";
            filterStr += ",";
            filterStr += cbType2.Checked ? "'이론/실습'" : "null";

            // 팀 과제 여부 체크박스 확인
            filterStr += ") AND TEAM_PROJECT IN(";
            filterStr += cbTeamYes.Checked ? "'있음'" : "null";
            filterStr += ",";
            filterStr += cbTeamNo.Checked ? "'없음'" : "null";
            filterStr += ",";
            filterStr += cbTeamUnknown.Checked ? "'불확실함'" : "null";
            filterStr += ")";

            return filterStr;
        }

        // 메소드: 검색 메소드(오버로드(메소드 중복)했던 ctrlFavorite.RefreshData() 메소드 호출)
        private void Search() {
            if (isShowPlaceHolder)  // PlaceHolder가 보이면, 검색창이 빈 것으로 간주하여 데이터 새로고침
                ctrl.RefreshData(GetFilterSQL());
            else                    // PlaceHolder가 보이지 않으면, 검색창에 입력한 텍스트를 기반으로 데이터 새로고침
                ctrl.RefreshData(GetFilterSQL(), comboBox1.Text, txtSearch.Text);
            RefreshListView();  // 리스트뷰 새로고침
        }

        // 메소드: 검색 버튼 클릭 시 검색 수행
        private void btnSearch_Click(object sender, EventArgs e) {
            Search();
        }

        // 메소드: 검색창에서 [Enter] 키 클릭 시 검색 수행
        private void txtSearch_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter)
                Search();
        }

        // 메소드: 즐겨찾기 추가 버튼 클릭 시 이벤트
        private void btnAddFavorite_Click(object sender, EventArgs e) {
            // 즐겨찾기 추가(중복된 연산자 사용)
            try {
                if (ctrlFavorite + int.Parse(lvSubject.SelectedItems[0].Text)) {
                    MessageBox.Show("교과목을 즐겨찾기에 추가하였습니다.", "교과목 즐겨찾기 추가",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            } catch (ArgumentOutOfRangeException err) {
                MessageBox.Show("교과목 선택 후 [즐겨찾기 추가] 버튼을 눌러주세요.", "교과목 즐겨찾기 추가",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        // 메소드: Form이 로드될 때, 콤보박스의 초기 텍스트 설정
        private void FormSearch_Load(object sender, EventArgs e) {
            comboBox1.Text = "교과목명";
        }

        // 메소드: 검색창에 포커싱 되었을 때(PlaceHolder 구현부)
        private void txtSearch_Enter(object sender, EventArgs e) {
            if (isShowPlaceHolder) {    // PlaceHolder가 보인다면
                txtSearch.Text = "";    // PlaceHolder 없앰
                txtSearch.ForeColor = SystemColors.WindowText;
                isShowPlaceHolder = false;  //PlaceHolder가 없다고 표시함
            }
        }

        // 메소드: 검색창에서 포커싱 해제가 되었을 때(PlaceHolder 구현부)
        private void txtSearch_Leave(object sender, EventArgs e) {
            if ((isShowPlaceHolder == false) && txtSearch.Text.Equals("")) {    // 검색창이 비어있으면
                txtSearch.Text = "(검색어를 입력하세요)";    // PlaceHolder 출력
                txtSearch.ForeColor = SystemColors.GrayText;
                isShowPlaceHolder = true;       // PlaceHolder가 있다고 표시함
            }
        }
    }
}
