using QLCAPHE.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCAPHE.DAO
{
    class BillInfoDAO
    {
        private static BillInfoDAO instance;
        private BillInfoDAO ()
        {

        }
        public static BillInfoDAO Instance 
        {
            get { if (instance == null) instance = new BillInfoDAO(); return BillInfoDAO.instance; }
            private set { BillInfoDAO.instance = value; }
        }
        public List<BillInfo> GetListBillInfos(int tableNum)
        {
          
            List<BillInfo> billInfos = new List<BillInfo>();
            DataTable data = Dataprovider.Instance.ExecuteQuerry("SELECT * FROM BILLINFO WHERE idBill ="+tableNum);
            foreach (DataRow item in data.Rows)
            {
                BillInfo info = new BillInfo(item);
                billInfos.Add(info);
            }   
            return billInfos;
        }
        public void InsertBillInfo(int idTable,string idFood,int count)
        {
            Dataprovider.Instance.ExecuteNonQuery("USP_InsertBillInfo @idBill INT, @idFood CHAR, @count INT",new object[] { idTable,idFood,count });


        }
    }
}
