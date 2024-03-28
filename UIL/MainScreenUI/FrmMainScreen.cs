using System;
using System.Windows.Forms;
using movie_reservation_system.UIL.MovieUI;
using movie_reservation_system.UIL.UserUI;

namespace movie_reservation_system.UIL.MainScreenUI
{
    public partial class FrmMainScreen : Form
    {
        private Form _childForm;

        public FrmMainScreen()
        {
            InitializeComponent();
            ActiveControl = btnNowShowing;
            LoadChildForm(new FrmMovieContainer());
        }

        private void LoadChildForm(Form childForm)
        {
            _childForm?.Close();
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            childForm.FormBorderStyle = FormBorderStyle.None;
            pnlChildForm.Controls.Add(childForm);
            pnlChildForm.Tag = childForm;
            _childForm = childForm;
            childForm.Show();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            using (var frmUserContainer = new FrmUserContainer())
            {
                // Able to fetch a dialog result means the user is successfully authenticated
                // DialogResult.No means user is not an admin
                // DialogResult.Yes means user is an admin
                var dialogResult = frmUserContainer.ShowDialog();
                if (dialogResult == DialogResult.No || dialogResult == DialogResult.Yes)
                    btnLogIn.Visible = false;
            }
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            if (Messenger.Confirm("Quit application?") == DialogResult.Yes)
                Close();
        }
    }
}