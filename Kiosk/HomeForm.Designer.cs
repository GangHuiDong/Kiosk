namespace Kiosk
{
    partial class HomeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_start = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_start
            // 
            this.button_start.Location = new System.Drawing.Point(332, 174);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(121, 56);
            this.button_start.TabIndex = 0;
            this.button_start.Text = "보관함 선택";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_start);
            this.Name = "HomeForm";
            this.Text = "Home";
            this.ResumeLayout(false);

        }

        #endregion

        private Button button_start;
    }
}