using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiGiaiVDQG.DTO
{
    class Result
    {
        private string matchId;
        private string scoreFirstTeamPlayerId;
        private string scoreSecondTeamPlayerId;
        private string playerScoreId;

        public Result(string matchId, string scoreFirstTeamPlayerId, string scoreSecondTeamPlayerId, string playerScoreId)
        {
            this.MatchId = matchId;
            this.ScoreFirstTeamPlayerId = scoreFirstTeamPlayerId;
            this.ScoreSecondTeamPlayerId = scoreSecondTeamPlayerId;
            this.PlayerScoreId = playerScoreId;
        }

        public string MatchId { get => matchId; set => matchId = value; }
        public string ScoreFirstTeamPlayerId { get => scoreFirstTeamPlayerId; set => scoreFirstTeamPlayerId = value; }
        public string ScoreSecondTeamPlayerId { get => scoreSecondTeamPlayerId; set => scoreSecondTeamPlayerId = value; }
        public string PlayerScoreId { get => playerScoreId; set => playerScoreId = value; }
        public Result(DataRow row)
        {
            this.MatchId = row["MatchId"].ToString();
            this.ScoreFirstTeamPlayerId = row["ScoreFirstTeamPlayerId"].ToString();
            this.ScoreSecondTeamPlayerId = row["ScoreSecondTeamPlayerId"].ToString();
            this.PlayerScoreId = row["PlayerScoreId"].ToString();
        }
    }
}
