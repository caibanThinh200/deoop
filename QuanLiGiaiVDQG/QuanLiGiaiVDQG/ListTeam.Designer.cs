namespace QuanLiGiaiVDQG
{
    partial class ListTeam
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
            this.ListTeamFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.PlayerListView = new System.Windows.Forms.ListView();
            this.PlayerName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PlayerId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TeamId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Country = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AddPlayerBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.MatchSetUpBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(326, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH SÁCH CÂU LẠC BỘ";
            // 
            // ListTeamFlowLayoutPanel
            // 
            this.ListTeamFlowLayoutPanel.Location = new System.Drawing.Point(12, 47);
            this.ListTeamFlowLayoutPanel.Name = "ListTeamFlowLayoutPanel";
            this.ListTeamFlowLayoutPanel.Size = new System.Drawing.Size(348, 391);
            this.ListTeamFlowLayoutPanel.TabIndex = 1;
            // 
            // PlayerListView
            // 
            this.PlayerListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.PlayerName,
            this.PlayerId,
            this.TeamId,
            this.Country});
            this.PlayerListView.HideSelection = false;
            this.PlayerListView.Location = new System.Drawing.Point(366, 47);
            this.PlayerListView.Name = "PlayerListView";
            this.PlayerListView.Size = new System.Drawing.Size(409, 326);
            this.PlayerListView.TabIndex = 2;
            this.PlayerListView.UseCompatibleStateImageBehavior = false;
            this.PlayerListView.View = System.Windows.Forms.View.Details;
            // 
            // PlayerName
            // 
            this.PlayerName.Text = "Tên cầu thủ";
            // 
            // PlayerId
            // 
            this.PlayerId.Text = "ID cầu thủ";
            // 
            // TeamId
            // 
            this.TeamId.Text = "ID Đội bóng";
            // 
            // Country
            // 
            this.Country.Text = "Quê quán";
            // 
            // AddPlayerBtn
            // 
            this.AddPlayerBtn.Location = new System.Drawing.Point(366, 379);
            this.AddPlayerBtn.Name = "AddPlayerBtn";
            this.AddPlayerBtn.Size = new System.Drawing.Size(144, 59);
            this.AddPlayerBtn.TabIndex = 3;
            this.AddPlayerBtn.Text = "Thêm cầu thủ";
            this.AddPlayerBtn.UseVisualStyleBackColor = true;
            this.AddPlayerBtn.Click += new System.EventHandler(this.AddPlayerBtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(516, 379);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 59);
            this.button1.TabIndex = 4;
            this.button1.Text = "Bảng xếp hạng cầu thủ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MatchSetUpBtn
            // 
            this.MatchSetUpBtn.Location = new System.Drawing.Point(652, 379);
            this.MatchSetUpBtn.Name = "MatchSetUpBtn";
            this.MatchSetUpBtn.Size = new System.Drawing.Size(123, 59);
            this.MatchSetUpBtn.TabIndex = 5;
            this.MatchSetUpBtn.Text = "Xếp lịch trận đấu";
            this.MatchSetUpBtn.UseVisualStyleBackColor = true;
            this.MatchSetUpBtn.Click += new System.EventHandler(this.MatchSetUpBtn_Click);
            // 
            // ListTeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MatchSetUpBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AddPlayerBtn);
            this.Controls.Add(this.PlayerListView);
            this.Controls.Add(this.ListTeamFlowLayoutPanel);
            this.Controls.Add(this.label1);
            this.Name = "ListTeam";
            this.Text = "ListTeam";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel ListTeamFlowLayoutPanel;
        private System.Windows.Forms.ListView PlayerListView;
        private System.Windows.Forms.Button AddPlayerBtn;
        private System.Windows.Forms.ColumnHeader PlayerName;
        private System.Windows.Forms.ColumnHeader PlayerId;
        private System.Windows.Forms.ColumnHeader TeamId;
        private System.Windows.Forms.ColumnHeader Country;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button MatchSetUpBtn;
    }
}