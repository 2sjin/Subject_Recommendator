namespace Subject_Recommendator {
    partial class FormDetail {
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtOutline = new System.Windows.Forms.TextBox();
            this.labelSubjectName = new System.Windows.Forms.Label();
            this.labelYear = new System.Windows.Forms.Label();
            this.labelTerm = new System.Windows.Forms.Label();
            this.labelLectureType = new System.Windows.Forms.Label();
            this.labelTeamProject = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "교과목명:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "학년:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(270, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "개설학기:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "강의유형:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(270, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "팀 과제: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(57, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "교과목 개요";
            // 
            // txtOutline
            // 
            this.txtOutline.Location = new System.Drawing.Point(60, 245);
            this.txtOutline.Multiline = true;
            this.txtOutline.Name = "txtOutline";
            this.txtOutline.ReadOnly = true;
            this.txtOutline.Size = new System.Drawing.Size(497, 152);
            this.txtOutline.TabIndex = 6;
            // 
            // labelSubjectName
            // 
            this.labelSubjectName.AutoSize = true;
            this.labelSubjectName.Location = new System.Drawing.Point(145, 55);
            this.labelSubjectName.Name = "labelSubjectName";
            this.labelSubjectName.Size = new System.Drawing.Size(122, 15);
            this.labelSubjectName.TabIndex = 7;
            this.labelSubjectName.Text = "labelSubjectName";
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.Location = new System.Drawing.Point(145, 110);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(65, 15);
            this.labelYear.TabIndex = 8;
            this.labelYear.Text = "labelYear";
            // 
            // labelTerm
            // 
            this.labelTerm.AutoSize = true;
            this.labelTerm.Location = new System.Drawing.Point(368, 110);
            this.labelTerm.Name = "labelTerm";
            this.labelTerm.Size = new System.Drawing.Size(68, 15);
            this.labelTerm.TabIndex = 8;
            this.labelTerm.Text = "labelTerm";
            // 
            // labelLectureType
            // 
            this.labelLectureType.AutoSize = true;
            this.labelLectureType.Location = new System.Drawing.Point(145, 164);
            this.labelLectureType.Name = "labelLectureType";
            this.labelLectureType.Size = new System.Drawing.Size(117, 15);
            this.labelLectureType.TabIndex = 9;
            this.labelLectureType.Text = "labelLectureType";
            // 
            // labelTeamProject
            // 
            this.labelTeamProject.AutoSize = true;
            this.labelTeamProject.Location = new System.Drawing.Point(368, 164);
            this.labelTeamProject.Name = "labelTeamProject";
            this.labelTeamProject.Size = new System.Drawing.Size(118, 15);
            this.labelTeamProject.TabIndex = 10;
            this.labelTeamProject.Text = "labelTeamProject";
            // 
            // FormDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 450);
            this.Controls.Add(this.labelTeamProject);
            this.Controls.Add(this.labelLectureType);
            this.Controls.Add(this.labelTerm);
            this.Controls.Add(this.labelYear);
            this.Controls.Add(this.labelSubjectName);
            this.Controls.Add(this.txtOutline);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "FormDetail";
            this.Text = "교과목 상세 정보";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtOutline;
        private System.Windows.Forms.Label labelSubjectName;
        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.Label labelTerm;
        private System.Windows.Forms.Label labelLectureType;
        private System.Windows.Forms.Label labelTeamProject;
    }
}