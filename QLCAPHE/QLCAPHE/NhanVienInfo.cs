﻿using System;
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
    public partial class NhanVienInfo : Form
    {
        public NhanVienInfo()
        {
            InitializeComponent();
        }

        private void backBTN_Click(object sender, EventArgs e)
        {
            dangNhap signin = new dangNhap();
            this.Close();
            signin.Show();
        }

        private void updateBTN_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            this.Close();
            menu.Show();
        }
    }
}
