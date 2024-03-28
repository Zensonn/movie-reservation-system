using movie_reservation_system.UserControls;
using System.Windows.Forms;

namespace movie_reservation_system.UIL.UserUI
{
    partial class FrmLogIn
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
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblUnregisteredPhone = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblWrongPassword = new System.Windows.Forms.Label();
            this.chkShowPassword = new System.Windows.Forms.CheckBox();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.llbSignUp = new System.Windows.Forms.LinkLabel();
            this.txtPassword = new movie_reservation_system.UserControls.CustomTextBox();
            this.txtPhone = new movie_reservation_system.UserControls.CustomTextBox();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(12, 9);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(167, 46);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(16, 70);
            this.lblPhone.Margin = new System.Windows.Forms.Padding(0);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(59, 23);
            this.lblPhone.TabIndex = 1;
            this.lblPhone.Text = "Phone";
            this.lblPhone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUnregisteredPhone
            // 
            this.lblUnregisteredPhone.AutoSize = true;
            this.lblUnregisteredPhone.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnregisteredPhone.ForeColor = System.Drawing.Color.Red;
            this.lblUnregisteredPhone.Location = new System.Drawing.Point(16, 137);
            this.lblUnregisteredPhone.Margin = new System.Windows.Forms.Padding(0);
            this.lblUnregisteredPhone.Name = "lblUnregisteredPhone";
            this.lblUnregisteredPhone.Size = new System.Drawing.Size(135, 19);
            this.lblUnregisteredPhone.TabIndex = 3;
            this.lblUnregisteredPhone.Text = "Unregistered phone!";
            this.lblUnregisteredPhone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblUnregisteredPhone.Visible = false;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(16, 160);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(80, 23);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "Password";
            this.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWrongPassword
            // 
            this.lblWrongPassword.AutoSize = true;
            this.lblWrongPassword.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWrongPassword.ForeColor = System.Drawing.Color.Red;
            this.lblWrongPassword.Location = new System.Drawing.Point(16, 227);
            this.lblWrongPassword.Margin = new System.Windows.Forms.Padding(0);
            this.lblWrongPassword.Name = "lblWrongPassword";
            this.lblWrongPassword.Size = new System.Drawing.Size(117, 19);
            this.lblWrongPassword.TabIndex = 6;
            this.lblWrongPassword.Text = "Wrong password!";
            this.lblWrongPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblWrongPassword.Visible = false;
            // 
            // chkShowPassword
            // 
            this.chkShowPassword.AutoSize = true;
            this.chkShowPassword.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkShowPassword.Location = new System.Drawing.Point(152, 226);
            this.chkShowPassword.Margin = new System.Windows.Forms.Padding(0);
            this.chkShowPassword.Name = "chkShowPassword";
            this.chkShowPassword.Size = new System.Drawing.Size(126, 23);
            this.chkShowPassword.TabIndex = 7;
            this.chkShowPassword.Text = "Show password";
            this.chkShowPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkShowPassword.UseVisualStyleBackColor = true;
            this.chkShowPassword.CheckedChanged += new System.EventHandler(this.chkShowPassword_CheckedChanged);
            // 
            // btnLogIn
            // 
            this.btnLogIn.AutoSize = true;
            this.btnLogIn.Location = new System.Drawing.Point(62, 270);
            this.btnLogIn.Margin = new System.Windows.Forms.Padding(0);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(80, 35);
            this.btnLogIn.TabIndex = 8;
            this.btnLogIn.Text = "LOG IN";
            this.btnLogIn.UseVisualStyleBackColor = true;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.AutoSize = true;
            this.btnQuit.Location = new System.Drawing.Point(148, 270);
            this.btnQuit.Margin = new System.Windows.Forms.Padding(0);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(80, 35);
            this.btnQuit.TabIndex = 9;
            this.btnQuit.Text = "QUIT";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // llbSignUp
            // 
            this.llbSignUp.AutoSize = true;
            this.llbSignUp.LinkColor = System.Drawing.Color.Black;
            this.llbSignUp.Location = new System.Drawing.Point(111, 308);
            this.llbSignUp.Margin = new System.Windows.Forms.Padding(0);
            this.llbSignUp.Name = "llbSignUp";
            this.llbSignUp.Size = new System.Drawing.Size(68, 23);
            this.llbSignUp.TabIndex = 10;
            this.llbSignUp.TabStop = true;
            this.llbSignUp.Text = "Sign up";
            this.llbSignUp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.llbSignUp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbSignUp_LinkClicked);
            // 
            // txtPassword
            // 
            this.txtPassword.AutoSize = true;
            this.txtPassword.BackColor = System.Drawing.SystemColors.Control;
            this.txtPassword.BorderColor = System.Drawing.Color.Black;
            this.txtPassword.BorderFocusedColor = System.Drawing.Color.MediumOrchid;
            this.txtPassword.BorderWidth = 0;
            this.txtPassword.CustomText = "";
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.IsFocused = false;
            this.txtPassword.Location = new System.Drawing.Point(20, 186);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(0);
            this.txtPassword.Multiline = false;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Padding = new System.Windows.Forms.Padding(7);
            this.txtPassword.PasswordChar = true;
            this.txtPassword.Size = new System.Drawing.Size(250, 38);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.Underline = true;
            // 
            // txtPhone
            // 
            this.txtPhone.AutoSize = true;
            this.txtPhone.BackColor = System.Drawing.SystemColors.Control;
            this.txtPhone.BorderColor = System.Drawing.Color.Black;
            this.txtPhone.BorderFocusedColor = System.Drawing.Color.MediumOrchid;
            this.txtPhone.BorderWidth = 0;
            this.txtPhone.CustomText = "";
            this.txtPhone.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.IsFocused = false;
            this.txtPhone.Location = new System.Drawing.Point(20, 96);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(0);
            this.txtPhone.Multiline = false;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Padding = new System.Windows.Forms.Padding(7);
            this.txtPhone.PasswordChar = false;
            this.txtPhone.Size = new System.Drawing.Size(250, 38);
            this.txtPhone.TabIndex = 2;
            this.txtPhone.Underline = true;
            // 
            // FrmLogIn
            // 
            this.AcceptButton = this.btnLogIn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(290, 340);
            this.Controls.Add(this.llbSignUp);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnLogIn);
            this.Controls.Add(this.chkShowPassword);
            this.Controls.Add(this.lblWrongPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUnregisteredPhone);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblWelcome);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmLogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log In";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblWelcome;
        private Label lblPhone;
        private Label lblUnregisteredPhone;
        private Label lblPassword;
        private Label lblWrongPassword;
        private CustomTextBox txtPhone;
        private CustomTextBox txtPassword;
        private CheckBox chkShowPassword;
        private Button btnLogIn;
        private Button btnQuit;
        private LinkLabel llbSignUp;
    }
}