using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCAPHE.DTO
{
    class MenuList
    {
        private string foodName;
        private int count;
        private int price;
        private int totalPrice = 0;

        public MenuList(string foodName, int count, int price, int totalPrice = 0)
        {
            this.FoodName = foodName;
            this.Count = count;
            this.Price = price;
            this.TotalPrice = totalPrice;
        }
        public MenuList(DataRow row)
        {
            this.FoodName = row["TENSP"].ToString();
            this.Count = (int)row["COUNT"];
            this.Price = (int)row["HOADON"];
            this.TotalPrice = Count * Price;
        }
        public string FoodName { get => foodName; set => foodName = value; }
        public int Count { get => count; set => count = value; }
        public int Price { get => price; set => price = value; }
        public int TotalPrice { get => totalPrice; set => totalPrice = value; }
    }
}