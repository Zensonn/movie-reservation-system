using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using movie_reservation_system.Entities;

namespace movie_reservation_system.UIL.MovieUI
{
    public partial class FrmMovie : Form
    {
        private readonly Movie _movie;

        public FrmMovie(Movie movie)
        {
            InitializeComponent();
            ActiveControl = picImage;
            _movie = movie;
        }

        private void FrmMovie_Load(object sender, EventArgs e)
        {
            using (var memoryStream = new MemoryStream(_movie.Image))
            {
                picImage.Image = Image.FromStream(memoryStream);
            }

            lblTitle.Text = _movie.Title;
            lblDirector.Text = _movie.Director;
            lblStars.Text = _movie.Stars;
            lblGenre.Text = _movie.Genre;
            lblReleaseDate.Text = _movie.ReleaseDate.ToString("dd/MM/yyyy");
            lblRuntime.Text = $@"{_movie.Runtime} minutes";
            lblLanguage.Text = _movie.Language;
            lblRating.Text = _movie.Rating;
            rtxDescription.Text = _movie.Description;
        }
    }
}