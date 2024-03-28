namespace movie_reservation_system.UIL.MovieUI
{
    partial class FrmMovie
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
            this.picImage = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tlpContent = new System.Windows.Forms.TableLayoutPanel();
            this.lblDirectorHeader = new System.Windows.Forms.Label();
            this.lblDirector = new System.Windows.Forms.Label();
            this.lblStarsHeader = new System.Windows.Forms.Label();
            this.lblStars = new System.Windows.Forms.Label();
            this.lblGenreHeader = new System.Windows.Forms.Label();
            this.lblGenre = new System.Windows.Forms.Label();
            this.lblReleaseDateHeader = new System.Windows.Forms.Label();
            this.lblReleaseDate = new System.Windows.Forms.Label();
            this.lblRuntimeHeader = new System.Windows.Forms.Label();
            this.lblRuntime = new System.Windows.Forms.Label();
            this.lblLanguageHeader = new System.Windows.Forms.Label();
            this.lblLanguage = new System.Windows.Forms.Label();
            this.lblRatingHeader = new System.Windows.Forms.Label();
            this.lblRating = new System.Windows.Forms.Label();
            this.lblDescriptionHeader = new System.Windows.Forms.Label();
            this.rtxDescription = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            this.tlpContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // picImage
            // 
            this.picImage.Dock = System.Windows.Forms.DockStyle.Left;
            this.picImage.Location = new System.Drawing.Point(0, 0);
            this.picImage.Margin = new System.Windows.Forms.Padding(0);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(400, 553);
            this.picImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picImage.TabIndex = 0;
            this.picImage.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(400, 0);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(482, 50);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tlpContent
            // 
            this.tlpContent.AutoSize = true;
            this.tlpContent.ColumnCount = 2;
            this.tlpContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpContent.Controls.Add(this.lblDirectorHeader, 0, 0);
            this.tlpContent.Controls.Add(this.lblDirector, 1, 0);
            this.tlpContent.Controls.Add(this.lblStarsHeader, 0, 1);
            this.tlpContent.Controls.Add(this.lblStars, 1, 1);
            this.tlpContent.Controls.Add(this.lblGenreHeader, 0, 2);
            this.tlpContent.Controls.Add(this.lblGenre, 1, 2);
            this.tlpContent.Controls.Add(this.lblReleaseDateHeader, 0, 3);
            this.tlpContent.Controls.Add(this.lblReleaseDate, 1, 3);
            this.tlpContent.Controls.Add(this.lblRuntimeHeader, 0, 4);
            this.tlpContent.Controls.Add(this.lblRuntime, 1, 4);
            this.tlpContent.Controls.Add(this.lblLanguageHeader, 0, 5);
            this.tlpContent.Controls.Add(this.lblLanguage, 1, 5);
            this.tlpContent.Controls.Add(this.lblRatingHeader, 0, 6);
            this.tlpContent.Controls.Add(this.lblRating, 1, 6);
            this.tlpContent.Controls.Add(this.lblDescriptionHeader, 0, 7);
            this.tlpContent.Controls.Add(this.rtxDescription, 1, 7);
            this.tlpContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpContent.Location = new System.Drawing.Point(400, 50);
            this.tlpContent.Margin = new System.Windows.Forms.Padding(0);
            this.tlpContent.Name = "tlpContent";
            this.tlpContent.RowCount = 8;
            this.tlpContent.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpContent.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpContent.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpContent.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpContent.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpContent.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpContent.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpContent.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpContent.Size = new System.Drawing.Size(482, 503);
            this.tlpContent.TabIndex = 2;
            // 
            // lblDirectorHeader
            // 
            this.lblDirectorHeader.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblDirectorHeader.AutoSize = true;
            this.lblDirectorHeader.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDirectorHeader.Location = new System.Drawing.Point(35, 0);
            this.lblDirectorHeader.Margin = new System.Windows.Forms.Padding(0);
            this.lblDirectorHeader.Name = "lblDirectorHeader";
            this.lblDirectorHeader.Size = new System.Drawing.Size(82, 23);
            this.lblDirectorHeader.TabIndex = 0;
            this.lblDirectorHeader.Text = "Director:";
            this.lblDirectorHeader.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDirector
            // 
            this.lblDirector.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDirector.AutoSize = true;
            this.lblDirector.Location = new System.Drawing.Point(117, 0);
            this.lblDirector.Margin = new System.Windows.Forms.Padding(0);
            this.lblDirector.Name = "lblDirector";
            this.lblDirector.Size = new System.Drawing.Size(0, 23);
            this.lblDirector.TabIndex = 1;
            this.lblDirector.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblStarsHeader
            // 
            this.lblStarsHeader.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblStarsHeader.AutoSize = true;
            this.lblStarsHeader.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStarsHeader.Location = new System.Drawing.Point(62, 23);
            this.lblStarsHeader.Margin = new System.Windows.Forms.Padding(0);
            this.lblStarsHeader.Name = "lblStarsHeader";
            this.lblStarsHeader.Size = new System.Drawing.Size(55, 23);
            this.lblStarsHeader.TabIndex = 2;
            this.lblStarsHeader.Text = "Stars:";
            this.lblStarsHeader.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblStars
            // 
            this.lblStars.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblStars.AutoSize = true;
            this.lblStars.Location = new System.Drawing.Point(117, 23);
            this.lblStars.Margin = new System.Windows.Forms.Padding(0);
            this.lblStars.Name = "lblStars";
            this.lblStars.Size = new System.Drawing.Size(0, 23);
            this.lblStars.TabIndex = 3;
            this.lblStars.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblGenreHeader
            // 
            this.lblGenreHeader.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblGenreHeader.AutoSize = true;
            this.lblGenreHeader.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenreHeader.Location = new System.Drawing.Point(55, 46);
            this.lblGenreHeader.Margin = new System.Windows.Forms.Padding(0);
            this.lblGenreHeader.Name = "lblGenreHeader";
            this.lblGenreHeader.Size = new System.Drawing.Size(62, 23);
            this.lblGenreHeader.TabIndex = 4;
            this.lblGenreHeader.Text = "Genre:";
            this.lblGenreHeader.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblGenre
            // 
            this.lblGenre.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblGenre.AutoSize = true;
            this.lblGenre.Location = new System.Drawing.Point(117, 46);
            this.lblGenre.Margin = new System.Windows.Forms.Padding(0);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(0, 23);
            this.lblGenre.TabIndex = 5;
            this.lblGenre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblReleaseDateHeader
            // 
            this.lblReleaseDateHeader.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblReleaseDateHeader.AutoSize = true;
            this.lblReleaseDateHeader.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReleaseDateHeader.Location = new System.Drawing.Point(0, 69);
            this.lblReleaseDateHeader.Margin = new System.Windows.Forms.Padding(0);
            this.lblReleaseDateHeader.Name = "lblReleaseDateHeader";
            this.lblReleaseDateHeader.Size = new System.Drawing.Size(117, 23);
            this.lblReleaseDateHeader.TabIndex = 6;
            this.lblReleaseDateHeader.Text = "Release Date:";
            this.lblReleaseDateHeader.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblReleaseDate
            // 
            this.lblReleaseDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblReleaseDate.AutoSize = true;
            this.lblReleaseDate.Location = new System.Drawing.Point(117, 69);
            this.lblReleaseDate.Margin = new System.Windows.Forms.Padding(0);
            this.lblReleaseDate.Name = "lblReleaseDate";
            this.lblReleaseDate.Size = new System.Drawing.Size(0, 23);
            this.lblReleaseDate.TabIndex = 7;
            this.lblReleaseDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRuntimeHeader
            // 
            this.lblRuntimeHeader.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblRuntimeHeader.AutoSize = true;
            this.lblRuntimeHeader.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRuntimeHeader.Location = new System.Drawing.Point(34, 92);
            this.lblRuntimeHeader.Margin = new System.Windows.Forms.Padding(0);
            this.lblRuntimeHeader.Name = "lblRuntimeHeader";
            this.lblRuntimeHeader.Size = new System.Drawing.Size(83, 23);
            this.lblRuntimeHeader.TabIndex = 8;
            this.lblRuntimeHeader.Text = "Runtime:";
            this.lblRuntimeHeader.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblRuntime
            // 
            this.lblRuntime.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblRuntime.AutoSize = true;
            this.lblRuntime.Location = new System.Drawing.Point(117, 92);
            this.lblRuntime.Margin = new System.Windows.Forms.Padding(0);
            this.lblRuntime.Name = "lblRuntime";
            this.lblRuntime.Size = new System.Drawing.Size(0, 23);
            this.lblRuntime.TabIndex = 9;
            this.lblRuntime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblLanguageHeader
            // 
            this.lblLanguageHeader.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblLanguageHeader.AutoSize = true;
            this.lblLanguageHeader.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLanguageHeader.Location = new System.Drawing.Point(24, 115);
            this.lblLanguageHeader.Margin = new System.Windows.Forms.Padding(0);
            this.lblLanguageHeader.Name = "lblLanguageHeader";
            this.lblLanguageHeader.Size = new System.Drawing.Size(93, 23);
            this.lblLanguageHeader.TabIndex = 10;
            this.lblLanguageHeader.Text = "Language:";
            this.lblLanguageHeader.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblLanguage
            // 
            this.lblLanguage.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblLanguage.AutoSize = true;
            this.lblLanguage.Location = new System.Drawing.Point(117, 115);
            this.lblLanguage.Margin = new System.Windows.Forms.Padding(0);
            this.lblLanguage.Name = "lblLanguage";
            this.lblLanguage.Size = new System.Drawing.Size(0, 23);
            this.lblLanguage.TabIndex = 11;
            this.lblLanguage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRatingHeader
            // 
            this.lblRatingHeader.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblRatingHeader.AutoSize = true;
            this.lblRatingHeader.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRatingHeader.Location = new System.Drawing.Point(49, 138);
            this.lblRatingHeader.Margin = new System.Windows.Forms.Padding(0);
            this.lblRatingHeader.Name = "lblRatingHeader";
            this.lblRatingHeader.Size = new System.Drawing.Size(68, 23);
            this.lblRatingHeader.TabIndex = 12;
            this.lblRatingHeader.Text = "Rating:";
            this.lblRatingHeader.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblRating
            // 
            this.lblRating.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblRating.AutoSize = true;
            this.lblRating.Location = new System.Drawing.Point(117, 138);
            this.lblRating.Margin = new System.Windows.Forms.Padding(0);
            this.lblRating.Name = "lblRating";
            this.lblRating.Size = new System.Drawing.Size(0, 23);
            this.lblRating.TabIndex = 13;
            this.lblRating.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDescriptionHeader
            // 
            this.lblDescriptionHeader.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDescriptionHeader.AutoSize = true;
            this.lblDescriptionHeader.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescriptionHeader.Location = new System.Drawing.Point(10, 161);
            this.lblDescriptionHeader.Margin = new System.Windows.Forms.Padding(0);
            this.lblDescriptionHeader.Name = "lblDescriptionHeader";
            this.lblDescriptionHeader.Size = new System.Drawing.Size(107, 23);
            this.lblDescriptionHeader.TabIndex = 14;
            this.lblDescriptionHeader.Text = "Description:";
            this.lblDescriptionHeader.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // rtxDescription
            // 
            this.rtxDescription.BackColor = System.Drawing.SystemColors.Control;
            this.rtxDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtxDescription.Location = new System.Drawing.Point(117, 161);
            this.rtxDescription.Margin = new System.Windows.Forms.Padding(0);
            this.rtxDescription.Name = "rtxDescription";
            this.rtxDescription.ReadOnly = true;
            this.rtxDescription.Size = new System.Drawing.Size(365, 342);
            this.rtxDescription.TabIndex = 15;
            this.rtxDescription.Text = "";
            // 
            // FrmMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.tlpContent);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.picImage);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMovie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmMovie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            this.tlpContent.ResumeLayout(false);
            this.tlpContent.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picImage;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TableLayoutPanel tlpContent;
        private System.Windows.Forms.Label lblDirectorHeader;
        private System.Windows.Forms.Label lblDirector;
        private System.Windows.Forms.Label lblStarsHeader;
        private System.Windows.Forms.Label lblStars;
        private System.Windows.Forms.Label lblGenreHeader;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.Label lblReleaseDateHeader;
        private System.Windows.Forms.Label lblReleaseDate;
        private System.Windows.Forms.Label lblRuntimeHeader;
        private System.Windows.Forms.Label lblRuntime;
        private System.Windows.Forms.Label lblLanguageHeader;
        private System.Windows.Forms.Label lblLanguage;
        private System.Windows.Forms.Label lblRatingHeader;
        private System.Windows.Forms.Label lblRating;
        private System.Windows.Forms.Label lblDescriptionHeader;
        private System.Windows.Forms.RichTextBox rtxDescription;
    }
}