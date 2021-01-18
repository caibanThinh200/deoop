using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLLopHoc
{
    class Database
    {
        string db = "Data Source=DESKTOP-IAQE0QO;Initial Catalog=DiemSV;Integrated Security=True";
        private static Database instance;
        public static Database Instance
        {
            get
            {
                if (instance == null)
                    instance = new Database();
                return Database.instance;
            }
            private set
            {
                instance = value;
            }
        }
        public DataTable ExcuteQuerry(string querry)
        {
            DataTable table = new DataTable();
            SqlConnection connect = new SqlConnection(db);
            SqlCommand command = new SqlCommand(querry, connect);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            return table;
        }
    }
}
