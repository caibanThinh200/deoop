using QuanLiGiaiVDQG.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiGiaiVDQG.DAO
{
    class PlayerDAO
    {
        private static PlayerDAO instance;
        public static PlayerDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new PlayerDAO();
                return PlayerDAO.instance;
            }
            private set
            {
                instance = value;
            }
        }
        public List<PlayerInfo> playerList(int teamId)
        {
            List<PlayerInfo> players = new List<PlayerInfo>();
            string querry = "SELECT * FROM PlayerInfo WHERE TeamId = '" + teamId + "'";
            DataTable tale =  DatabaseProvider.Instance.ExcuteQuerry(querry);
            foreach(DataRow row in tale.Rows)
            {
                PlayerInfo player = new PlayerInfo(row);
                players.Add(player);
            }
            return players;
        }
    }
}
