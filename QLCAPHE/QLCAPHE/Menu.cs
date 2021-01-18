using QLCAPHE.DAO;
using QLCAPHE.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCAPHE
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            LoadCategory();
            LoadTable();

        }

        private void adminstratorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Adminstrator ad = new Adminstrator();
            ad.ShowDialog();
        }

        private void thongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NhanVienInfo nv = new NhanVienInfo();
            this.Close();
            nv.Show();
        }
        void LoadNV()
        {
            string querry = "SELECT TENSP AS [Tên sản phẩm]  FROM dbo.MENU ";
            Dataprovider provide = new Dataprovider();
            cbMenu.Text = provide.ExecuteQuerry(querry).ToString();


        }
        void LoadCategory()
        {
            List<Category> CateList = CategoryDAO.Instance.GetListCategory();
            cbMenu.DataSource = CateList;
            cbMenu.DisplayMember = "Name";
        }
        void LoadFoodListByCategoryID(int id)
        {
            List<Food> listFood = FoodDAO.Instance.GetFoodByCategoryID(id);
            cbFood.DataSource = listFood;
            cbFood.DisplayMember = "FoodName";
        }
        public void LoadTable()
        {
            List<Table> tablelist = TableDAO.Instance.LoadTableList();
            foreach (Table item in tablelist)
            {
                Button btn = new Button() { Width = TableDAO.TableWidth, Height = TableDAO.TableHeight };
                btn.Text = item.NumTable + Environment.NewLine + item.Sstatic;
                btn.Click += Btn_Click; 
                btn.Tag = item;
                tableFloLayoutPanel.Controls.Add(btn);
                btn.BackColor = Color.Aqua;

            }
        }
      
        void ShowBill(int TableNum)
        {
            int totalPrice = 0;
            ListViewMenu.Items.Clear();
            List<MenuList> menuLists = MenuListDAO.Instance.GetListMenuByTable(TableNum);
            foreach (MenuList item in menuLists)
            {
                ListViewItem listViewItem = new ListViewItem(item.FoodName.ToString());
                listViewItem.SubItems.Add(item.Count.ToString());
                listViewItem.SubItems.Add(item.Price.ToString());
                listViewItem.SubItems.Add(item.TotalPrice.ToString());
                totalPrice += item.TotalPrice;
                ListViewMenu.Items.Add(listViewItem);
            }
            totalPriceTB.Text = totalPrice.ToString() + " VND";
        }
        private void Btn_Click(object sender, EventArgs e)
        {
            int tableID = ((sender as Button).Tag as Table).Id;
            ListViewMenu.Tag = (sender as Button).Tag;
            ShowBill(tableID);
        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            Table table = ListViewMenu.Tag as Table;

            if (table == null)
            {
                MessageBox.Show("Hãy chọn bàn");
                return;
            }

            int idBill = BillDAO.Instance.GetUncheckBillByTableNum(table.Id);
            string foodID = (cbFood.SelectedItem as Food).Id;
            int count = (int)nmCount.Value;

            if (idBill == -1)
            {
                BillDAO.Instance.InsertBill(table.Id);
                BillInfoDAO.Instance.InsertBillInfo(BillDAO.Instance.GetMaxIdBill(), foodID, count);
            }
            else
            {
                BillInfoDAO.Instance.InsertBillInfo(idBill, foodID, count);
            }

            ShowBill(table.Id);

            LoadTable();
        }
          
        private void cbMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0 ;

            ComboBox cb = sender as ComboBox;

            if (cb.SelectedItem == null)
                return;

            Category selected = cb.SelectedItem as Category;
            id = selected.Id;

            LoadFoodListByCategoryID(id);
        }
    }
}
