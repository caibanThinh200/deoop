using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLLopHoc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadTable();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public void LoadTable()
        {
            string qeurry = "SELECT * FROM LOPHOC";
            DataTable table =  Database.Instance.ExcuteQuerry(qeurry);
            classDgv.DataSource = table; 
        }
        private void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string malop = classIdTxb.Text.ToString();
                string tenlop = classNameTxb.Text.ToString();
                string querry = "INSERT INTO LOPHOC(MALOP,TENLOP) VALUES('" + malop + "',N'" + tenlop + "')";
                Database.Instance.ExcuteQuerry(querry);
                MessageBox.Show("Thêm lớp thành công", "Thành công");
                Form1 f = new Form1();
                this.Hide();
                f.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Thêm lớp thất bại", "Lỗi");
            }
        }

        private void classDgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = classDgv.CurrentRow.Index;
            classIdTxb.Text = classDgv.Rows[i].Cells[0].Value.ToString();
            classNameTxb.Text = classDgv.Rows[i].Cells[1].Value.ToString();
            
        }

        private void DelBtn_Click(object sender, EventArgs e)
        {
            string classId = classIdTxb.Text.ToString();
            string className = classNameTxb.Text.ToString();
            string querry = "DELETE FROM LOPHOC WHERE MALOP = '"+classId+"' ";
            Database.Instance.ExcuteQuerry(querry);
            MessageBox.Show("Xóa lớp thất công", "Thành công");
            Form1 f = new Form1();
            this.Hide();
            f.Show();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            string classId = classIdTxb.Text.ToString();
            string className = classNameTxb.Text.ToString();
            string querry = "UPDATE LOPHOC SET TENLOP = N'" + className + "'";
            Database.Instance.ExcuteQuerry(querry);
            MessageBox.Show("Sửa lớp thảnh công", "Thành công");
            Form1 f = new Form1();
            this.Hide();
            f.Show();
        }

        private void SVBtn_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            this.Hide();
            f.Show();
        }
    }
}
