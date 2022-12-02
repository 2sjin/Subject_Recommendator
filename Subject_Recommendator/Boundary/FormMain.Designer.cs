namespace Subject_Recommendator {
    partial class FormMain {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent() {
            this.btnStart = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.교과목검색ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.즐겨찾기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.종료ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.linkMyGithub = new System.Windows.Forms.LinkLabel();
            this.linkMyTistory = new System.Windows.Forms.LinkLabel();
            this.linkDeuCom = new System.Windows.Forms.LinkLabel();
            this.linkDeu = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnStart.Font = new System.Drawing.Font("맑은 고딕", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnStart.Location = new System.Drawing.Point(0, 337);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(571, 80);
            this.btnStart.TabIndex = 8;
            this.btnStart.Text = "진단검사 시작";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("굴림", 9F);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.교과목검색ToolStripMenuItem,
            this.즐겨찾기ToolStripMenuItem,
            this.종료ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(571, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 교과목검색ToolStripMenuItem
            // 
            this.교과목검색ToolStripMenuItem.Font = new System.Drawing.Font("굴림", 9F);
            this.교과목검색ToolStripMenuItem.Name = "교과목검색ToolStripMenuItem";
            this.교과목검색ToolStripMenuItem.Size = new System.Drawing.Size(101, 26);
            this.교과목검색ToolStripMenuItem.Text = "교과목 검색";
            this.교과목검색ToolStripMenuItem.Click += new System.EventHandler(this.교과목검색ToolStripMenuItem_Click);
            // 
            // 즐겨찾기ToolStripMenuItem
            // 
            this.즐겨찾기ToolStripMenuItem.Font = new System.Drawing.Font("굴림", 9F);
            this.즐겨찾기ToolStripMenuItem.Name = "즐겨찾기ToolStripMenuItem";
            this.즐겨찾기ToolStripMenuItem.Size = new System.Drawing.Size(131, 26);
            this.즐겨찾기ToolStripMenuItem.Text = "교과목 즐겨찾기";
            this.즐겨찾기ToolStripMenuItem.Click += new System.EventHandler(this.즐겨찾기ToolStripMenuItem_Click);
            // 
            // 종료ToolStripMenuItem
            // 
            this.종료ToolStripMenuItem.Name = "종료ToolStripMenuItem";
            this.종료ToolStripMenuItem.Size = new System.Drawing.Size(66, 26);
            this.종료ToolStripMenuItem.Text = "끝내기";
            this.종료ToolStripMenuItem.Click += new System.EventHandler(this.끝내기ToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("굴림", 9F);
            this.tabControl1.Location = new System.Drawing.Point(28, 48);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(520, 271);
            this.tabControl1.TabIndex = 11;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(512, 242);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "유의사항";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.linkMyGithub);
            this.tabPage2.Controls.Add(this.linkMyTistory);
            this.tabPage2.Controls.Add(this.linkDeuCom);
            this.tabPage2.Controls.Add(this.linkDeu);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(512, 242);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "관련사이트";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // linkMyGithub
            // 
            this.linkMyGithub.AutoSize = true;
            this.linkMyGithub.Font = new System.Drawing.Font("맑은 고딕", 11F);
            this.linkMyGithub.Location = new System.Drawing.Point(30, 180);
            this.linkMyGithub.Name = "linkMyGithub";
            this.linkMyGithub.Size = new System.Drawing.Size(201, 25);
            this.linkMyGithub.TabIndex = 13;
            this.linkMyGithub.TabStop = true;
            this.linkMyGithub.Text = "개발자 GitHub 저장소";
            this.linkMyGithub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkMyGithub_LinkClicked);
            // 
            // linkMyTistory
            // 
            this.linkMyTistory.AutoSize = true;
            this.linkMyTistory.Font = new System.Drawing.Font("맑은 고딕", 11F);
            this.linkMyTistory.Location = new System.Drawing.Point(30, 130);
            this.linkMyTistory.Name = "linkMyTistory";
            this.linkMyTistory.Size = new System.Drawing.Size(197, 25);
            this.linkMyTistory.TabIndex = 12;
            this.linkMyTistory.TabStop = true;
            this.linkMyTistory.Text = "개발자 Tistory 블로그";
            this.linkMyTistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkMyTistory_LinkClicked);
            // 
            // linkDeuCom
            // 
            this.linkDeuCom.AutoSize = true;
            this.linkDeuCom.Font = new System.Drawing.Font("맑은 고딕", 11F);
            this.linkDeuCom.Location = new System.Drawing.Point(30, 80);
            this.linkDeuCom.Name = "linkDeuCom";
            this.linkDeuCom.Size = new System.Drawing.Size(311, 25);
            this.linkDeuCom.TabIndex = 11;
            this.linkDeuCom.TabStop = true;
            this.linkDeuCom.Text = "동의대학교 컴퓨터공학과 홈페이지";
            this.linkDeuCom.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkDeuCom_LinkClicked);
            // 
            // linkDeu
            // 
            this.linkDeu.AutoSize = true;
            this.linkDeu.Font = new System.Drawing.Font("맑은 고딕", 11F);
            this.linkDeu.Location = new System.Drawing.Point(30, 30);
            this.linkDeu.Name = "linkDeu";
            this.linkDeu.Size = new System.Drawing.Size(190, 25);
            this.linkDeu.TabIndex = 10;
            this.linkDeu.TabStop = true;
            this.linkDeu.Text = "동의대학교 홈페이지";
            this.linkDeu.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkDeu_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 14F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(17, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "유의사항";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 9F);
            this.label2.Location = new System.Drawing.Point(18, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(436, 120);
            this.label2.TabIndex = 1;
            this.label2.Text = "● 아래 [진단검사 시작] 버튼을 눌러 진단검사를 진행하십시오.\r\n\r\n● 진단검사 예상 소요 시간은 1~2분입니다.\r\n\r\n● 정확한 결과를 원한다" +
    "면, 가능한 \'보통\'을 선택하지 마십시오.\r\n\r\n● 문항을 정확하게 읽지 않고 한 버튼을 반복해서 선택하면,\r\n    부정확한 결과가 출력될 수" +
    " 있습니다.";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 417);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormMain";
            this.Text = "컴퓨터공학과 전공선택 교과목 추천 프로그램";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 교과목검색ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 즐겨찾기ToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.LinkLabel linkDeu;
        private System.Windows.Forms.LinkLabel linkDeuCom;
        private System.Windows.Forms.LinkLabel linkMyGithub;
        private System.Windows.Forms.LinkLabel linkMyTistory;
        private System.Windows.Forms.ToolStripMenuItem 종료ToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

