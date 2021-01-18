using QLCAPHE.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCAPHE.DAO
{
    class BillDAO
    {
        private static BillDAO instance;

        internal static BillDAO Instance
        {
            get { if (instance == null) instance = new BillDAO(); return BillDAO.instance; }
            private set
            {
                BillDAO.instance = value;
            }
        }
        private BillDAO()
        {

        }
        public int GetUncheckBillByTableNum(int tableNum)

        {
            DataTable table = Dataprovider.Instance.ExecuteQuerry("SELECT * FROM BILL WHERE idTable=" + tableNum);
            if (table.Rows.Count > 0)
            {
                Bill bill = new Bill(table.Rows[0]);
                return bill.Id;

            }
            return -1;
        }

        public void InsertBill(int id)
        {
            Dataprovider.Instance.ExecuteNonQuery("EXEC  USP_InsertBillInfo @idBill INT, @idFood CHAR, @count INT", new object[] { id });

        }
        public int GetMaxIdBill()
        {
            try
            {
               return (int)Dataprovider.Instance.ExecuteScalar("select max(id) from BILL");
            }
            catch
            {
                return -1;
            }

        }
    }
}
