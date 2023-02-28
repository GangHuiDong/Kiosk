namespace Kiosk
{
    partial class ProgressForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel_down = new System.Windows.Forms.Panel();
            this.button_home = new System.Windows.Forms.Button();
            this.button_previous = new System.Windows.Forms.Button();
            this.button_next = new System.Windows.Forms.Button();
            this.panel_main = new System.Windows.Forms.Panel();
            this.label_timer = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel_down.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel_down, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel_main, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.88889F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.11111F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel_down
            // 
            this.panel_down.Controls.Add(this.label_timer);
            this.panel_down.Controls.Add(this.button_home);
            this.panel_down.Controls.Add(this.button_previous);
            this.panel_down.Controls.Add(this.button_next);
            this.panel_down.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_down.Location = new System.Drawing.Point(3, 385);
            this.panel_down.Name = "panel_down";
            this.panel_down.Size = new System.Drawing.Size(794, 62);
            this.panel_down.TabIndex = 0;
            // 
            // button_home
            // 
            this.button_home.Location = new System.Drawing.Point(22, 21);
            this.button_home.Name = "button_home";
            this.button_home.Size = new System.Drawing.Size(75, 23);
            this.button_home.TabIndex = 2;
            this.button_home.Text = "홈으로";
            this.button_home.UseVisualStyleBackColor = true;
            this.button_home.Click += new System.EventHandler(this.button_home_Click);
            // 
            // button_previous
            // 
            this.button_previous.Location = new System.Drawing.Point(563, 21);
            this.button_previous.Name = "button_previous";
            this.button_previous.Size = new System.Drawing.Size(75, 23);
            this.button_previous.TabIndex = 1;
            this.button_previous.Text = "이전";
            this.button_previous.UseVisualStyleBackColor = true;
            this.button_previous.Click += new System.EventHandler(this.button_previous_Click);
            // 
            // button_next
            // 
            this.button_next.Location = new System.Drawing.Point(687, 21);
            this.button_next.Name = "button_next";
            this.button_next.Size = new System.Drawing.Size(75, 23);
            this.button_next.TabIndex = 0;
            this.button_next.Text = "다음";
            this.button_next.UseVisualStyleBackColor = true;
            this.button_next.Click += new System.EventHandler(this.button_next_Click);
            // 
            // panel_main
            // 
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.Location = new System.Drawing.Point(3, 3);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(794, 376);
            this.panel_main.TabIndex = 1;
            // 
            // label_timer
            // 
            this.label_timer.AutoSize = true;
            this.label_timer.Location = new System.Drawing.Point(369, 24);
            this.label_timer.Name = "label_timer";
            this.label_timer.Size = new System.Drawing.Size(39, 15);
            this.label_timer.TabIndex = 3;
            this.label_timer.Text = "label1";
            // 
            // ProgressForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ProgressForm";
            this.Text = "ProgressForm";
            this.Load += new System.EventHandler(this.ProgressForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel_down.ResumeLayout(false);
            this.panel_down.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel_down;
        private Button button_home;
        private Button button_previous;
        private Button button_next;
        private Panel panel_main;
        private Label label_timer;
    }
}