using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp1
{
    internal class sqlWorker
    {
        private Config conf = new Config();
        private SqlConnection getConnection() => new SqlConnection(conf.getServerConnection());
        private SqlCommand getCommand(string command, SqlConnection conn) => new SqlCommand(command, conn);

        public async Task<bool> authUser(string login, string password)
        {
            using (SqlConnection conn = getConnection())
            {
                await conn.OpenAsync();

                using(SqlCommand com = getCommand(conf.getAuthRequest(), conn))
                {
                    com.Parameters.AddWithValue("@login", login);
                    com.Parameters.AddWithValue("@password", password);

                    return await com.ExecuteScalarAsync() != null;
                }    
            }
        }


    }
}
