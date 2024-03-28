using System.Drawing;
using System.Windows.Forms;

namespace movie_reservation_system.UIL.UserUI
{
    public partial class FrmUserContainer : Form
    {
        public FrmUserContainer()
        {
            InitializeComponent();
            LoadChildForm(new FrmLogIn(this));
        }

        public void LoadChildForm(Form childForm)
        {
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            childForm.FormBorderStyle = FormBorderStyle.None;
            pnlChildForm.Controls.Add(childForm);
            pnlChildForm.Tag = childForm;
            Height = childForm.Height;
            picLogo.Location = new Point(0, (Height - picLogo.Height) / 2);
            childForm.Show();
            CenterToScreen();
        }
    }
}