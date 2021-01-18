namespace QuanLiGiaiVDQG
{
    partial class AddPlayerForm
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
            this.AddPlayerBtn = new System.Windows.Forms.Button();
            this.PlayerNameTextBox = new System.Windows.Forms.TextBox();
            this.AgeTextBox = new System.Windows.Forms.TextBox();
            this.PositionTextBox = new System.Windows.Forms.TextBox();
            this.NoteTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TeamIdTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TyepTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên cầu thủ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tuổi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Vị trí";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ưu điểm:";
            // 
            // AddPlayerBtn
            // 
            this.AddPlayerBtn.Location = new System.Drawing.Point(29, 229);
            this.AddPlayerBtn.Name = "AddPlayerBtn";
            this.AddPlayerBtn.Size = new System.Drawing.Size(181, 30);
            this.AddPlayerBtn.TabIndex = 4;
            this.AddPlayerBtn.Text = "Thêm cầu thủ";
            this.AddPlayerBtn.UseVisualStyleBackColor = true;
            this.AddPlayerBtn.Click += new System.EventHandler(this.AddPlayerBtn_Click);
            // 
            // PlayerNameTextBox
            // 
            this.PlayerNameTextBox.Location = new System.Drawing.Point(116, 12);
            this.PlayerNameTextBox.Name = "PlayerNameTextBox";
            this.PlayerNameTextBox.Size = new System.Drawing.Size(169, 22);
            this.PlayerNameTextBox.TabIndex = 5;
            // 
            // AgeTextBox
            // 
            this.AgeTextBox.Location = new System.Drawing.Point(116, 50);
            this.AgeTextBox.Name = "AgeTextBox";
            this.AgeTextBox.Size = new System.Drawing.Size(169, 22);
            this.AgeTextBox.TabIndex = 6;
            // 
            // PositionTextBox
            // 
            this.PositionTextBox.Location = new System.Drawing.Point(116, 92);
            this.PositionTextBox.Name = "PositionTextBox";
            this.PositionTextBox.Size = new System.Drawing.Size(169, 22);
            this.PositionTextBox.TabIndex = 7;
            // 
            // NoteTextBox
            // 
            this.NoteTextBox.Location = new System.Drawing.Point(116, 142);
            this.NoteTextBox.Name = "NoteTextBox";
            this.NoteTextBox.Size = new System.Drawing.Size(169, 22);
            this.NoteTextBox.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(355, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Id CLB";
            // 
            // TeamIdTextBox
            // 
            this.TeamIdTextBox.Location = new System.Drawing.Point(455, 23);
            this.TeamIdTextBox.Name = "TeamIdTextBox";
            this.TeamIdTextBox.Size = new System.Drawing.Size(176, 22);
            this.TeamIdTextBox.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(355, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Nguồn gốc ";
            // 
            // TyepTextBox
            // 
            this.TyepTextBox.Location = new System.Drawing.Point(455, 55);
            this.TyepTextBox.Name = "TyepTextBox";
            this.TyepTextBox.Size = new System.Drawing.Size(176, 22);
            this.TyepTextBox.TabIndex = 14;
            // 
            // AddPlayerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TyepTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TeamIdTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.NoteTextBox);
            this.Controls.Add(this.PositionTextBox);
            this.Controls.Add(this.AgeTextBox);
            this.Controls.Add(this.PlayerNameTextBox);
            this.Controls.Add(this.AddPlayerBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddPlayerForm";
            this.Text = "AddPlayerForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button AddPlayerBtn;
        private System.Windows.Forms.TextBox PlayerNameTextBox;
        private System.Windows.Forms.TextBox AgeTextBox;
        private System.Windows.Forms.TextBox PositionTextBox;
        private System.Windows.Forms.TextBox NoteTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TeamIdTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TyepTextBox;
    }
}