using System.Data;
using System.Data.SqlClient;
using movie_reservation_system.Properties;

namespace movie_reservation_system.DL
{
    internal class DbConnection
    {
        private readonly SqlConnection _conn = new SqlConnection(Resources.connStr);

        private SqlConnection OpenConnection()
        {
            if (_conn.State == ConnectionState.Closed || _conn.State == ConnectionState.Broken)
                _conn.Open();
            return _conn;
        }

        public DataTable ExecuteLoadQuery(string query, SqlParameter[] paras = null,
            CommandType cmdType = CommandType.StoredProcedure)
        {
            try
            {
                using (var cmd = new SqlCommand(query, OpenConnection()))
                {
                    if (paras != null)
                        cmd.Parameters.AddRange(paras);
                    cmd.CommandType = cmdType;
                    using (var da = new SqlDataAdapter(cmd))
                    {
                        using (var ds = new DataSet())
                        {
                            da.Fill(ds);
                            return ds.Tables[0];
                        }
                    }
                }
            }
            finally
            {
                _conn.Close();
            }
        }

        public void ExecuteNonQuery(string query, SqlParameter[] paras = null,
            CommandType cmdType = CommandType.StoredProcedure)
        {
            try
            {
                using (var cmd = new SqlCommand(query, OpenConnection()))
                {
                    if (paras != null)
                        cmd.Parameters.AddRange(paras);
                    cmd.CommandType = cmdType;
                    cmd.ExecuteNonQuery();
                }
            }
            finally
            {
                _conn.Close();
            }
        }

        public object ExecuteScalar(string query, SqlParameter[] paras = null,
            CommandType cmdType = CommandType.StoredProcedure)
        {
            try
            {
                using (var cmd = new SqlCommand(query, OpenConnection()))
                {
                    if (paras != null)
                        cmd.Parameters.AddRange(paras);
                    cmd.CommandType = cmdType;
                    return cmd.ExecuteScalar();
                }
            }
            finally
            {
                _conn.Close();
            }
        }
    }
}