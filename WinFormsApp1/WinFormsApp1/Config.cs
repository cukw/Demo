using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp1
{
    public class Config
    {
        private readonly string server = "Server=cukw\\SQLEXPRESS;Database=trashWB;Trusted_Connection=True;TrustServerCertificate=True";
        private readonly string authRequest = "select 1 from users where login=@login and password=@password";
        private readonly string UserInfoRequest = "select id, role, surname, f_name, s_name from users where login=@login and password=@password";

        public string getServerConnection() => server;
        public string getAuthRequest() => authRequest;
        public string getUserInfoRequest() => UserInfoRequest;
    }
}
