using System;
using System.Collections.Generic;
using System.Text;
using WinFormsApp1.models;

namespace WinFormsApp1
{
        public interface SqlWorkers
        {
            Task<bool>authUser(string login, string password);

            Task<User> GetCurrentUserInfo(string login, string password);
        }
}
