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
    public partial class MatchForm : Form
    {
        public MatchForm()
        {
            InitializeComponent();
        }

        private void PlayMatchBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int firstTeamId = int.Parse(FirstTeamTextBox.Text.ToString());
                int secondTeamId = int.Parse(SecondTeamIdTextBox.Text.ToString());
                DateTime date = MatchdateTimePicker.Value;
                string round = RoundTextBox.Text.ToString();
                string referee = RefTextBox.Text.ToString();
                string field = FieldTextBox.Text.ToString();
                string querry = "INSERT INTO Match(RoundFight,FirstTeamId,SecondTeamId,MatchTime,Ref,Field) VALUES(N'" + round + "',N'" + firstTeamId + "',N'" + secondTeamId + "',N'" + date + "',N'" + referee + "',N'" + field + "')";
                DatabaseProvider.Instance.ExcuteQuerry(querry);
                if (firstTeamId == secondTeamId)
                {
                    MessageBox.Show("Hai đội không được trùng nhau", "Lỗi sắp xếp");
                }
                else
                {
                    DatabaseProvider.Instance.ExcuteQuerry(querry);
                    MatchForm form = new MatchForm();
                    this.Hide();
                    form.Show();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Thiết lập trận đấu thất bại", "Lỗi");

            }
           
        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            ListTeam list = new ListTeam();
            this.Hide();
            list.Show();
        }

        private void MatchListBtn_Click(object sender, EventArgs e)
        {
            MatchList list = new MatchList();
            this.Hide();
            list.Show();
        }
    }
}
