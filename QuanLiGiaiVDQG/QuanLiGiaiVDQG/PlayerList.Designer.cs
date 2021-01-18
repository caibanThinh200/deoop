namespace QuanLiGiaiVDQG
{
    partial class PlayerList
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
            this.PlayerDgv = new System.Windows.Forms.DataGridView();
            this.HomeBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(134, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "BẢNG XẾP HẠNG CẦU THỦ ";
            // 
            // PlayerDgv
            // 
            this.PlayerDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PlayerDgv.Location = new System.Drawing.Point(53, 79);
            this.PlayerDgv.Name = "PlayerDgv";
            this.PlayerDgv.RowHeadersWidth = 51;
            this.PlayerDgv.RowTemplate.Height = 24;
            this.PlayerDgv.Size = new System.Drawing.Size(708, 300);
            this.PlayerDgv.TabIndex = 2;
            // 
            // HomeBtn
            // 
            this.HomeBtn.Location = new System.Drawing.Point(53, 397);
            this.HomeBtn.Name = "HomeBtn";
            this.HomeBtn.Size = new System.Drawing.Size(159, 41);
            this.HomeBtn.TabIndex = 3;
            this.HomeBtn.Text = "Quay về trang chủ";
            this.HomeBtn.UseVisualStyleBackColor = true;
            this.HomeBtn.Click += new System.EventHandler(this.HomeBtn_Click);
            // 
            // PlayerList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.HomeBtn);
            this.Controls.Add(this.PlayerDgv);
            this.Controls.Add(this.label1);
            this.Name = "PlayerList";
            this.Text = "PlayerList";
            ((System.ComponentModel.ISupportInitialize)(this.PlayerDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView PlayerDgv;
        private System.Windows.Forms.Button HomeBtn;
    }
}