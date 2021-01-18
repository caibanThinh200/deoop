using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiGiaiVDQG.DAO
{
    class DatabaseProvider
    {
        private static DatabaseProvider instance;
        private string databaseString = "Data Source=DESKTOP-IAQE0QO;Initial Catalog=GiaiVoDichQuocGia;Integrated Security=True";
        internal static DatabaseProvider Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new DatabaseProvider();
                }
                return instance;
            }
            set
            {
                instance = value;
            }
        }
        public DataTable ExcuteQuerry(string querry)
        {
            DataTable data = new DataTable();
            using (SqlConnection connection = new SqlConnection(databaseString))
            {
                data.Clear();
                connection.Open();
                SqlCommand command = new SqlCommand(querry, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
                connection.Close();

            }
            return data;
        }
    }
}
