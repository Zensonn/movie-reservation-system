using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using movie_reservation_system.BLL;
using movie_reservation_system.Entities;
using movie_reservation_system.UserControls;

namespace movie_reservation_system.UIL.UserUI
{
    public partial class FrmSignUp : Form
    {
        private readonly FrmUserContainer _parentContainer;
        private readonly UserBusinessLogicObject _userBusinessLogicObject;

        public FrmSignUp(FrmUserContainer parentContainer)
        {
            InitializeComponent();
            _parentContainer = parentContainer;
            _userBusinessLogicObject = new UserBusinessLogicObject();
        }

        private bool IsAllFilledIn()
        {
            return !string.IsNullOrWhiteSpace(cmbCity.Text) &&
                   (from object control in Controls
                       where control.GetType() == typeof(CustomTextBox)
                       select control as CustomTextBox).All(txt => !string.IsNullOrWhiteSpace(txt.CustomText));
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = txtConfirmPassword.PasswordChar = !chkShowPassword.Checked;
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            lblPhoneIsRegistered.Visible = lblPasswordDoesNotMatch.Visible = lblEmailIsRegistered.Visible = false;
            txtPhone.BorderFocusedColor = txtConfirmPassword.BorderFocusedColor =
                txtEmail.BorderFocusedColor = Color.MediumOrchid;

            if (!IsAllFilledIn())
                return;

            var password = txtPassword.CustomText.Trim();
            var confirmedPassword = txtConfirmPassword.CustomText.Trim();
            if (!password.Equals(confirmedPassword))
            {
                lblPasswordDoesNotMatch.Visible = true;
                txtConfirmPassword.BorderFocusedColor = Color.Red;
                txtConfirmPassword.Focus();
                return;
            }

            var phone = txtPhone.CustomText.Trim();
            var firstName = txtFirstName.CustomText.Trim();
            var lastName = txtLastName.CustomText.Trim();
            var email = txtEmail.CustomText.Trim();
            var city = cmbCity.Text.Trim();
            var sex = chkMale.Checked ? '1' : '2'; // Following ISO/IEC 5218, 1 is male, 2 is female
            var user = new User(phone, firstName, lastName, sex, email, city);
            try
            {
                _userBusinessLogicObject.InsertUser(user, password);
                Messenger.Notification("Your account has been created! You can log in now!");
            }
            catch (SqlException exception)
            {
                switch (exception.Number)
                {
                    case 2627:
                        lblPhoneIsRegistered.Visible = true;
                        txtPhone.BorderFocusedColor = Color.Red;
                        txtPhone.Focus();
                        break;
                    case 2601:
                        lblEmailIsRegistered.Visible = true;
                        txtEmail.BorderFocusedColor = Color.Red;
                        txtEmail.Focus();
                        break;
                    default:
                        Messenger.Error($"SQL level error caught: {exception.Message}");
                        break;
                }
            }
            catch (Exception exception)
            {
                Messenger.Error($"Application level error caught: {exception.Message}");
            }
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            _parentContainer.DialogResult = DialogResult.Cancel;
            _parentContainer.Close();
        }

        private void llbLogIn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Close();
            _parentContainer.LoadChildForm(new FrmLogIn(_parentContainer));
        }
    }
}