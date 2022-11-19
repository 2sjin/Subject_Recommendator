namespace Subject_Recommendator {
    partial class FormFavorite {
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.SetChildIndex(this.lvSubject, 0);
            this.panel1.Controls.SetChildIndex(this.label1, 0);
            this.panel1.Controls.SetChildIndex(this.btnAdd, 0);
            this.panel1.Controls.SetChildIndex(this.btnDelete, 0);
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(152, 15);
            this.label1.Text = "즐겨찾기 교과목 목록";
            // 
            // lvSubject
            // 
            this.lvSubject.VirtualListSize = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(16, 366);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(122, 32);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "추가(...)";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(155, 366);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(71, 32);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "삭제";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // FormFavorite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.ClientSize = new System.Drawing.Size(733, 460);
            this.Name = "FormFavorite";
            this.Text = "교과목 즐겨찾기";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
    }
}
