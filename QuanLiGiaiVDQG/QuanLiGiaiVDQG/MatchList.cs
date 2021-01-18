using QuanLiGiaiVDQG.DAO;
using QuanLiGiaiVDQG.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiGiaiVDQG
{
    public partial class MatchList : Form
    {
        public MatchList()
        {
            InitializeComponent();
            LoadMatchList();
        }
        public void LoadMatchList()
        {
            List<Match> matchs = MatchDAO.Instance.listMatchs();
            foreach(Match match in matchs)
            {
                Button btn = new Button() { Width = 70, Height = 70 };
                btn.Text =  match.RoundFight + Environment.NewLine + "Team id " + match.FirstTeamId + "vs" + "Team id " + match.SecondTeamId;
                btn.Click += Btn_Click;
                btn.Tag = match;
                MatchListFlowPanel.Controls.Add(btn);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ListTeam list = new ListTeam();
            this.Hide();
            list.Show();
        }
       public void showMatch(string matchId)
        {
            MatchListView.Items.Clear();
            List<Match> matchs = MatchDAO.Instance.MatchInfo(matchId);
            foreach(Match match in matchs)
            {
                ListViewItem ListViewItem = new ListViewItem(match.MatchId);
                ListViewItem.SubItems.Add(match.RoundFight);
                ListViewItem.SubItems.Add(match.FirstTeamId);
                ListViewItem.SubItems.Add(match.SecondTeamId);
                ListViewItem.SubItems.Add(match.Referee);
                ListViewItem.SubItems.Add(match.MatchTime.ToString());
                MatchListView.Items.Add(ListViewItem);
            }
          
        }
        private void Btn_Click(object sender, EventArgs e)
        {
            string MatchId = ((sender as Button).Tag as Match).MatchId;
            MatchListFlowPanel.Tag = (sender as Button).Tag;
            showMatch(MatchId);
        }

        private void ResultBtn_Click(object sender, EventArgs e)
        {
            Result res = new Result();
            this.Hide();
            res.Show();
        }
    }
}
