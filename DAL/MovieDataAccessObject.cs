using System.Data;
using movie_reservation_system.DL;

namespace movie_reservation_system.DAL
{
    internal class MovieDataAccessObject
    {
        private readonly DbConnection _dbConnection = new DbConnection();

        public DataTable GetMovieComingSoon()
        {
            return _dbConnection.ExecuteLoadQuery("usp_GetMovieComingSoon");
        }

        public DataTable GetMovieNowShowing()
        {
            return _dbConnection.ExecuteLoadQuery("usp_GetMovieNowShowing");
        }
    }
}