using movie_reservation_system.DAL;
using movie_reservation_system.Entities;

namespace movie_reservation_system.BLL
{
    internal class UserBusinessLogicObject
    {
        private readonly UserDataAccessObject _userDataAccessObject = new UserDataAccessObject();

        public int AuthenticateUser(string phone, string password)
        {
            var response = _userDataAccessObject.AuthenticateUser(phone, password);
            switch (response)
            {
                case "Failed":
                    return 0;
                case "Incorrect password":
                    return 1;
                case "db_datareader":
                    return 2;
                default:
                    return 3;
            }
        }

        public void InsertUser(User user, string password)
        {
            _userDataAccessObject.InsertUser(user, password);
        }
    }
}