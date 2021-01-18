namespace QuanLiGiaiVDQG
{
    partial class SignUpForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.clubTextBox = new System.Windows.Forms.TextBox();
            this.FieldTextBox = new System.Windows.Forms.TextBox();
            this.CoachTextBox = new System.Windows.Forms.TextBox();
            this.AddPlayerBtn = new System.Windows.Forms.Button();
            this.homeBtn = new System.Windows.Forms.Button();
            this.PlayerDgv = new System.Windows.Forms.DataGridView();
            this.UpdateBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên clb:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên sân:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "HLV:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(344, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Danh sách câu lạc bộ:";
            // 
            // clubTextBox
            // 
            this.clubTextBox.Location = new System.Drawing.Point(77, 23);
            this.clubTextBox.Name = "clubTextBox";
            this.clubTextBox.Size = new System.Drawing.Size(175, 22);
            this.clubTextBox.TabIndex = 4;
            this.clubTextBox.TabStop = false;
            // 
            // FieldTextBox
            // 
            this.FieldTextBox.Location = new System.Drawing.Point(77, 66);
            this.FieldTextBox.Name = "FieldTextBox";
            this.FieldTextBox.Size = new System.Drawing.Size(175, 22);
            this.FieldTextBox.TabIndex = 5;
            // 
            // CoachTextBox
            // 
            this.CoachTextBox.Location = new System.Drawing.Point(77, 110);
            this.CoachTextBox.Name = "CoachTextBox";
            this.CoachTextBox.Size = new System.Drawing.Size(175, 22);
            this.CoachTextBox.TabIndex = 6;
            // 
            // AddPlayerBtn
            // 
            this.AddPlayerBtn.Location = new System.Drawing.Point(358, 379);
            this.AddPlayerBtn.Name = "AddPlayerBtn";
            this.AddPlayerBtn.Size = new System.Drawing.Size(135, 34);
            this.AddPlayerBtn.TabIndex = 8;
            this.AddPlayerBtn.Text = "Thêm câu lạc bộ";
            this.AddPlayerBtn.UseVisualStyleBackColor = true;
            this.AddPlayerBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // homeBtn
            // 
            this.homeBtn.Location = new System.Drawing.Point(15, 379);
            this.homeBtn.Name = "homeBtn";
            this.homeBtn.Size = new System.Drawing.Size(193, 34);
            this.homeBtn.TabIndex = 9;
            this.homeBtn.Text = "Chuyển sang danh sách clb";
            this.homeBtn.UseVisualStyleBackColor = true;
            this.homeBtn.Click += new System.EventHandler(this.homeBtn_Click);
            // 
            // PlayerDgv
            // 
            this.PlayerDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PlayerDgv.Location = new System.Drawing.Point(347, 66);
            this.PlayerDgv.Name = "PlayerDgv";
            this.PlayerDgv.RowHeadersWidth = 51;
            this.PlayerDgv.RowTemplate.Height = 24;
            this.PlayerDgv.Size = new System.Drawing.Size(410, 273);
            this.PlayerDgv.TabIndex = 10;
            this.PlayerDgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PlayerDgv_CellContentClick);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Location = new System.Drawing.Point(584, 379);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(128, 34);
            this.UpdateBtn.TabIndex = 12;
            this.UpdateBtn.Text = "Cập nhật câu lạc bộ";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // SignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.PlayerDgv);
            this.Controls.Add(this.homeBtn);
            this.Controls.Add(this.AddPlayerBtn);
            this.Controls.Add(this.CoachTextBox);
            this.Controls.Add(this.FieldTextBox);
            this.Controls.Add(this.clubTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SignUpForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PlayerDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox clubTextBox;
        private System.Windows.Forms.TextBox FieldTextBox;
        private System.Windows.Forms.TextBox CoachTextBox;
        private System.Windows.Forms.Button AddPlayerBtn;
        private System.Windows.Forms.Button homeBtn;
        private System.Windows.Forms.DataGridView PlayerDgv;
        private System.Windows.Forms.Button UpdateBtn;
    }
}

