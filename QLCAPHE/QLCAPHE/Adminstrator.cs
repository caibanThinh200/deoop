using QLCAPHE.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCAPHE
{
    public partial class Adminstrator : Form
    {
        public Adminstrator()
        {
            InitializeComponent();
            LoadData();
            LoadMenu();
            LoadKPI();
        }
        void LoadData()
        {
            string querry = "SELECT MANV AS [Mã nhân viên],TENNV AS[Tên nhân viên], NGAYSINH AS [Ngày sinh],GIOITINH AS[Giới tính],LUONG AS[Lương],VITRI AS [Vị trí] FROM NVINFO";
            Dataprovider provide = new Dataprovider();
            nhanVienDgv.DataSource= provide.ExecuteQuerry(querry);
        }
        void LoadMenu()
        {
            string querry = "SELECT MASP AS[Mã sản phẩm],TENSP AS [Tên sản phẩm] ,HOADON AS [Hóa đơn],THELOAI AS [Thể loại]  FROM dbo.MENU";
            Dataprovider provide = new Dataprovider();
            menuDGV.DataSource = provide.ExecuteQuerry(querry);

        }
        void LoadKPI()
        {
            string querry = " SELECT TONGKPI AS[Tổng doanh thu], KPIMOMO AS[Doanh thu MoMo],KPIVISA AS[Doanh thu visa], KPICASH AS[Doanh thu tiền mặt] FROM DOANHTHU";

            Dataprovider provide = new Dataprovider();
            doanhthuDgv.DataSource = provide.ExecuteQuerry(querry);
        }

        private void tabNhanVien_Click(object sender, EventArgs e)
        {

        }

        private void nhanVienDgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
            string query = "INSERT NVINFO(MANV,TENNV,VITRI) VALUES('"+NVIDTB.Text+"','"+NVNameTB.Text+"','"+vitriTB.Text+"')";
            nhanVienDgv.DataSource = Dataprovider.Instance.ExecuteQuerry(query);
            LoadData();
        }

        private void addBTN_Click(object sender, EventArgs e)
        {
          //  string query = "INSERT MENU (MASP,TENSP,HOADON,THELOAI,IDCATEGORY) VALUES('"+maSPtb.Text+"','"+SPnameTB.Text+"','"+priceTB.Text+"',
        }
    }
}

           
           