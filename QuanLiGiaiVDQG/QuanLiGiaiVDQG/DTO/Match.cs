using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiGiaiVDQG.DTO
{
    class Match
    {
        private string matchId;
        private string roundFight;
        private string firstTeamId;
        private string secondTeamId;
        private string field;
        private string referee;
        private DateTime matchTime;

        public Match(string matchId, string roundFight, string firstTeamId, string secondTeamId, string field,string referee, DateTime matchTime)
        {
            this.MatchId = matchId;
            this.RoundFight = roundFight;
            this.FirstTeamId = firstTeamId;
            this.SecondTeamId = secondTeamId;
            this.Field = field;
            this.Referee = referee;
            this.MatchTime = matchTime;
        }

        public string MatchId { get => matchId; set => matchId = value; }
        public string RoundFight { get => roundFight; set => roundFight = value; }
        public string FirstTeamId { get => firstTeamId; set => firstTeamId = value; }
        public string SecondTeamId { get => secondTeamId; set => secondTeamId = value; }
        public string Field { get => field; set => field = value; }
        public string Referee { get => referee; set => referee = value; }
        public DateTime MatchTime { get => matchTime; set => matchTime = value; }

        public Match(DataRow row)
        {
            this.MatchId = row["MatchId"].ToString();
            this.RoundFight = row["RoundFight"].ToString();
            this.FirstTeamId = row["FirstTeamId"].ToString();
            this.SecondTeamId = row["SecondTeamId"].ToString();
            this.Referee = row["Ref"].ToString();
            this.MatchTime = (DateTime)row["MatchTime"];
        }
    }
}
