using System.Data;
using System.Data.SqlClient;
using movie_reservation_system.DL;
using movie_reservation_system.Entities;

namespace movie_reservation_system.DAL
{
    internal class UserDataAccessObject
    {
        private readonly DbConnection _dbConnection = new DbConnection();

        public string AuthenticateUser(string phone, string password)
        {
            var paras = new SqlParameter[3];
            paras[0] = new SqlParameter("@pPhone", SqlDbType.VarChar);
            paras[1] = new SqlParameter("@pPassword", SqlDbType.NVarChar);
            paras[2] = new SqlParameter("@rResponse", SqlDbType.NVarChar, 255);

            paras[0].Value = phone;
            paras[1].Value = password;
            paras[2].Direction = ParameterDirection.Output;

            _dbConnection.ExecuteNonQuery("usp_AuthenticateUser", paras);
            return paras[2].Value.ToString();
        }

        public void InsertUser(User user, string password)
        {
            var paras = new SqlParameter[7];
            paras[0] = new SqlParameter("@pPhone", SqlDbType.VarChar);
            paras[1] = new SqlParameter("@pFirstName", SqlDbType.NVarChar);
            paras[2] = new SqlParameter("@pLastName", SqlDbType.NVarChar);
            paras[3] = new SqlParameter("@pSex", SqlDbType.Char);
            paras[4] = new SqlParameter("@pEmail", SqlDbType.NVarChar);
            paras[5] = new SqlParameter("@pCity", SqlDbType.NVarChar);
            paras[6] = new SqlParameter("@pPassword", SqlDbType.NVarChar);

            paras[0].Value = user.Phone;
            paras[1].Value = user.FirstName;
            paras[2].Value = user.LastName;
            paras[3].Value = user.Sex;
            paras[4].Value = user.Email;
            paras[5].Value = user.City;
            paras[6].Value = password;

            _dbConnection.ExecuteNonQuery("usp_InsertUser", paras);
        }
    }
}