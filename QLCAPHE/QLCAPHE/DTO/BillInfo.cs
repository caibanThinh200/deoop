using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCAPHE.DTO
{
    class BillInfo
    {
        private int id;
        private int totalPrice;
        private string foodName;
        private int count;

        public BillInfo(int id, int totalPrice, string foodName, int count)
        {
            this.Id = id;
          
            this.FoodName = foodName;
            this.Count = count;
            this.TotalPrice = totalPrice;
        }

        public int Id { get => id; set => id = value; }
       
        public string FoodName { get => foodName; set => foodName = value; }
        public int Count { get => count; set => count = value; }
        public int TotalPrice { get => totalPrice; set => totalPrice = value; }

        public BillInfo(DataRow row)
        {
            this.Id = (int)row["id"];
           
            this.FoodName = row["FOODNAME"].ToString();
            this.Count = (int)row["COUNT"];
           
        }
    }
    

}
