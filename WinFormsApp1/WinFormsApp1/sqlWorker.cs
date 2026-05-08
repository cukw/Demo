using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;
using WinFormsApp1.models;

namespace WinFormsApp1
{
    public class sqlWorker : SqlWorkers
    {
        private readonly Config conf = new Config();

        public sqlWorker(Config conf)
        {
            this.conf = conf;
        }

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

        public async Task<User> GetCurrentUserInfo(string login, string password)
        {
            using (SqlConnection conn = getConnection())
            {
                await conn.OpenAsync();
                using (SqlCommand com = getCommand(conf.getUserInfoRequest(), conn))
                {
                    com.Parameters.AddWithValue("@login", login);
                    com.Parameters.AddWithValue("@password", password);


                    using (var reader = await com.ExecuteReaderAsync())
                    {
                        if (await reader.ReadAsync())
                        {
                            return new User(
                                reader.GetInt32(0),
                                reader.GetString(1),
                                reader.GetString(2),
                                reader.GetString(3),
                                reader.GetString(4)
                                );
                        }
                    }
                }
            }
            throw new Exception("can not create user");
        }


    }
}
