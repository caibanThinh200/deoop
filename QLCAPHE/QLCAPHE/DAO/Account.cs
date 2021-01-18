using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCAPHE.DAO
{
    class AccountDAO
    {
        private static AccountDAO instance;

        internal static AccountDAO Instance 
        {
          get { if (instance == null) instance = new AccountDAO(); return instance; }
          private  set => instance = value;
        }
        private AccountDAO()
        {

        } 
        public bool Login(string userName, string password)
        {
            string querry = "SELECT MANV,PASS  FROM dbo.NVINFO WHERE MANV = N'"+userName+"' AND PASS =N'"+password+ "'";
            DataTable result = Dataprovider.Instance.ExecuteQuerry(querry);
            return result.Rows.Count > 0;
        }

        
    }
}
