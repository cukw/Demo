using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp1
{
    internal class Config
    {
        private string server = "Server=cukw\\SQLEXPRESS;Database=trashWB;Trusted_Connection=True;TrustServerCertificate=True";
        private string authRequest = "select 1 from users where login=@login and password=@password";

        public string getServerConnection() => server;
        public string getAuthRequest() => authRequest;
    }
}
