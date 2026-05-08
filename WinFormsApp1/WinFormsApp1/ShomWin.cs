using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class ShomWin : Form
    {
        private readonly SqlService service;
        private bool ButtonConfig { get; set; }

        internal bool getButtonStatus() => ButtonConfig;
        
        public ShomWin(SqlService service)
        {
            InitializeComponent();
            this.service = service;

        }

        private void ShomWin_Load(object sender, EventArgs e)
        {
            FullName.Text = service.GetUserFullName();

            switch(service.GetUserRole())
            {
                case "Авторизированный пользователь":

                    break;
                case "Администратор":
                    
                    break;
                case "Менеджер":

                    break;

                default: return;
            }

        }
    }
}
 