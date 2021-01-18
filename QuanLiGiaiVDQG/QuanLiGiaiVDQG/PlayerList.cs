using QuanLiGiaiVDQG.DAO;
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
    public partial class PlayerList : Form
    {
        public PlayerList()
        {
            InitializeComponent();
            LoadPlayer();
        }

      public void LoadPlayer()
        {
            string querry = "SELECT PlayerId , PlayerName ,TeamName,Goal,Age,TypePlayer FROM PlayerInfo, TeamProfile WHERE PLayerInfo.TeamId = TeamProfile.TeamId ORDER BY Goal DESC";
            DatabaseProvider data = new DatabaseProvider();
            PlayerDgv.DataSource = data.ExcuteQuerry(querry);
        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            ListTeam list = new ListTeam();
            this.Hide();
            list.Show();
        }
    }
}
