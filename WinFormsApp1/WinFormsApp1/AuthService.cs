using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp1
{
    internal class AuthService
    {
        private readonly sqlWorker worker;

        public AuthService(sqlWorker worker)
        {
            this.worker = worker; 
        }

        public Task<bool> authenticate(string login, string password) => worker.authUser(login, password);
    }
}
