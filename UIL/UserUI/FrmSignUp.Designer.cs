namespace movie_reservation_system.UIL.UserUI
{
    partial class FrmSignUp
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
            this.lblGetStarted = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblPhoneIsRegistered = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.lblPasswordDoesNotMatch = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblEmailIsRegistered = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.txtPhone = new movie_reservation_system.UserControls.CustomTextBox();
            this.txtPassword = new movie_reservation_system.UserControls.CustomTextBox();
            this.txtConfirmPassword = new movie_reservation_system.UserControls.CustomTextBox();
            this.txtFirstName = new movie_reservation_system.UserControls.CustomTextBox();
            this.txtLastName = new movie_reservation_system.UserControls.CustomTextBox();
            this.txtEmail = new movie_reservation_system.UserControls.CustomTextBox();
            this.chkShowPassword = new System.Windows.Forms.CheckBox();
            this.cmbCity = new System.Windows.Forms.ComboBox();
            this.chkMale = new System.Windows.Forms.CheckBox();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.llbLogIn = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lblGetStarted
            // 
            this.lblGetStarted.AutoSize = true;
            this.lblGetStarted.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGetStarted.Location = new System.Drawing.Point(12, 9);
            this.lblGetStarted.Margin = new System.Windows.Forms.Padding(0);
            this.lblGetStarted.Name = "lblGetStarted";
            this.lblGetStarted.Size = new System.Drawing.Size(200, 46);
            this.lblGetStarted.TabIndex = 0;
            this.lblGetStarted.Text = "Get Started";
            this.lblGetStarted.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // lblPhoneIsRegistered
            // 
            this.lblPhoneIsRegistered.AutoSize = true;
            this.lblPhoneIsRegistered.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneIsRegistered.ForeColor = System.Drawing.Color.Red;
            this.lblPhoneIsRegistered.Location = new System.Drawing.Point(16, 137);
            this.lblPhoneIsRegistered.Margin = new System.Windows.Forms.Padding(0);
            this.lblPhoneIsRegistered.Name = "lblPhoneIsRegistered";
            this.lblPhoneIsRegistered.Size = new System.Drawing.Size(130, 19);
            this.lblPhoneIsRegistered.TabIndex = 3;
            this.lblPhoneIsRegistered.Text = "Phone is registered!";
            this.lblPhoneIsRegistered.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPhoneIsRegistered.Visible = false;
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
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.Location = new System.Drawing.Point(16, 250);
            this.lblConfirmPassword.Margin = new System.Windows.Forms.Padding(0);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(147, 23);
            this.lblConfirmPassword.TabIndex = 7;
            this.lblConfirmPassword.Text = "Confirm password";
            this.lblConfirmPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPasswordDoesNotMatch
            // 
            this.lblPasswordDoesNotMatch.AutoSize = true;
            this.lblPasswordDoesNotMatch.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordDoesNotMatch.ForeColor = System.Drawing.Color.Red;
            this.lblPasswordDoesNotMatch.Location = new System.Drawing.Point(16, 317);
            this.lblPasswordDoesNotMatch.Margin = new System.Windows.Forms.Padding(0);
            this.lblPasswordDoesNotMatch.Name = "lblPasswordDoesNotMatch";
            this.lblPasswordDoesNotMatch.Size = new System.Drawing.Size(171, 19);
            this.lblPasswordDoesNotMatch.TabIndex = 9;
            this.lblPasswordDoesNotMatch.Text = "Password does not match!";
            this.lblPasswordDoesNotMatch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPasswordDoesNotMatch.Visible = false;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(16, 340);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(89, 23);
            this.lblFirstName.TabIndex = 10;
            this.lblFirstName.Text = "First name";
            this.lblFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(186, 340);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(88, 23);
            this.lblLastName.TabIndex = 12;
            this.lblLastName.Text = "Last name";
            this.lblLastName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(16, 430);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(51, 23);
            this.lblEmail.TabIndex = 14;
            this.lblEmail.Text = "Email";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEmailIsRegistered
            // 
            this.lblEmailIsRegistered.AutoSize = true;
            this.lblEmailIsRegistered.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailIsRegistered.ForeColor = System.Drawing.Color.Red;
            this.lblEmailIsRegistered.Location = new System.Drawing.Point(16, 497);
            this.lblEmailIsRegistered.Margin = new System.Windows.Forms.Padding(0);
            this.lblEmailIsRegistered.Name = "lblEmailIsRegistered";
            this.lblEmailIsRegistered.Size = new System.Drawing.Size(123, 19);
            this.lblEmailIsRegistered.TabIndex = 22;
            this.lblEmailIsRegistered.Text = "Email is registered!";
            this.lblEmailIsRegistered.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblEmailIsRegistered.Visible = false;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(16, 520);
            this.lblCity.Margin = new System.Windows.Forms.Padding(0);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(39, 23);
            this.lblCity.TabIndex = 16;
            this.lblCity.Text = "City";
            this.lblCity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.AutoSize = true;
            this.txtConfirmPassword.BackColor = System.Drawing.SystemColors.Control;
            this.txtConfirmPassword.BorderColor = System.Drawing.Color.Black;
            this.txtConfirmPassword.BorderFocusedColor = System.Drawing.Color.MediumOrchid;
            this.txtConfirmPassword.BorderWidth = 0;
            this.txtConfirmPassword.CustomText = "";
            this.txtConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmPassword.IsFocused = false;
            this.txtConfirmPassword.Location = new System.Drawing.Point(20, 276);
            this.txtConfirmPassword.Margin = new System.Windows.Forms.Padding(0);
            this.txtConfirmPassword.Multiline = false;
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Padding = new System.Windows.Forms.Padding(7);
            this.txtConfirmPassword.PasswordChar = true;
            this.txtConfirmPassword.Size = new System.Drawing.Size(250, 38);
            this.txtConfirmPassword.TabIndex = 8;
            this.txtConfirmPassword.Underline = true;
            // 
            // txtFirstName
            // 
            this.txtFirstName.AutoSize = true;
            this.txtFirstName.BackColor = System.Drawing.SystemColors.Control;
            this.txtFirstName.BorderColor = System.Drawing.Color.Black;
            this.txtFirstName.BorderFocusedColor = System.Drawing.Color.MediumOrchid;
            this.txtFirstName.BorderWidth = 0;
            this.txtFirstName.CustomText = "";
            this.txtFirstName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.IsFocused = false;
            this.txtFirstName.Location = new System.Drawing.Point(20, 366);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(0);
            this.txtFirstName.Multiline = false;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Padding = new System.Windows.Forms.Padding(7);
            this.txtFirstName.PasswordChar = false;
            this.txtFirstName.Size = new System.Drawing.Size(124, 38);
            this.txtFirstName.TabIndex = 11;
            this.txtFirstName.Underline = true;
            // 
            // txtLastName
            // 
            this.txtLastName.AutoSize = true;
            this.txtLastName.BackColor = System.Drawing.SystemColors.Control;
            this.txtLastName.BorderColor = System.Drawing.Color.Black;
            this.txtLastName.BorderFocusedColor = System.Drawing.Color.MediumOrchid;
            this.txtLastName.BorderWidth = 0;
            this.txtLastName.CustomText = "";
            this.txtLastName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.IsFocused = false;
            this.txtLastName.Location = new System.Drawing.Point(150, 366);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(0);
            this.txtLastName.Multiline = false;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Padding = new System.Windows.Forms.Padding(7);
            this.txtLastName.PasswordChar = false;
            this.txtLastName.Size = new System.Drawing.Size(124, 38);
            this.txtLastName.TabIndex = 13;
            this.txtLastName.Underline = true;
            // 
            // txtEmail
            // 
            this.txtEmail.AutoSize = true;
            this.txtEmail.BackColor = System.Drawing.SystemColors.Control;
            this.txtEmail.BorderColor = System.Drawing.Color.Black;
            this.txtEmail.BorderFocusedColor = System.Drawing.Color.MediumOrchid;
            this.txtEmail.BorderWidth = 0;
            this.txtEmail.CustomText = "";
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.IsFocused = false;
            this.txtEmail.Location = new System.Drawing.Point(20, 456);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(0);
            this.txtEmail.Multiline = false;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Padding = new System.Windows.Forms.Padding(7);
            this.txtEmail.PasswordChar = false;
            this.txtEmail.Size = new System.Drawing.Size(250, 38);
            this.txtEmail.TabIndex = 15;
            this.txtEmail.Underline = true;
            // 
            // chkShowPassword
            // 
            this.chkShowPassword.AutoSize = true;
            this.chkShowPassword.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkShowPassword.Location = new System.Drawing.Point(152, 226);
            this.chkShowPassword.Margin = new System.Windows.Forms.Padding(0);
            this.chkShowPassword.Name = "chkShowPassword";
            this.chkShowPassword.Size = new System.Drawing.Size(126, 23);
            this.chkShowPassword.TabIndex = 6;
            this.chkShowPassword.Text = "Show password";
            this.chkShowPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkShowPassword.UseVisualStyleBackColor = true;
            this.chkShowPassword.CheckedChanged += new System.EventHandler(this.chkShowPassword_CheckedChanged);
            // 
            // cmbCity
            // 
            this.cmbCity.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbCity.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCity.FormattingEnabled = true;
            this.cmbCity.Items.AddRange(new object[] {
            "An Giang",
            "Bà Rịa - Vũng Tàu",
            "Bắc Giang",
            "Bắc Kạn",
            "Bạc Liêu",
            "Bắc Ninh",
            "Bến Tre",
            "Bình Định",
            "Bình Dương",
            "Bình Phước",
            "Bình Thuận",
            "Cà Mau",
            "Cần Thơ",
            "Cao Bằng",
            "Đà Nẵng",
            "Đắk Lắk",
            "Đắk Nông",
            "Điện Biên",
            "Đồng Nai",
            "Đồng Tháp",
            "Gia Lai",
            "Hà Giang",
            "Hà Nam",
            "Hà Nội",
            "Hà Tĩnh",
            "Hải Dương",
            "Hải Phòng",
            "Hậu Giang",
            "Hồ Chí Minh",
            "Hòa Bình",
            "Hưng Yên",
            "Khánh Hòa",
            "Kiên Giang",
            "Kon Tum",
            "Lai Châu",
            "Lâm Đồng",
            "Lạng Sơn",
            "Lào Cai",
            "Long An",
            "Nam Định",
            "Nghệ An",
            "Ninh Bình",
            "Ninh Thuận",
            "Phú Thọ",
            "Phú Yên",
            "Quảng Bình",
            "Quảng Nam",
            "Quảng Ngãi",
            "Quảng Ninh",
            "Quảng Trị",
            "Sóc Trăng",
            "Sơn La",
            "Tây Ninh",
            "Thái Bình",
            "Thái Nguyên",
            "Thanh Hóa",
            "Thừa Thiên Huế",
            "Tiền Giang",
            "Trà Vinh",
            "Tuyên Quang",
            "Vĩnh Long",
            "Vĩnh Phúc",
            "Yên Bái"});
            this.cmbCity.Location = new System.Drawing.Point(20, 546);
            this.cmbCity.Margin = new System.Windows.Forms.Padding(0);
            this.cmbCity.Name = "cmbCity";
            this.cmbCity.Size = new System.Drawing.Size(180, 31);
            this.cmbCity.Sorted = true;
            this.cmbCity.TabIndex = 17;
            // 
            // chkMale
            // 
            this.chkMale.AutoSize = true;
            this.chkMale.Location = new System.Drawing.Point(210, 549);
            this.chkMale.Margin = new System.Windows.Forms.Padding(0);
            this.chkMale.Name = "chkMale";
            this.chkMale.Size = new System.Drawing.Size(69, 27);
            this.chkMale.TabIndex = 18;
            this.chkMale.Text = "Male";
            this.chkMale.UseVisualStyleBackColor = true;
            // 
            // btnSignUp
            // 
            this.btnSignUp.AutoSize = true;
            this.btnSignUp.Location = new System.Drawing.Point(52, 600);
            this.btnSignUp.Margin = new System.Windows.Forms.Padding(0);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(90, 35);
            this.btnSignUp.TabIndex = 19;
            this.btnSignUp.Text = "SIGN UP";
            this.btnSignUp.UseVisualStyleBackColor = true;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.AutoSize = true;
            this.btnQuit.Location = new System.Drawing.Point(148, 600);
            this.btnQuit.Margin = new System.Windows.Forms.Padding(0);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(90, 35);
            this.btnQuit.TabIndex = 20;
            this.btnQuit.Text = "QUIT";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // llbLogIn
            // 
            this.llbLogIn.AutoSize = true;
            this.llbLogIn.LinkColor = System.Drawing.Color.Black;
            this.llbLogIn.Location = new System.Drawing.Point(116, 638);
            this.llbLogIn.Margin = new System.Windows.Forms.Padding(0);
            this.llbLogIn.Name = "llbLogIn";
            this.llbLogIn.Size = new System.Drawing.Size(57, 23);
            this.llbLogIn.TabIndex = 21;
            this.llbLogIn.TabStop = true;
            this.llbLogIn.Text = "Log in";
            this.llbLogIn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.llbLogIn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbLogIn_LinkClicked);
            // 
            // FrmSignUp
            // 
            this.AcceptButton = this.btnSignUp;
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(290, 670);
            this.Controls.Add(this.lblEmailIsRegistered);
            this.Controls.Add(this.llbLogIn);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.chkMale);
            this.Controls.Add(this.cmbCity);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblPasswordDoesNotMatch);
            this.Controls.Add(this.lblConfirmPassword);
            this.Controls.Add(this.lblPhoneIsRegistered);
            this.Controls.Add(this.chkShowPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblGetStarted);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmSignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sign Up";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGetStarted;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblPhoneIsRegistered;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.Label lblPasswordDoesNotMatch;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblEmailIsRegistered;
        private System.Windows.Forms.Label lblCity;
        private UserControls.CustomTextBox txtPhone;
        private UserControls.CustomTextBox txtPassword;
        private UserControls.CustomTextBox txtConfirmPassword;
        private UserControls.CustomTextBox txtFirstName;
        private UserControls.CustomTextBox txtLastName;
        private UserControls.CustomTextBox txtEmail;
        private System.Windows.Forms.CheckBox chkShowPassword;
        private System.Windows.Forms.ComboBox cmbCity;
        private System.Windows.Forms.CheckBox chkMale;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.LinkLabel llbLogIn;
    }
}