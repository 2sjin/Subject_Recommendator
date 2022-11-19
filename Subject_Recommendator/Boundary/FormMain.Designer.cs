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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbTerm2 = new System.Windows.Forms.CheckBox();
            this.cbTerm1 = new System.Windows.Forms.CheckBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnDebug = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.교과목검색ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.즐겨찾기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbTerm2);
            this.groupBox1.Controls.Add(this.cbTerm1);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.checkBox3);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(24, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(548, 193);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "교과목 추천 조건";
            // 
            // cbTerm2
            // 
            this.cbTerm2.AutoSize = true;
            this.cbTerm2.Location = new System.Drawing.Point(268, 100);
            this.cbTerm2.Name = "cbTerm2";
            this.cbTerm2.Size = new System.Drawing.Size(67, 19);
            this.cbTerm2.TabIndex = 3;
            this.cbTerm2.Text = "2학기";
            this.cbTerm2.UseVisualStyleBackColor = true;
            // 
            // cbTerm1
            // 
            this.cbTerm1.AutoSize = true;
            this.cbTerm1.Location = new System.Drawing.Point(150, 100);
            this.cbTerm1.Name = "cbTerm1";
            this.cbTerm1.Size = new System.Drawing.Size(67, 19);
            this.cbTerm1.TabIndex = 2;
            this.cbTerm1.Text = "1학기";
            this.cbTerm1.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(150, 57);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(100, 25);
            this.numericUpDown1.TabIndex = 1;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown1.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(389, 140);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(89, 19);
            this.checkBox3.TabIndex = 7;
            this.checkBox3.Text = "불확실함";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(268, 140);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(59, 19);
            this.checkBox2.TabIndex = 6;
            this.checkBox2.Text = "없음";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(150, 140);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(59, 19);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "있음";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(256, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(222, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "학년 이하의 과목만 추천합니다.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "팀 과제: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "개설학기: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "학년: ";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(226, 287);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(144, 52);
            this.btnStart.TabIndex = 8;
            this.btnStart.Text = "진단검사 시작";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnDebug
            // 
            this.btnDebug.Location = new System.Drawing.Point(513, 326);
            this.btnDebug.Name = "btnDebug";
            this.btnDebug.Size = new System.Drawing.Size(75, 37);
            this.btnDebug.TabIndex = 9;
            this.btnDebug.Text = "Debug";
            this.btnDebug.UseVisualStyleBackColor = true;
            this.btnDebug.Click += new System.EventHandler(this.btnDebug_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.교과목검색ToolStripMenuItem,
            this.즐겨찾기ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(600, 28);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 교과목검색ToolStripMenuItem
            // 
            this.교과목검색ToolStripMenuItem.Name = "교과목검색ToolStripMenuItem";
            this.교과목검색ToolStripMenuItem.Size = new System.Drawing.Size(103, 24);
            this.교과목검색ToolStripMenuItem.Text = "교과목 검색";
            this.교과목검색ToolStripMenuItem.Click += new System.EventHandler(this.교과목검색ToolStripMenuItem_Click);
            // 
            // 즐겨찾기ToolStripMenuItem
            // 
            this.즐겨찾기ToolStripMenuItem.Name = "즐겨찾기ToolStripMenuItem";
            this.즐겨찾기ToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.즐겨찾기ToolStripMenuItem.Text = "즐겨찾기";
            this.즐겨찾기ToolStripMenuItem.Click += new System.EventHandler(this.즐겨찾기ToolStripMenuItem_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 375);
            this.Controls.Add(this.btnDebug);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormMain";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button btnDebug;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 교과목검색ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 즐겨찾기ToolStripMenuItem;
        private System.Windows.Forms.CheckBox cbTerm2;
        private System.Windows.Forms.CheckBox cbTerm1;
    }
}

