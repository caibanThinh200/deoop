using QLCAPHE.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCAPHE.DAO
{
    class TableDAO
    {
        public static int TableWidth = 70;
        public static int TableHeight = 70;
        private static TableDAO instance;
        public static TableDAO Instance
         {
            get
            {
                if (instance == null)
                    instance = new TableDAO();
                return TableDAO.instance;
            }
            private set
            {
                instance = value;
            }
        }
        public List<Table> LoadTableList()
        {
            List<Table> tableList = new List<Table>();
            DataTable data = Dataprovider.Instance.ExecuteQuerry("EXEC USP_Gettablelist");
            foreach(DataRow item in data.Rows)
            {
                Table table = new Table(item);
                tableList.Add(table);
            }

            return tableList;
        }

        
    }
}
