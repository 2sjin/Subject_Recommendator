namespace Subject_Recommendator {
    partial class FormSubjectListView {
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
            this.btnDetail = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lvSubject = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDetail
            // 
            this.btnDetail.Location = new System.Drawing.Point(436, 366);
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.Size = new System.Drawing.Size(127, 32);
            this.btnDetail.TabIndex = 198;
            this.btnDetail.Text = "상세 정보 보기";
            this.btnDetail.UseVisualStyleBackColor = true;
            this.btnDetail.Click += new System.EventHandler(this.btnDetail_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(582, 366);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 32);
            this.btnClose.TabIndex = 199;
            this.btnClose.Text = "닫기";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel1
            // 
            this.panel1.AllowDrop = true;
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.lvSubject);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.btnDetail);
            this.panel1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.panel1.Location = new System.Drawing.Point(33, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(673, 406);
            this.panel1.TabIndex = 3;
            // 
            // lvSubject
            // 
            this.lvSubject.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lvSubject.FullRowSelect = true;
            this.lvSubject.HideSelection = false;
            this.lvSubject.Location = new System.Drawing.Point(16, 54);
            this.lvSubject.MultiSelect = false;
            this.lvSubject.Name = "lvSubject";
            this.lvSubject.Size = new System.Drawing.Size(641, 213);
            this.lvSubject.TabIndex = 197;
            this.lvSubject.UseCompatibleStateImageBehavior = false;
            this.lvSubject.View = System.Windows.Forms.View.Details;
            this.lvSubject.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvSubject_MouseDoubleClick);
            // 
            // ID
            // 
            this.ID.Text = "교과목번호";
            this.ID.Width = 80;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "교과목명";
            this.columnHeader1.Width = 160;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "학년";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 50;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "개설학기";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 70;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "강의유형";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 80;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "팀 과제";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 80;
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
            // FormSubjectListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 464);
            this.Controls.Add(this.panel1);
            this.Name = "FormSubjectListView";
            this.Text = "FormSubjectTable(상속용 Form)";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnDetail;
        private System.Windows.Forms.Button btnClose;
        protected System.Windows.Forms.Panel panel1;
        protected System.Windows.Forms.Label label1;
        protected System.Windows.Forms.ListView lvSubject;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}