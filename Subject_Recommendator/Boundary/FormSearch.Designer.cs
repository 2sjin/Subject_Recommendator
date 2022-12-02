namespace Subject_Recommendator {
    partial class FormSearch {
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
            this.btnAddFavorite = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cbTerm2 = new System.Windows.Forms.CheckBox();
            this.cbTerm1 = new System.Windows.Forms.CheckBox();
            this.cbTeamUnknown = new System.Windows.Forms.CheckBox();
            this.cbTeamNo = new System.Windows.Forms.CheckBox();
            this.cbTeamYes = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbYear2 = new System.Windows.Forms.CheckBox();
            this.cbType2 = new System.Windows.Forms.CheckBox();
            this.cbType1 = new System.Windows.Forms.CheckBox();
            this.cbYear3 = new System.Windows.Forms.CheckBox();
            this.cbYear4 = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAddFavorite);
            this.panel1.Location = new System.Drawing.Point(29, 323);
            this.panel1.TabIndex = 15;
            this.panel1.Controls.SetChildIndex(this.lvSubject, 0);
            this.panel1.Controls.SetChildIndex(this.label1, 0);
            this.panel1.Controls.SetChildIndex(this.btnAddFavorite, 0);
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(152, 15);
            this.label1.Text = "전공선택 교과목 목록";
            // 
            // lvSubject
            // 
            this.lvSubject.TabIndex = 13;
            // 
            // btnAddFavorite
            // 
            this.btnAddFavorite.Location = new System.Drawing.Point(284, 366);
            this.btnAddFavorite.Name = "btnAddFavorite";
            this.btnAddFavorite.Size = new System.Drawing.Size(136, 32);
            this.btnAddFavorite.TabIndex = 14;
            this.btnAddFavorite.Text = "즐겨찾기 추가";
            this.btnAddFavorite.UseVisualStyleBackColor = true;
            this.btnAddFavorite.Click += new System.EventHandler(this.btnAddFavorite_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Location = new System.Drawing.Point(45, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(641, 86);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "교과목 검색";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(544, 38);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(77, 25);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "검색";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.SystemColors.Window;
            this.txtSearch.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtSearch.Location = new System.Drawing.Point(164, 38);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(362, 25);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.Text = "(검색어를 입력하세요)";
            this.txtSearch.Enter += new System.EventHandler(this.txtSearch_Enter);
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            this.txtSearch.Leave += new System.EventHandler(this.txtSearch_Leave);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "교과목명",
            "교과목 개요"});
            this.comboBox1.Location = new System.Drawing.Point(28, 38);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel1);
            this.groupBox2.Location = new System.Drawing.Point(45, 132);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(641, 173);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "교과목 필터";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.cbTerm2, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.cbTerm1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.cbTeamUnknown, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.cbTeamNo, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.cbTeamYes, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.cbYear2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.cbType2, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.cbType1, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.cbYear3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.cbYear4, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(28, 40);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(593, 125);
            this.tableLayoutPanel1.TabIndex = 14;
            // 
            // cbTerm2
            // 
            this.cbTerm2.AutoSize = true;
            this.cbTerm2.Checked = true;
            this.cbTerm2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbTerm2.Location = new System.Drawing.Point(299, 34);
            this.cbTerm2.Name = "cbTerm2";
            this.cbTerm2.Size = new System.Drawing.Size(67, 19);
            this.cbTerm2.TabIndex = 7;
            this.cbTerm2.Text = "2학기";
            this.cbTerm2.UseVisualStyleBackColor = true;
            // 
            // cbTerm1
            // 
            this.cbTerm1.AutoSize = true;
            this.cbTerm1.Checked = true;
            this.cbTerm1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbTerm1.Location = new System.Drawing.Point(151, 34);
            this.cbTerm1.Name = "cbTerm1";
            this.cbTerm1.Size = new System.Drawing.Size(67, 19);
            this.cbTerm1.TabIndex = 6;
            this.cbTerm1.Text = "1학기";
            this.cbTerm1.UseVisualStyleBackColor = true;
            // 
            // cbTeamUnknown
            // 
            this.cbTeamUnknown.AutoSize = true;
            this.cbTeamUnknown.Checked = true;
            this.cbTeamUnknown.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbTeamUnknown.Location = new System.Drawing.Point(447, 96);
            this.cbTeamUnknown.Name = "cbTeamUnknown";
            this.cbTeamUnknown.Size = new System.Drawing.Size(89, 19);
            this.cbTeamUnknown.TabIndex = 12;
            this.cbTeamUnknown.Text = "불확실함";
            this.cbTeamUnknown.UseVisualStyleBackColor = true;
            // 
            // cbTeamNo
            // 
            this.cbTeamNo.AutoSize = true;
            this.cbTeamNo.Checked = true;
            this.cbTeamNo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbTeamNo.Location = new System.Drawing.Point(299, 96);
            this.cbTeamNo.Name = "cbTeamNo";
            this.cbTeamNo.Size = new System.Drawing.Size(59, 19);
            this.cbTeamNo.TabIndex = 11;
            this.cbTeamNo.Text = "없음";
            this.cbTeamNo.UseVisualStyleBackColor = true;
            // 
            // cbTeamYes
            // 
            this.cbTeamYes.AutoSize = true;
            this.cbTeamYes.Checked = true;
            this.cbTeamYes.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbTeamYes.Location = new System.Drawing.Point(151, 96);
            this.cbTeamYes.Name = "cbTeamYes";
            this.cbTeamYes.Size = new System.Drawing.Size(59, 19);
            this.cbTeamYes.TabIndex = 10;
            this.cbTeamYes.Text = "있음";
            this.cbTeamYes.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "학년";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "개설학기";
            // 
            // cbYear2
            // 
            this.cbYear2.AutoSize = true;
            this.cbYear2.Checked = true;
            this.cbYear2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbYear2.Location = new System.Drawing.Point(151, 3);
            this.cbYear2.Name = "cbYear2";
            this.cbYear2.Size = new System.Drawing.Size(67, 19);
            this.cbYear2.TabIndex = 3;
            this.cbYear2.Text = "2학년";
            this.cbYear2.UseVisualStyleBackColor = true;
            // 
            // cbType2
            // 
            this.cbType2.AutoSize = true;
            this.cbType2.Checked = true;
            this.cbType2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbType2.Location = new System.Drawing.Point(299, 65);
            this.cbType2.Name = "cbType2";
            this.cbType2.Size = new System.Drawing.Size(95, 19);
            this.cbType2.TabIndex = 9;
            this.cbType2.Text = "이론/실습";
            this.cbType2.UseVisualStyleBackColor = true;
            // 
            // cbType1
            // 
            this.cbType1.AutoSize = true;
            this.cbType1.Checked = true;
            this.cbType1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbType1.Location = new System.Drawing.Point(151, 65);
            this.cbType1.Name = "cbType1";
            this.cbType1.Size = new System.Drawing.Size(59, 19);
            this.cbType1.TabIndex = 8;
            this.cbType1.Text = "이론";
            this.cbType1.UseVisualStyleBackColor = true;
            // 
            // cbYear3
            // 
            this.cbYear3.AutoSize = true;
            this.cbYear3.Checked = true;
            this.cbYear3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbYear3.Location = new System.Drawing.Point(299, 3);
            this.cbYear3.Name = "cbYear3";
            this.cbYear3.Size = new System.Drawing.Size(67, 19);
            this.cbYear3.TabIndex = 4;
            this.cbYear3.Text = "3학년";
            this.cbYear3.UseVisualStyleBackColor = true;
            // 
            // cbYear4
            // 
            this.cbYear4.AutoSize = true;
            this.cbYear4.Checked = true;
            this.cbYear4.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbYear4.Location = new System.Drawing.Point(447, 3);
            this.cbYear4.Name = "cbYear4";
            this.cbYear4.Size = new System.Drawing.Size(67, 19);
            this.cbYear4.TabIndex = 5;
            this.cbYear4.Text = "4학년";
            this.cbYear4.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "강의유형";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "팀 과제";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FormSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.ClientSize = new System.Drawing.Size(733, 753);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormSearch";
            this.Text = "교과목 검색";
            this.Load += new System.EventHandler(this.FormSearch_Load);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddFavorite;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbYear4;
        private System.Windows.Forms.CheckBox cbYear3;
        private System.Windows.Forms.CheckBox cbYear2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.CheckBox cbTeamUnknown;
        private System.Windows.Forms.CheckBox cbTeamNo;
        private System.Windows.Forms.CheckBox cbTeamYes;
        private System.Windows.Forms.CheckBox cbType1;
        private System.Windows.Forms.CheckBox cbType2;
        private System.Windows.Forms.CheckBox cbTerm2;
        private System.Windows.Forms.CheckBox cbTerm1;
        private System.Windows.Forms.Button btnSearch;
    }
}
