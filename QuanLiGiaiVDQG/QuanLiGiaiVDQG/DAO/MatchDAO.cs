using QuanLiGiaiVDQG.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiGiaiVDQG.DAO
{
    class MatchDAO
    {
        private static MatchDAO instance; 
        public static MatchDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new MatchDAO();
                return MatchDAO.instance;
            }
            private set
            {
                instance = value;
            }
        }
        public List<Match> MatchInfo(string MatchId)
        {
            List<Match> list = new List<Match>();
            string querry = "SELECT * FROM Match WHERE MatchId = '"+MatchId+"'";
            DataTable table = DatabaseProvider.Instance.ExcuteQuerry(querry);
            foreach(DataRow matchItem in table.Rows)
            {
                Match match = new Match(matchItem);
                list.Add(match);
            }
            return list;
        }
        public List<Match> listMatchs()
        {
            List<Match> list = new List<Match>();
            string querry = "SELECT * FROM Match ";
            DataTable table = DatabaseProvider.Instance.ExcuteQuerry(querry);
            foreach (DataRow matchItem in table.Rows)
            {
                Match match = new Match(matchItem);
                list.Add(match);
            }
            return list;
        }
    }
}
