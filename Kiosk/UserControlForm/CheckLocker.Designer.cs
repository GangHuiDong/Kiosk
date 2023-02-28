namespace Kiosk.UserControlForm
{
    partial class CheckLocker
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_information = new System.Windows.Forms.Label();
            this.label_price = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_information
            // 
            this.label_information.AutoSize = true;
            this.label_information.Location = new System.Drawing.Point(289, 138);
            this.label_information.Name = "label_information";
            this.label_information.Size = new System.Drawing.Size(39, 15);
            this.label_information.TabIndex = 0;
            this.label_information.Text = "label1";
            // 
            // label_price
            // 
            this.label_price.AutoSize = true;
            this.label_price.Location = new System.Drawing.Point(289, 178);
            this.label_price.Name = "label_price";
            this.label_price.Size = new System.Drawing.Size(68, 15);
            this.label_price.TabIndex = 1;
            this.label_price.Text = "100,000 원";
            // 
            // CheckLocker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label_price);
            this.Controls.Add(this.label_information);
            this.Name = "CheckLocker";
            this.Size = new System.Drawing.Size(784, 448);
            this.Load += new System.EventHandler(this.CheckLocker_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label_information;
        private Label label_price;
    }
}
