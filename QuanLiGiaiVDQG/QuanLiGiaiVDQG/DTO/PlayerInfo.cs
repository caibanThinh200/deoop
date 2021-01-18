using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiGiaiVDQG.DTO
{
    class PlayerInfo
    {
        private int playerId;
        private string playerName;
        private string teamId;
        private int age;
        private string position;
        private string typePlayer;
        private string note;

        public PlayerInfo(int playerId, string playerName, string teamId, int age, string position, string typePlayer, string note)
        {
            this.PlayerId = playerId;
            this.PlayerName = playerName;
            this.TeamId = teamId;
            this.Age = age;
            this.Position = position;
            this.TypePlayer = typePlayer;
            this.Note = note;
        }

        public int PlayerId { get => playerId; set => playerId = value; }
        public string PlayerName { get => playerName; set => playerName = value; }
        public string TeamId { get => teamId; set => teamId = value; }
        public int Age { get => age; set => age = value; }
        public string Position { get => position; set => position = value; }
        public string TypePlayer { get => typePlayer; set => typePlayer = value; }
        public string Note { get => note; set => note = value; }
        public PlayerInfo(DataRow row)
        {
            this.PlayerId =(int)row["PlayerId"];
            this.PlayerName = row["PlayerName"].ToString();
            this.TeamId = row["TeamId"].ToString();
            this.Age = (int)row["Age"];
            this.Position = row["Position"].ToString();
            this.TypePlayer = row["TypePlayer"].ToString();
            this.Note = row["Note"].ToString();
        }
    }
        
}
