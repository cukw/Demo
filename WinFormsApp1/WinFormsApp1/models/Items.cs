using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp1.models
{
    public class Items
    {
        public string Articul { get; private set; }

        public string NameItem { get; set; }

        public string Unit { get; set; }

        public decimal Price { get; set; }

        public string Courier { get; set; }

        public string Author { get; set; }

        public string Category { get; set; }

        public int Discount { get; set; }

        public int Count { get; set; }

        public string About { get; set; }

        public Image Photo { get; set; }

        public Items(
            string articul,
            string nameItem,
            string unit,
            decimal price,
            string courier,
            string author,
            string category,
            int discount,
            int count,
            string about,
            Image photo)
        {
            Articul = articul;
            NameItem = nameItem;
            Unit = unit;
            Price = price;
            Courier = courier;
            Author = author;
            Category = category;
            Discount = discount;
            Count = count;
            About = about;
            Photo = photo;
        }
    }
}
