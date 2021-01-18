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
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
            ListTeam();
        }

      
        public int TeamRow()
        {
            string querry = "SELECT TeamId FROM TeamProfile ORDER BY TeamId DESC";
            DataTable table = DatabaseProvider.Instance.ExcuteQuerry(querry);
            DataRow row = table.Rows[0];
            TeamProfile team = new TeamProfile(row);
            return team.TeamId;
        }
       
       
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string club = clubTextBox.Text.ToString();
                string coach = CoachTextBox.Text.ToString();
                string field = FieldTextBox.Text.ToString();
                string querry = "INSERT INTO TeamProfile(TeamName,Coach,Field) VALUES(N'" + club + "',N'" + coach + "',N'" + field + "')";
                DatabaseProvider.Instance.ExcuteQuerry(querry);

                SignUpForm sign = new SignUpForm();
                this.Hide();
                sign.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Thêm câu lạc bộ thất bại", "Lỗi");
            }
        }
        public void ListTeam()
        {
            string querry = "SELECT * FROM TeamProfile ORDER BY TeamId DESC";
            PlayerDgv.DataSource = DatabaseProvider.Instance.ExcuteQuerry(querry);
        }
        private void homeBtn_Click(object sender, EventArgs e)
        {
            ListTeam list = new ListTeam();
            this.Hide();
            list.Show();
        }

        private void PlayerDgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = PlayerDgv.CurrentRow.Index;
            clubTextBox.Text = PlayerDgv.Rows[i].Cells[1].Value.ToString();
            CoachTextBox.Text = PlayerDgv.Rows[i].Cells[3].Value.ToString();
            FieldTextBox.Text = PlayerDgv.Rows[i].Cells[2].Value.ToString();
        }

        private void DelBtn_Click(object sender, EventArgs e)
        {
            string club = clubTextBox.Text.ToString();
            //string coach = CoachTextBox.Text.ToString();
            //string field = FieldTextBox.Text.ToString();
            string querry = "DELETE FROM TeamProfile WHERE TeamName= '"+club+"'";
            DatabaseProvider.Instance.ExcuteQuerry(querry);
            SignUpForm sign = new SignUpForm();
            this.Hide();
            sign.Show();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {

            string club = clubTextBox.Text.ToString();
            string coach = CoachTextBox.Text.ToString();
            string field = FieldTextBox.Text.ToString();
            try
            {
                string querry = "UPDATE TeamProfile SET TeamName = '" + club + "' ,Field = '" + field + "',Coach = '"+coach+"' WHERE TeamName = '" + club + "'";
                DatabaseProvider.Instance.ExcuteQuerry(querry);
                SignUpForm sign = new SignUpForm();
                this.Hide();
                sign.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Cập nhật thất bại", "Lỗi");
            }
        }
    }
}
