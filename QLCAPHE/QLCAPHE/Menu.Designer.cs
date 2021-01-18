namespace QLCAPHE
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.nmCount = new System.Windows.Forms.NumericUpDown();
            this.panel2 = new System.Windows.Forms.Panel();
            this.delBTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.addFoodBTN = new System.Windows.Forms.Button();
            this.cbFood = new System.Windows.Forms.ComboBox();
            this.cbMenu = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.totalPriceTB = new System.Windows.Forms.MaskedTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBillBTN = new System.Windows.Forms.Button();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.listView1 = new System.Windows.Forms.ListView();
            this.ListViewMenu = new System.Windows.Forms.ListView();
            this.FoodName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.count = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel4 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.backBTN = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adminstratorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableFloLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.nmCount)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nmCount
            // 
            this.nmCount.Location = new System.Drawing.Point(265, 34);
            this.nmCount.Name = "nmCount";
            this.nmCount.Size = new System.Drawing.Size(120, 22);
            this.nmCount.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.delBTN);
            this.panel2.Controls.Add(this.nmCount);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.addFoodBTN);
            this.panel2.Controls.Add(this.cbFood);
            this.panel2.Controls.Add(this.cbMenu);
            this.panel2.Location = new System.Drawing.Point(455, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(437, 62);
            this.panel2.TabIndex = 2;
            // 
            // delBTN
            // 
            this.delBTN.Location = new System.Drawing.Point(339, 3);
            this.delBTN.Name = "delBTN";
            this.delBTN.Size = new System.Drawing.Size(98, 23);
            this.delBTN.TabIndex = 5;
            this.delBTN.Text = "Xóa";
            this.delBTN.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(265, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Số lượng ";
            // 
            // addFoodBTN
            // 
            this.addFoodBTN.Location = new System.Drawing.Point(174, 5);
            this.addFoodBTN.Name = "addFoodBTN";
            this.addFoodBTN.Size = new System.Drawing.Size(85, 53);
            this.addFoodBTN.TabIndex = 2;
            this.addFoodBTN.Text = "Thêm món";
            this.addFoodBTN.UseVisualStyleBackColor = true;
            // 
            // cbFood
            // 
            this.cbFood.FormattingEnabled = true;
            this.cbFood.Location = new System.Drawing.Point(0, 34);
            this.cbFood.Name = "cbFood";
            this.cbFood.Size = new System.Drawing.Size(168, 24);
            this.cbFood.TabIndex = 1;
            // 
            // cbMenu
            // 
            this.cbMenu.FormattingEnabled = true;
            this.cbMenu.Location = new System.Drawing.Point(0, 4);
            this.cbMenu.Name = "cbMenu";
            this.cbMenu.Size = new System.Drawing.Size(168, 24);
            this.cbMenu.TabIndex = 0;
            this.cbMenu.SelectedIndexChanged += new System.EventHandler(this.cbMenu_SelectedIndexChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.totalPriceTB);
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.checkBillBTN);
            this.panel3.Location = new System.Drawing.Point(455, 349);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(437, 100);
            this.panel3.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(203, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tổng tiền";
            // 
            // totalPriceTB
            // 
            this.totalPriceTB.Location = new System.Drawing.Point(101, 23);
            this.totalPriceTB.Name = "totalPriceTB";
            this.totalPriceTB.Size = new System.Drawing.Size(170, 22);
            this.totalPriceTB.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(95, 22);
            this.textBox1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Coupon khuyến mãi";
            // 
            // checkBillBTN
            // 
            this.checkBillBTN.Location = new System.Drawing.Point(277, 3);
            this.checkBillBTN.Name = "checkBillBTN";
            this.checkBillBTN.Size = new System.Drawing.Size(160, 97);
            this.checkBillBTN.TabIndex = 4;
            this.checkBillBTN.Text = "Thanh toán";
            this.checkBillBTN.UseVisualStyleBackColor = true;
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(150, 150);
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(150, 175);
            this.toolStripContainer1.TabIndex = 0;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(-16, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(437, 275);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // ListViewMenu
            // 
            this.ListViewMenu.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.FoodName,
            this.count,
            this.Price,
            this.columnHeader1});
            this.ListViewMenu.GridLines = true;
            this.ListViewMenu.HideSelection = false;
            this.ListViewMenu.Location = new System.Drawing.Point(455, 64);
            this.ListViewMenu.Name = "ListViewMenu";
            this.ListViewMenu.Size = new System.Drawing.Size(437, 279);
            this.ListViewMenu.TabIndex = 3;
            this.ListViewMenu.UseCompatibleStateImageBehavior = false;
            this.ListViewMenu.View = System.Windows.Forms.View.Details;
            // 
            // FoodName
            // 
            this.FoodName.Text = "Món ăn";
            // 
            // count
            // 
            this.count.Text = "Số lượng";
            this.count.Width = 86;
            // 
            // Price
            // 
            this.Price.Text = "Price";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Thành tiền";
            this.columnHeader1.Width = 92;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button3);
            this.panel4.Controls.Add(this.button2);
            this.panel4.Controls.Add(this.button1);
            this.panel4.Location = new System.Drawing.Point(458, 400);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(268, 46);
            this.panel4.TabIndex = 4;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(181, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 43);
            this.button3.TabIndex = 2;
            this.button3.Text = "Tiền mặt";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(90, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 43);
            this.button2.TabIndex = 1;
            this.button2.Text = "Visa";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 43);
            this.button1.TabIndex = 0;
            this.button1.Text = "MoMo";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // backBTN
            // 
            this.backBTN.Location = new System.Drawing.Point(300, 0);
            this.backBTN.Name = "backBTN";
            this.backBTN.Size = new System.Drawing.Size(75, 28);
            this.backBTN.TabIndex = 0;
            this.backBTN.Text = "Back";
            this.backBTN.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminstratorToolStripMenuItem,
            this.thôngTinTàiKhoảnToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(449, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adminstratorToolStripMenuItem
            // 
            this.adminstratorToolStripMenuItem.Name = "adminstratorToolStripMenuItem";
            this.adminstratorToolStripMenuItem.Size = new System.Drawing.Size(110, 24);
            this.adminstratorToolStripMenuItem.Text = "Adminstrator";
            this.adminstratorToolStripMenuItem.Click += new System.EventHandler(this.adminstratorToolStripMenuItem_Click);
            // 
            // thôngTinTàiKhoảnToolStripMenuItem
            // 
            this.thôngTinTàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thongToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.thôngTinTàiKhoảnToolStripMenuItem.Name = "thôngTinTàiKhoảnToolStripMenuItem";
            this.thôngTinTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(151, 24);
            this.thôngTinTàiKhoảnToolStripMenuItem.Text = "Thông tin tài khoản";
            // 
            // thongToolStripMenuItem
            // 
            this.thongToolStripMenuItem.Name = "thongToolStripMenuItem";
            this.thongToolStripMenuItem.Size = new System.Drawing.Size(210, 26);
            this.thongToolStripMenuItem.Text = "Thông tin cá nhân";
            this.thongToolStripMenuItem.Click += new System.EventHandler(this.thongToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(210, 26);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            // 
            // tableFloLayoutPanel
            // 
            this.tableFloLayoutPanel.Location = new System.Drawing.Point(3, 30);
            this.tableFloLayoutPanel.Name = "tableFloLayoutPanel";
            this.tableFloLayoutPanel.Size = new System.Drawing.Size(443, 419);
            this.tableFloLayoutPanel.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableFloLayoutPanel);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Controls.Add(this.backBTN);
            this.panel1.Location = new System.Drawing.Point(0, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(449, 449);
            this.panel1.TabIndex = 1;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 450);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.ListViewMenu);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)(this.nmCount)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

            }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addFoodBTN;
        private System.Windows.Forms.ComboBox cbFood;
        private System.Windows.Forms.ComboBox cbMenu;
        private System.Windows.Forms.NumericUpDown nmCount;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button checkBillBTN;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ListView ListViewMenu;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button delBTN;
        private System.Windows.Forms.Button backBTN;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adminstratorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinTàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thongToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel tableFloLayoutPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox totalPriceTB;
        private System.Windows.Forms.ColumnHeader FoodName;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.ColumnHeader count;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}

       