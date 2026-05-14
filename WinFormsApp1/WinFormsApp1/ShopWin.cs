using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.models;
using WinFormsApp1.templates;

namespace WinFormsApp1
{
    public partial class ShopWin : Form
    {
        private readonly SqlService service;

        public ShopWin(SqlService service)
        {
            InitializeComponent();
            this.service = service;
        }

        private async void ShomWin_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            Greeter.Text += service.GetUserFullName();

            switch (service.GetUserRole())
            {
                case "Авторизированный пользователь":

                    break;
                case "Администратор":

                    break;
                case "Менеджер":

                    break;

                default: return;
            }



            foreach (var info in await service.GetItemsInfo())
            {
                CardTemplates card = new CardTemplates();
                card.SetData(info.Articul, info.About, info.Author, info.Courier, info.Price, info.Unit, info.Count, info.Discount, info.Photo);

                if (info.Discount >= 15)
                {
                    card.BackColor = ColorTranslator.FromHtml("#2E8B57");
                }

                card.Tag = info;
                card.Click += CardTemplates_Click;

                ShowCardsItems.Controls.Add(card);
            }

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm form = new LoginForm();
            await form.ShowAsync();
        }

        private void ShowCardsItems_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CardTemplates_Click(object sender, EventArgs e)
        {
            CardTemplates card = (CardTemplates)sender;
            Items item = (Items)card.Tag;

            MessageBox.Show($"Выбран товар: {item.Articul}");
        }
    }
}
 