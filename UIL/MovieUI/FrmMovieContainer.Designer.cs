namespace movie_reservation_system.UIL.MovieUI
{
    partial class FrmMovieContainer
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
            this.tlpMovie = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // tlpMovie
            // 
            this.tlpMovie.AutoScroll = true;
            this.tlpMovie.ColumnCount = 3;
            this.tlpMovie.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpMovie.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tlpMovie.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tlpMovie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMovie.Location = new System.Drawing.Point(0, 0);
            this.tlpMovie.Margin = new System.Windows.Forms.Padding(0);
            this.tlpMovie.Name = "tlpMovie";
            this.tlpMovie.RowCount = 1;
            this.tlpMovie.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMovie.Size = new System.Drawing.Size(1500, 820);
            this.tlpMovie.TabIndex = 0;
            // 
            // FrmMovieContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1500, 820);
            this.Controls.Add(this.tlpMovie);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMovieContainer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.FrmMovie_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMovie;
    }
}