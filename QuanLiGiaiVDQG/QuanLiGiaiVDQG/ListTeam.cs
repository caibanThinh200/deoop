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
    public partial class ListTeam : Form
    {
        public ListTeam()
        {
            InitializeComponent();
            LoadTeamList();
        }
        public void LoadTeamList()
        {
            List<TeamProfile> teamList = TeamDAO.Instance.listTeam();
            foreach(TeamProfile team in teamList)
            {
                Button btn = new Button() { Width = 70, Height = 70 };
                btn.Text = team.TeamId + Environment.NewLine + team.TeamName;
                btn.Click += Btn_Click;             
                btn.Tag = team;
                ListTeamFlowLayoutPanel.Controls.Add(btn);
            }
        }
        private void Btn_Click(object sender, EventArgs e)
        {
            int TeamId = ((sender as Button).Tag as TeamProfile).TeamId;
            ListTeamFlowLayoutPanel.Tag = (sender as Button).Tag;
            showPlayer(TeamId);
        }
        public void showPlayer(int playerId)
        {
            PlayerListView.Items.Clear();
            List<PlayerInfo> playerList = PlayerDAO.Instance.playerList(playerId);
            foreach(PlayerInfo player in playerList)
            {
                ListViewItem ListViewItem = new ListViewItem(player.PlayerName.ToString());
                ListViewItem.SubItems.Add(player.PlayerId.ToString());
                ListViewItem.SubItems.Add(player.Position.ToString());
                ListViewItem.SubItems.Add(player.TypePlayer.ToString());
                ListViewItem.SubItems.Add(player.Note.ToString());
                PlayerListView.Items.Add(ListViewItem);
            }
        }

        private void AddPlayerBtn_Click(object sender, EventArgs e)
        {
            AddPlayerForm player = new AddPlayerForm();
            this.Hide();
            player.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PlayerList list = new PlayerList();
            this.Hide();
            list.Show();
        }

        private void MatchSetUpBtn_Click(object sender, EventArgs e)
        {
            MatchForm form = new MatchForm();
            this.Hide();
            form.Show();
        }
    }
}
