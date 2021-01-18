namespace QLLopHoc
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.classIdTxb = new System.Windows.Forms.TextBox();
            this.classNameTxb = new System.Windows.Forms.TextBox();
            this.AddBtn = new System.Windows.Forms.Button();
            this.DelBtn = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.classDgv = new System.Windows.Forms.DataGridView();
            this.SVBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.classDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã lớp:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên lớp:";
            // 
            // classIdTxb
            // 
            this.classIdTxb.Location = new System.Drawing.Point(103, 21);
            this.classIdTxb.Name = "classIdTxb";
            this.classIdTxb.Size = new System.Drawing.Size(227, 22);
            this.classIdTxb.TabIndex = 2;
            // 
            // classNameTxb
            // 
            this.classNameTxb.Location = new System.Drawing.Point(103, 54);
            this.classNameTxb.Name = "classNameTxb";
            this.classNameTxb.Size = new System.Drawing.Size(227, 22);
            this.classNameTxb.TabIndex = 3;
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(34, 106);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(75, 35);
            this.AddBtn.TabIndex = 4;
            this.AddBtn.Text = "Thêm ";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // DelBtn
            // 
            this.DelBtn.Location = new System.Drawing.Point(143, 106);
            this.DelBtn.Name = "DelBtn";
            this.DelBtn.Size = new System.Drawing.Size(75, 35);
            this.DelBtn.TabIndex = 5;
            this.DelBtn.Text = "Xóa";
            this.DelBtn.UseVisualStyleBackColor = true;
            this.DelBtn.Click += new System.EventHandler(this.DelBtn_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Location = new System.Drawing.Point(255, 106);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(75, 35);
            this.UpdateBtn.TabIndex = 6;
            this.UpdateBtn.Text = "Sửa";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // classDgv
            // 
            this.classDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.classDgv.Location = new System.Drawing.Point(28, 161);
            this.classDgv.Name = "classDgv";
            this.classDgv.RowHeadersWidth = 51;
            this.classDgv.RowTemplate.Height = 24;
            this.classDgv.Size = new System.Drawing.Size(746, 277);
            this.classDgv.TabIndex = 7;
            this.classDgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.classDgv_CellContentClick);
            // 
            // SVBtn
            // 
            this.SVBtn.Location = new System.Drawing.Point(537, 20);
            this.SVBtn.Name = "SVBtn";
            this.SVBtn.Size = new System.Drawing.Size(237, 121);
            this.SVBtn.TabIndex = 8;
            this.SVBtn.Text = "Quản lí sinh viên";
            this.SVBtn.UseVisualStyleBackColor = true;
            this.SVBtn.Click += new System.EventHandler(this.SVBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SVBtn);
            this.Controls.Add(this.classDgv);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.DelBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.classNameTxb);
            this.Controls.Add(this.classIdTxb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.classDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox classIdTxb;
        private System.Windows.Forms.TextBox classNameTxb;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button DelBtn;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.DataGridView classDgv;
        private System.Windows.Forms.Button SVBtn;
    }
}

