using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class ShomWin : Form
    {
        private readonly SqlService service;
        public ShomWin(SqlService service)
        {
            InitializeComponent();
            this.service = service;

        }

        private void ShomWin_Load(object sender, EventArgs e)
        {
            FullName.Text = service.GetUserFullName();
        }
    }
}
 