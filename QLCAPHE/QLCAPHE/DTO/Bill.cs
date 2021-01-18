using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCAPHE.DTO
{
    class Bill
    {
        private int id;
        private DateTime timeCheckin;
        private int idTable;

        public Bill(int id, DateTime timeCheckin,int idTable)
        {
            this.Id = id;
            this.TimeCheckin = timeCheckin;
            this.IdTable = idTable;
        }

        public int Id { get => id; set => id = value; }
        public DateTime TimeCheckin { get => timeCheckin; set => timeCheckin = value; }
        public int IdTable { get => idTable; set => idTable = value; }

        public Bill(DataRow row)
        {
            this.Id = (int)row["id"];
            this.TimeCheckin = (DateTime)row["BILLTIME"];
            this.IdTable = (int)row["idTable"];
        }
    }
}
