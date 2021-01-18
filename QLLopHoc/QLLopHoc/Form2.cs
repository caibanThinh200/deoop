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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            LoadTable();
        }
        public void LoadTable()
        {
            string querry = "SELECT * FROM SinhVien";
            
        
            string id = idSvTxb.Text.ToString();
           
            dsSVdgv.DataSource = Database.Instance.ExcuteQuerry(querry);
           

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dsSVdgv.CurrentRow.Index;
            nameSvTxb.Text = dsSVdgv.Rows[i].Cells[0].Value.ToString();
            idSvTxb.Text = dsSVdgv.Rows[i].Cells[1].Value.ToString();
            ageTxb.Text = dsSVdgv.Rows[i].Cells[0].Value.ToString();
            adrTxb.Text = dsSVdgv.Rows[i].Cells[3].Value.ToString();
            idClassTxb.Text = dsSVdgv.Rows[i].Cells[4].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = idSvTxb.Text.ToString();
            string name = nameSvTxb.Text.ToString();
            string age = ageTxb.Text.ToString();
            string addr = adrTxb.Text.ToString();
            string classid = idClassTxb.Text.ToString();
            int diemGK = int.Parse(dgktxb.Text.ToString());
            int diemCK = int.Parse(dcktxb.Text.ToString());
            int diemCong = int.Parse(dcongtxb.Text.ToString());
            int diemTB = 0;
            string khoa = khoaTxb.Text.ToString();
           if(khoa == "Ngoai ngu")
            {
                diemTB = (diemGK * 4 + diemCK * 6 + diemCong) / 10;
            }
           if(khoa == "CNTT")
            {
                diemTB = (diemGK * 3 + diemCK * 5 + diemCong * 2) / 10;
            }
                
            
               
            string querry = "INSERT INTO SinhVien(maSv,tenSv,diachi,tuoi,maLop,diemGK,diemCK,diemCong,diemTB,Khoa) VALUES('" + id + "',N'" + name + "',N'" + addr + "','" + age + "','" + classid + "','" + diemGK+ "','" + diemCK + "','" + diemCong + "','" + diemTB+ "','" +khoa + "')";
            Database.Instance.ExcuteQuerry(querry);
            Form2 f = new Form2();
            this.Hide();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void seachBtn_Click(object sender, EventArgs e)
        {
            string id = idSvTxb.Text.ToString();
            string querry = "SELECT * FROM SinhVien where maSv = '" + id + "'";
           
            DiemSVdgv.DataSource = Database.Instance.ExcuteQuerry(querry);
            DiemSVdgv.Refresh();
          
        }
    }
}
