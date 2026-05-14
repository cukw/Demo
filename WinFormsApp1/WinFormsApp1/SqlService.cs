using System;
using System.Collections.Generic;
using System.Text;
using WinFormsApp1.models;

namespace WinFormsApp1
{
    public class SqlService
    {
        private readonly SqlWorkers worker;
        private User user;

        public SqlService(SqlWorkers worker)
        {
            this.worker = worker; 
        }

        public bool ErrorHandle(TextBox textBox)
        {
            if (string.IsNullOrEmpty(textBox.Text))
            {
                return false;
            }
            return true;
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

        public async Task<List<Items>> GetItemsInfo() => await worker.GetProducts();

        public string GetUserFullName() => user is not null ? $"{user.surname} {user.f_name} {user.s_name}": "Guest";
        public string GetUserRole() => user is not null? user.role : "Guest";
    }
}
