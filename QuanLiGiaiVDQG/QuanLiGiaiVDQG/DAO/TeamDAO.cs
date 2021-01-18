using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLiGiaiVDQG.DTO;
     

namespace QuanLiGiaiVDQG.DAO
{
    class TeamDAO
    {
        private static TeamDAO instance;
        public static TeamDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new TeamDAO();
                return TeamDAO.instance;
            }
            private set
            {
                instance = value;
            }
        }
        public List<TeamProfile> listTeam()
        {
            List<TeamProfile> listTeam = new List<TeamProfile>();
            string querry = "SELECT * FROM TeamProfile";
            DataTable table=  DatabaseProvider.Instance.ExcuteQuerry(querry);
            foreach(DataRow item in table.Rows)
            {
                TeamProfile team = new TeamProfile(item);
                listTeam.Add(team);
            }
            return listTeam;
        }

    }
}
