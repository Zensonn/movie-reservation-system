using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using movie_reservation_system.BLL;

namespace movie_reservation_system.UIL.UserUI
{
    public partial class FrmLogIn : Form
    {
        private readonly FrmUserContainer _parentContainer;
        private readonly UserBusinessLogicObject _userBusinessLogicObject;

        public FrmLogIn(FrmUserContainer parentContainer)
        {
            InitializeComponent();
            _parentContainer = parentContainer;
            _userBusinessLogicObject = new UserBusinessLogicObject();
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = !chkShowPassword.Checked;
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            lblUnregisteredPhone.Visible = lblWrongPassword.Visible = false;
            txtPhone.BorderFocusedColor = txtPassword.BorderFocusedColor = Color.MediumOrchid;

            var phone = txtPhone.CustomText.Trim();
            var password = txtPassword.CustomText.Trim();
            if (string.IsNullOrEmpty(phone) || string.IsNullOrEmpty(password))
                return;

            try
            {
                var response = _userBusinessLogicObject.AuthenticateUser(phone, password);
                switch (response)
                {
                    case 0:
                    {
                        lblUnregisteredPhone.Visible = true;
                        txtPhone.BorderFocusedColor = Color.Red;
                        txtPhone.Focus();
                        break;
                    }
                    case 1:
                    {
                        lblWrongPassword.Visible = true;
                        txtPassword.BorderFocusedColor = Color.Red;
                        txtPassword.Focus();
                        break;
                    }
                    case 2:
                    {
                        // DialogResult.No means user is not an admin
                        _parentContainer.DialogResult = DialogResult.No;
                        break;
                    }
                    default:
                    {
                        // DialogResult.Yes means user is an admin
                        _parentContainer.DialogResult = DialogResult.Yes;
                        break;
                    }
                }
            }
            catch (SqlException exception)
            {
                Messenger.Error($"SQL level error caught: {exception.Message}");
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

        private void llbSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Close();
            _parentContainer.LoadChildForm(new FrmSignUp(_parentContainer));
        }
    }
}