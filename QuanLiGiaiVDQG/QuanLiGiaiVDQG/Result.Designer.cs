namespace QuanLiGiaiVDQG
{
    partial class Result
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
            this.Team1TextBox = new System.Windows.Forms.TextBox();
            this.Team2TextBox = new System.Windows.Forms.TextBox();
            this.FieldTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.confirmBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.RefTxb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.matchDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đội 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Đội 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sân đấu:";
            // 
            // Team1TextBox
            // 
            this.Team1TextBox.Location = new System.Drawing.Point(138, 61);
            this.Team1TextBox.Name = "Team1TextBox";
            this.Team1TextBox.Size = new System.Drawing.Size(126, 22);
            this.Team1TextBox.TabIndex = 3;
            // 
            // Team2TextBox
            // 
            this.Team2TextBox.Location = new System.Drawing.Point(138, 117);
            this.Team2TextBox.Name = "Team2TextBox";
            this.Team2TextBox.Size = new System.Drawing.Size(126, 22);
            this.Team2TextBox.TabIndex = 4;
            // 
            // FieldTextBox
            // 
            this.FieldTextBox.Location = new System.Drawing.Point(138, 176);
            this.FieldTextBox.Name = "FieldTextBox";
            this.FieldTextBox.Size = new System.Drawing.Size(126, 22);
            this.FieldTextBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(315, 23);
            this.label4.MaximumSize = new System.Drawing.Size(500, 500);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Kết quả trận đấu";
            // 
            // confirmBtn
            // 
            this.confirmBtn.Location = new System.Drawing.Point(514, 61);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.Size = new System.Drawing.Size(207, 47);
            this.confirmBtn.TabIndex = 7;
            this.confirmBtn.Text = "Xác nhận ";
            this.confirmBtn.UseVisualStyleBackColor = true;
            this.confirmBtn.Click += new System.EventHandler(this.confirmBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Trọng tài";
            // 
            // RefTxb
            // 
            this.RefTxb.Location = new System.Drawing.Point(138, 233);
            this.RefTxb.Name = "RefTxb";
            this.RefTxb.Size = new System.Drawing.Size(126, 22);
            this.RefTxb.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 287);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Thời gian trận đấu";
            // 
            // matchDateTimePicker
            // 
            this.matchDateTimePicker.Location = new System.Drawing.Point(138, 287);
            this.matchDateTimePicker.Name = "matchDateTimePicker";
            this.matchDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.matchDateTimePicker.TabIndex = 11;
            // 
            // Result
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.matchDateTimePicker);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.RefTxb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.confirmBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.FieldTextBox);
            this.Controls.Add(this.Team2TextBox);
            this.Controls.Add(this.Team1TextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Result";
            this.Text = "Result";
           // this.Load += new System.EventHandler(this.Result_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Team1TextBox;
        private System.Windows.Forms.TextBox Team2TextBox;
        private System.Windows.Forms.TextBox FieldTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button confirmBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox RefTxb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker matchDateTimePicker;
    }
}