using QLCAPHE.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCAPHE.DAO
{
    class MenuListDAO
    {
        private static MenuListDAO instance;

        internal static MenuListDAO Instance
        {
            get { if (instance == null) instance = new MenuListDAO(); return MenuListDAO.instance; }
            private set => MenuListDAO.instance = value;
        }
        private MenuListDAO()
        {

        }
        public List<MenuList>GetListMenuByTable(int id)
        {
            List <MenuList>listMenu = new List<MenuList>();
            string query = "SELECT MN.TENSP,MN.HOADON,BI.COUNT,BI.COUNT * MN.HOADON AS [Total Price] FROM BILLINFO AS BI, SHOPTABLE AS ST, BILL AS B , MENU AS MN WHERE BI.idBill=B.id AND BI.idMenu = MN.MASP and B.idTable =" + id;
            DataTable table = Dataprovider.Instance.ExecuteQuerry(query);
            foreach (DataRow item in table.Rows)
            {
                MenuList menu = new MenuList(item);
                listMenu.Add(menu);
            }
            return listMenu;
        }

       
    }
}
