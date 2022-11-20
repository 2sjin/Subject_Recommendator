namespace Subject_Recommendator {
    partial class FormTest {
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
            this.btnAnswer5 = new System.Windows.Forms.Button();
            this.btnAnswer4 = new System.Windows.Forms.Button();
            this.btnAnswer3 = new System.Windows.Forms.Button();
            this.btnAnswer2 = new System.Windows.Forms.Button();
            this.btnAnswer1 = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtQuestion = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAnswer5
            // 
            this.btnAnswer5.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.btnAnswer5.Location = new System.Drawing.Point(40, 177);
            this.btnAnswer5.Name = "btnAnswer5";
            this.btnAnswer5.Size = new System.Drawing.Size(100, 100);
            this.btnAnswer5.TabIndex = 0;
            this.btnAnswer5.Text = "매우\r\n그렇다";
            this.btnAnswer5.UseVisualStyleBackColor = true;
            this.btnAnswer5.Click += new System.EventHandler(this.btnAnswer5_Click);
            // 
            // btnAnswer4
            // 
            this.btnAnswer4.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.btnAnswer4.Location = new System.Drawing.Point(170, 187);
            this.btnAnswer4.Name = "btnAnswer4";
            this.btnAnswer4.Size = new System.Drawing.Size(90, 90);
            this.btnAnswer4.TabIndex = 1;
            this.btnAnswer4.Text = "그렇다";
            this.btnAnswer4.UseVisualStyleBackColor = true;
            this.btnAnswer4.Click += new System.EventHandler(this.btnAnswer4_Click);
            // 
            // btnAnswer3
            // 
            this.btnAnswer3.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.btnAnswer3.Location = new System.Drawing.Point(290, 197);
            this.btnAnswer3.Name = "btnAnswer3";
            this.btnAnswer3.Size = new System.Drawing.Size(80, 80);
            this.btnAnswer3.TabIndex = 2;
            this.btnAnswer3.Text = "보통";
            this.btnAnswer3.UseVisualStyleBackColor = true;
            this.btnAnswer3.Click += new System.EventHandler(this.btnAnswer3_Click);
            // 
            // btnAnswer2
            // 
            this.btnAnswer2.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.btnAnswer2.Location = new System.Drawing.Point(400, 187);
            this.btnAnswer2.Name = "btnAnswer2";
            this.btnAnswer2.Size = new System.Drawing.Size(90, 90);
            this.btnAnswer2.TabIndex = 3;
            this.btnAnswer2.Text = "아니다";
            this.btnAnswer2.UseVisualStyleBackColor = true;
            this.btnAnswer2.Click += new System.EventHandler(this.btnAnswer2_Click);
            // 
            // btnAnswer1
            // 
            this.btnAnswer1.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.btnAnswer1.Location = new System.Drawing.Point(520, 177);
            this.btnAnswer1.Name = "btnAnswer1";
            this.btnAnswer1.Size = new System.Drawing.Size(100, 100);
            this.btnAnswer1.TabIndex = 4;
            this.btnAnswer1.Text = "매우\r\n아니다";
            this.btnAnswer1.UseVisualStyleBackColor = true;
            this.btnAnswer1.Click += new System.EventHandler(this.btnAnswer1_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(254, 329);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(156, 45);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "진단검사 중단";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtQuestion
            // 
            this.txtQuestion.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.txtQuestion.Location = new System.Drawing.Point(40, 38);
            this.txtQuestion.Multiline = true;
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.ReadOnly = true;
            this.txtQuestion.Size = new System.Drawing.Size(580, 98);
            this.txtQuestion.TabIndex = 8;
            this.txtQuestion.Text = "테스트 문항입니다.";
            // 
            // FormTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 405);
            this.Controls.Add(this.txtQuestion);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAnswer1);
            this.Controls.Add(this.btnAnswer2);
            this.Controls.Add(this.btnAnswer3);
            this.Controls.Add(this.btnAnswer4);
            this.Controls.Add(this.btnAnswer5);
            this.Name = "FormTest";
            this.RightToLeftLayout = true;
            this.Text = "진단검사";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAnswer5;
        private System.Windows.Forms.Button btnAnswer4;
        private System.Windows.Forms.Button btnAnswer3;
        private System.Windows.Forms.Button btnAnswer2;
        private System.Windows.Forms.Button btnAnswer1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtQuestion;
    }
}