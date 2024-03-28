namespace movie_reservation_system.UIL.MainScreenUI
{
    partial class FrmMainScreen
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
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.btnNowShowing = new System.Windows.Forms.Button();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.pnlChildForm = new System.Windows.Forms.Panel();
            this.btnComingSoon = new System.Windows.Forms.Button();
            this.pnlSidebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pnlSidebar.BackColor = System.Drawing.Color.Indigo;
            this.pnlSidebar.Controls.Add(this.btnComingSoon);
            this.pnlSidebar.Controls.Add(this.btnNowShowing);
            this.pnlSidebar.Controls.Add(this.btnLogIn);
            this.pnlSidebar.Controls.Add(this.btnQuit);
            this.pnlSidebar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlSidebar.ForeColor = System.Drawing.SystemColors.Control;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Margin = new System.Windows.Forms.Padding(0);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(200, 900);
            this.pnlSidebar.TabIndex = 0;
            // 
            // btnNowShowing
            // 
            this.btnNowShowing.AutoSize = true;
            this.btnNowShowing.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNowShowing.FlatAppearance.BorderSize = 0;
            this.btnNowShowing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNowShowing.Location = new System.Drawing.Point(0, 0);
            this.btnNowShowing.Margin = new System.Windows.Forms.Padding(0);
            this.btnNowShowing.Name = "btnNowShowing";
            this.btnNowShowing.Size = new System.Drawing.Size(200, 50);
            this.btnNowShowing.TabIndex = 0;
            this.btnNowShowing.Text = "NOW SHOWING";
            this.btnNowShowing.UseVisualStyleBackColor = true;
            // 
            // btnLogIn
            // 
            this.btnLogIn.AutoSize = true;
            this.btnLogIn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogIn.FlatAppearance.BorderSize = 0;
            this.btnLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogIn.Location = new System.Drawing.Point(0, 800);
            this.btnLogIn.Margin = new System.Windows.Forms.Padding(0);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(200, 50);
            this.btnLogIn.TabIndex = 2;
            this.btnLogIn.Text = "LOG IN";
            this.btnLogIn.UseVisualStyleBackColor = true;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.AutoSize = true;
            this.btnQuit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnQuit.FlatAppearance.BorderSize = 0;
            this.btnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuit.Location = new System.Drawing.Point(0, 850);
            this.btnQuit.Margin = new System.Windows.Forms.Padding(0);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(200, 50);
            this.btnQuit.TabIndex = 3;
            this.btnQuit.Text = "QUIT";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // pnlChildForm
            // 
            this.pnlChildForm.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlChildForm.Location = new System.Drawing.Point(200, 0);
            this.pnlChildForm.Margin = new System.Windows.Forms.Padding(0);
            this.pnlChildForm.Name = "pnlChildForm";
            this.pnlChildForm.Size = new System.Drawing.Size(1500, 900);
            this.pnlChildForm.TabIndex = 1;
            // 
            // btnComingSoon
            // 
            this.btnComingSoon.AutoSize = true;
            this.btnComingSoon.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnComingSoon.FlatAppearance.BorderSize = 0;
            this.btnComingSoon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComingSoon.Location = new System.Drawing.Point(0, 50);
            this.btnComingSoon.Margin = new System.Windows.Forms.Padding(0);
            this.btnComingSoon.Name = "btnComingSoon";
            this.btnComingSoon.Size = new System.Drawing.Size(200, 50);
            this.btnComingSoon.TabIndex = 1;
            this.btnComingSoon.Text = "COMING SOON";
            this.btnComingSoon.UseVisualStyleBackColor = true;
            // 
            // FrmMainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1700, 900);
            this.Controls.Add(this.pnlChildForm);
            this.Controls.Add(this.pnlSidebar);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmMainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Screen";
            this.pnlSidebar.ResumeLayout(false);
            this.pnlSidebar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Panel pnlChildForm;
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnNowShowing;
        private System.Windows.Forms.Button btnComingSoon;
    }
}