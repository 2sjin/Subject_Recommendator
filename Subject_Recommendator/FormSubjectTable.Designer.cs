namespace Subject_Recommendator {
    partial class FormSubjectTable {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SubjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Term = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LectureType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeamProject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDetail = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SubjectName,
            this.Year,
            this.Term,
            this.LectureType,
            this.TeamProject});
            this.dataGridView1.Location = new System.Drawing.Point(16, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(641, 294);
            this.dataGridView1.TabIndex = 0;
            // 
            // SubjectName
            // 
            this.SubjectName.HeaderText = "교과목명";
            this.SubjectName.MinimumWidth = 6;
            this.SubjectName.Name = "SubjectName";
            this.SubjectName.Width = 125;
            // 
            // Year
            // 
            this.Year.HeaderText = "학년";
            this.Year.MinimumWidth = 6;
            this.Year.Name = "Year";
            this.Year.Width = 125;
            // 
            // Term
            // 
            this.Term.HeaderText = "개설학기";
            this.Term.MinimumWidth = 6;
            this.Term.Name = "Term";
            this.Term.Width = 125;
            // 
            // LectureType
            // 
            this.LectureType.HeaderText = "강의유형";
            this.LectureType.MinimumWidth = 6;
            this.LectureType.Name = "LectureType";
            this.LectureType.Width = 125;
            // 
            // TeamProject
            // 
            this.TeamProject.HeaderText = "팀 과제";
            this.TeamProject.MinimumWidth = 6;
            this.TeamProject.Name = "TeamProject";
            this.TeamProject.Width = 125;
            // 
            // btnDetail
            // 
            this.btnDetail.Location = new System.Drawing.Point(436, 366);
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.Size = new System.Drawing.Size(127, 28);
            this.btnDetail.TabIndex = 1;
            this.btnDetail.Text = "상세 정보 보기";
            this.btnDetail.UseVisualStyleBackColor = true;
            this.btnDetail.Click += new System.EventHandler(this.btnDetail_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(582, 366);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 28);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "닫기";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel1
            // 
            this.panel1.AllowDrop = true;
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.btnDetail);
            this.panel1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.panel1.Location = new System.Drawing.Point(33, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(673, 406);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "테이블 캡션(상속용 Label)";
            // 
            // FormSubjectTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 464);
            this.Controls.Add(this.panel1);
            this.Name = "FormSubjectTable";
            this.Text = "FormSubjectTable(상속용 Form)";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubjectName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Year;
        private System.Windows.Forms.DataGridViewTextBoxColumn Term;
        private System.Windows.Forms.DataGridViewTextBoxColumn LectureType;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeamProject;
        private System.Windows.Forms.Button btnDetail;
        private System.Windows.Forms.Button btnClose;
        protected System.Windows.Forms.Panel panel1;
        protected System.Windows.Forms.Label label1;
    }
}