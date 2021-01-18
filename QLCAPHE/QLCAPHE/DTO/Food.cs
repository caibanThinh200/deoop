using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCAPHE.DTO
{
    class Food
    {
        private string id;
        private string foodName;
        private int price;
        private string type;
        private int idCategory;

        public Food(string id, string foodName, int price, string type, int idCategory)
        {
            this.id = id;
            this.foodName = foodName;
            this.price = price;
            this.type = type;
            this.idCategory = idCategory;
        }
        public Food(DataRow row)
        {
            this.FoodName = row["TENSP"].ToString();
            this.Id = (string)row["MASP"];
            this.FoodName = row["TENSP"].ToString();
            this.Price = (int)row["HOADON"];
            this.Type = row["THELOAI"].ToString();
            this.IdCategory = (int)row["IDCATEGORY"];
        }
        public string Id { get => id; set => id = value; }
        public string FoodName { get => foodName; set => foodName = value; }
        public int Price { get => price; set => price = value; }
        public string Type { get => type; set => type = value; }
        public int IdCategory { get => idCategory; set => idCategory = value; }
    }
}
