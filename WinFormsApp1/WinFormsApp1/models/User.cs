using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp1.models
{
    public class User
    {
        public int id { get; private set; }
        public string role { get; private set; }
        public string surname { get; private set; }
        public string f_name { get; private set; }
        public string s_name { get; private set; }

        public User(int id, string role, string surname, string f_name, string s_name) 
        {
            this.id = id;
            this.role = role;
            this.surname = surname;
            this.f_name = f_name;
            this.s_name = s_name;
        }
    }
}
