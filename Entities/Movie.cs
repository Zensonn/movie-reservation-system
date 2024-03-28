using System;

namespace movie_reservation_system.Entities
{
    public class Movie
    {
        public int MovieID { get; set; }
        public string Title { get; set; }
        public string Director { get; set; }
        public string Stars { get; set; }
        public string Genre { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int Runtime { get; set; }
        public string Language { get; set; }
        public string Rating { get; set; }
        public string Description { get; set; }
        public byte[] Image { get; set; }
    }
}