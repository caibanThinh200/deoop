using QLCAPHE.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCAPHE.DTO
{
    class Table
    {
        private int id;
        public int numTable;
        public string sstatic;

        public int NumTable { get => numTable; set => numTable = value; }
        public string Sstatic { get => sstatic; set => sstatic = value; }
        public int Id { get => id; set => id = value; }

        public Table (int numTable, string sstatic,int id)
        {
            this.numTable = numTable;
            this.sstatic = sstatic;
            this.id = id;
        }
        public Table(DataRow row)
        {
            this.NumTable = (int)row["TABLENUM"];
            this.Sstatic = row["STATUS"].ToString();
            this.Id =  (int)row["id"];
        }
        
        /*
        private int iD;
        private string name;
        private string status;
        
        public Table(int iD, string name, string status)
        {
            this.ID = iD;
            this.Name = name;
            this.Status = status;
        }

        public int ID { get => iD; set => iD = value; }
        public string Name { get => name; set => name = value; }
        public string Status { get => status; set => status = value; }
        public Table (DataRow row)
        {
            this.ID = (int)row["iD"];
            this.Name = row["name"].ToString();
            this.Status = row["status"].ToString();
        }
        */
    }
}
