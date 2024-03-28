using System;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using movie_reservation_system.BLL;
using movie_reservation_system.Entities;

namespace movie_reservation_system.UIL.MovieUI
{
    public partial class FrmMovieContainer : Form
    {
        private readonly MovieBusinessLogicObject _movieBusinessLogicObject = new MovieBusinessLogicObject();

        public FrmMovieContainer()
        {
            InitializeComponent();
        }

        private void AddMoviePanel(Movie movie)
        {
            var picImage = new PictureBox();
            var lblTitle = new Label();
            var lblGenre = new Label();
            var lblRuntime = new Label();
            var lblReleaseDate = new Label();
            var btnBook = new Button();

            var pnlMovie = new Panel();
            pnlMovie.Controls.Add(lblRuntime);
            pnlMovie.Controls.Add(lblReleaseDate);
            pnlMovie.Controls.Add(lblGenre);
            pnlMovie.Controls.Add(lblTitle);
            pnlMovie.Controls.Add(picImage);
            pnlMovie.Controls.Add(btnBook);

            #region Programatically generated assets

            //
            // pnlMovie
            //
            pnlMovie.Dock = DockStyle.Fill;
            pnlMovie.Margin = new Padding(0);
            pnlMovie.Name = movie.MovieID.ToString();
            pnlMovie.Size = new Size(375, 610);
            pnlMovie.TabIndex = movie.MovieID;
            //
            // picImage
            //
            picImage.Click += (sender, e) => picImage_Click(movie);
            picImage.Cursor = Cursors.Hand;
            picImage.Dock = DockStyle.Top;
            picImage.Margin = new Padding(0);
            picImage.Size = new Size(315, 400);
            picImage.SizeMode = PictureBoxSizeMode.Zoom;
            picImage.TabIndex = 0;
            picImage.TabStop = false;
            using (var memoryStream = new MemoryStream(movie.Image))
            {
                picImage.Image = Image.FromStream(memoryStream);
            }

            //
            // lblTitle
            //
            lblTitle.Dock = DockStyle.Top;
            lblTitle.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(315, 40);
            lblTitle.TabIndex = 1;
            lblTitle.Text = movie.Title;
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            //
            // lblGenre
            //
            lblGenre.Dock = DockStyle.Top;
            lblGenre.Name = "lblGenre";
            lblGenre.Size = new Size(315, 35);
            lblGenre.TabIndex = 2;
            lblGenre.Text = $@"Genre: {movie.Genre}";
            lblGenre.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblReleaseDate
            // 
            lblReleaseDate.Dock = DockStyle.Top;
            lblReleaseDate.Name = "lblReleaseDate";
            lblReleaseDate.Size = new Size(315, 35);
            lblReleaseDate.TabIndex = 4;
            lblReleaseDate.Text = $@"Release Date: {movie.ReleaseDate:dd/MM/yyyy}";
            lblReleaseDate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblRuntime
            // 
            lblRuntime.Dock = DockStyle.Top;
            lblRuntime.Name = "lblRuntime";
            lblRuntime.Size = new Size(315, 35);
            lblRuntime.TabIndex = 3;
            lblRuntime.Text = $@"Runtime: {movie.Runtime} minutes";
            lblRuntime.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnBook
            // 
            btnBook.Click += btnBook_Click;
            btnBook.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBook.Location = new Point(350, 560);
            btnBook.Name = movie.MovieID.ToString();
            btnBook.Size = new Size(70, 35);
            btnBook.TabIndex = 5;
            btnBook.Text = @"BOOK";

            #endregion

            tlpMovie.Controls.Add(pnlMovie);
        }

        private void picImage_Click(Movie movie)
        {
            using (var frmMovie = new FrmMovie(movie))
            {
                frmMovie.Show();
            }
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
        }

        private void FrmMovie_Load(object sender, EventArgs e)
        {
            try
            {
                var movieList = _movieBusinessLogicObject.GetMovieNowShowing();
                if (movieList == null)
                    return;
                foreach (var movie in movieList)
                    AddMoviePanel(movie);
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
    }
}