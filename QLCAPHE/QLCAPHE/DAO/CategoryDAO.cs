using QLCAPHE.DAO;
using QLCAPHE.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCAPHE
{
    class CategoryDAO
    {
        private static CategoryDAO instance;

        public static CategoryDAO Instance
        {
            get { if (instance == null) instance = new CategoryDAO(); return CategoryDAO.instance; }
            private set { CategoryDAO.instance = value; }
        }
        public List<Category> GetListCategory()
        {
            List<Category> list = new List<Category>();

            string query = "select * from FOODCATEGORY";

            DataTable data = Dataprovider.Instance.ExecuteQuerry(query);

            foreach (DataRow item in data.Rows)
            {
                Category category = new Category(item);
                list.Add(category);
            }

            return list;
        }
    }
}

