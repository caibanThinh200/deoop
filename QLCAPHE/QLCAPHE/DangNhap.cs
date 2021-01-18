using QLCAPHE.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCAPHE
{
    public partial class dangNhap : Form
    {
        public dangNhap()
        {
            InitializeComponent();
        }

        private void signInBTN_Click(object sender, EventArgs e)
        {
            string userName = IDTextBox.Text;
            string Password = PassTextBox.Text;
            if (Login(userName, Password))
            {
              Menu nv = new Menu();
                this.Hide();
                nv.Show();
            }
            else
                MessageBox.Show("Tên tài khoản hoặc mật khẩu không đúng", "Lỗi");
        }
        bool Login(string userName, string password)
        {
            return AccountDAO.Instance.Login(userName,password);
        }

        private void dangNhap_Load(object sender, EventArgs e)
        {

        }

     
    }
}
