using System;
using System.Collections.Generic;
using System.Text;
using WinFormsApp1.models;

namespace WinFormsApp1
{
    public class SqlService
    {
        private readonly sqlWorker worker;
        private User user;

        public SqlService(sqlWorker worker)
        {
            this.worker = worker; 
        }

        public async Task<bool> authenticate(string login, string password)
        {
            if (await worker.authUser(login, password))
            {
                user = await worker.GetCurrentUserInfo(login, password);
                return true;
            }
            return false;
        }

        public string GetUserFullName() => $"{user.surname} {user.f_name} {user.s_name}";
    }
}
