using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiGiaiVDQG.DTO
{
    class TeamProfile
    {
        private int teamId;
        private string teamName;
        private string field;
        private int playerId;
        private int win;
        private int loss;
        private int tie;
        private int totalScore;

        public int TeamId { get => teamId; set => teamId = value; }
        public string TeamName { get => teamName; set => teamName = value; }
        public string Field { get => field; set => field = value; }
        public int PlayerId { get => playerId; set => playerId = value; }
        public int Win { get => win; set => win = value; }
        public int Loss { get => loss; set => loss = value; }
        public int Tie { get => tie; set => tie = value; }
        public int TotalScore { get => totalScore; set => totalScore = value; }
  
        public TeamProfile(int teamId, string teamName, string field, int playerId, int win, int loss, int tie, int totalScore)
        {
            this.teamId = teamId;
            this.teamName = teamName;
            this.field = field;
            this.playerId = playerId;
            this.win = win;
            this.loss = loss;
            this.tie = tie;
            this.totalScore = totalScore;
        }
        public TeamProfile(DataRow row)
        {
            this.TeamId = (int)row["TeamId"];
            this.TeamName = row["TeamName"].ToString();
            this.Field = row["Field"].ToString();
           
            this.Win = (int)row["Win"];
            this.Tie = (int)row["Loss"];
            this.TotalScore = (int)row["Tie"];
        }
    }
}
