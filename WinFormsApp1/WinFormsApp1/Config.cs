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
        private readonly string PathToImage = Path.GetFullPath(@"..\..\..\data", AppDomain.CurrentDomain.BaseDirectory);
        private readonly string ProductInfoRequest = "select * from items";
        private readonly string FindProductRequest = "select * from items where articul=@var or unit=@var or courier=@var or author=@var or about=@var";
        
        public string getServerConnection() => server;
        public string getAuthRequest() => authRequest;
        public string getUserInfoRequest() => UserInfoRequest;

        public string getPathToImage(string image) => Path.Combine(PathToImage, image);
        public string getProductInfoRequest() => ProductInfoRequest;
        public string getFindProductRequest(string conditiion) => FindProductRequest;
    }
}
