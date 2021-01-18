using QuanLiGiaiVDQG.DAO;
using QuanLiGiaiVDQG.DTO;
using System;
using System.Data;
using System.Windows.Forms;

namespace QuanLiGiaiVDQG
{
    public partial class AddPlayerForm : Form
    {
        public AddPlayerForm()
        {
            InitializeComponent();
        }
        public int teamId()
        {
            string querry = "SELECT * FROM TeamProfile ORDER BY TeamId DESC";
            
            DataTable table = DatabaseProvider.Instance.ExcuteQuerry(querry);
            DataRow Row = table.Rows[0];
            TeamProfile team = new TeamProfile(Row);
            
            return team.TeamId;
            
        }
        private void AddPlayerBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var result = MessageBox.Show("Bạn còn muốn thêm cầu thủ chứ ?", "Thêm cầu thủ", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    string playerName = PlayerNameTextBox.Text.ToString();
                    int teamId = int.Parse(TeamIdTextBox.Text.ToString());
                    int age = int.Parse(AgeTextBox.Text);
                    string pos = PositionTextBox.Text.ToString();
                    string type = TyepTextBox.Text.ToString();
                    string note = NoteTextBox.Text.ToString();
                    string querry = "INSERT INTO PlayerInfo(PlayerName,TeamId,Age,Position,TypePlayer,Note) VALUES(N'" + playerName + "','" + teamId + "','" + age + "',N'" + pos + "',N'" + type + "',N'" + note + "')";
                    DatabaseProvider provider = new DatabaseProvider();
                    provider.ExcuteQuerry(querry);
                    AddPlayerForm player = new AddPlayerForm();
                    this.Hide();
                    player.Show();
                }
               
               
                else
                {
                    ListTeam SignUp = new ListTeam();
                    this.Hide();
                    SignUp.Show();
                    string playerName = PlayerNameTextBox.Text.ToString();
                    int teamId = int.Parse(TeamIdTextBox.Text.ToString());
                    int age = int.Parse(AgeTextBox.Text);
                    string pos = PositionTextBox.Text.ToString();
                    string type = TyepTextBox.Text.ToString();
                    string note = NoteTextBox.Text.ToString();
                    string querry = "INSERT INTO PlayerInfo(PlayerName,TeamId,Age,Position,TypePlayer,Note) VALUES(N'" + playerName + "','" + teamId+ "','" + age + "',N'" + pos + "',N'" + type + "',N'" + note + "')";
                    DatabaseProvider provider = new DatabaseProvider();
                    provider.ExcuteQuerry(querry);
                }
            }catch (Exception)
            {
                MessageBox.Show("Thêm cầu thủ thất bại ", "Lỗi");
            }
         }
    }
}
