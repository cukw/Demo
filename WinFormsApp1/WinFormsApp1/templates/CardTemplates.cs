using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.PerformanceData;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1.templates
{
    public partial class CardTemplates : UserControl
    {
        public CardTemplates()
        {
            InitializeComponent();

            foreach (Control control in this.Controls)
            {
                control.Click += (s, e) => this.OnClick(e);
            }
        }

        public void SetData(string name, string description, string creator, string dealer, decimal price, string unit, int count, int discount, Image image)
        {
            NameItem.Text += name;
            Description.Text = description;
            Creator.Text = creator;
            Dealer.Text = dealer;
            Price.Text = price.ToString();
            Unit.Text = unit;
            Count.Text = count.ToString();
            Discount.Text += $"\n{discount}";
            ImageItem.Image = image;
        }

        private void CardTemplates_Load(object sender, EventArgs e)
        {

        }
        private void CardTemplates_Click(object sender, EventArgs e)
        {

        }
    }
}
