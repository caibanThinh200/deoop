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
    public partial class Result : Form
    {
        public Result()
        {
            InitializeComponent();
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int idteam1 = int.Parse(Team1TextBox.Text);
                int idteam2 = int.Parse(Team2TextBox.Text);
                string field = FieldTextBox.Text.ToString();
                string refer = RefTxb.Text.ToString();
                string matchTime = matchDateTimePicker.ToString();
                string querry = "INSERT INTO Result(ScoreFirstTeamId,ScoreSecondTeamId,PlayerScoreId,MatchTime) VALUES('" + idteam1 + "','" + idteam2 + "','" + field + "','" + refer + "','" + matchTime + "')";
                DatabaseProvider.Instance.ExcuteQuerry(querry);
                MessageBox.Show("Kết quả trận đấu đã được  lưu", "Xác nhận");
            }
            catch (Exception)
            {
                MessageBox.Show("Lưu trận đấu thất bại", "Lỗi");
            }
        }

        
    }
}
