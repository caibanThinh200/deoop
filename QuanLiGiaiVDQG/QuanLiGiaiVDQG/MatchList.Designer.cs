namespace QuanLiGiaiVDQG
{
    partial class MatchList
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
            this.MatchListFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.MatchListView = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MatchId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RoundFight = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FirstTeamId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SecondTeamId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Referee = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MatchTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ResultBtn = new System.Windows.Forms.Button();
            this.TeamListBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MatchListFlowPanel
            // 
            this.MatchListFlowPanel.Location = new System.Drawing.Point(31, 49);
            this.MatchListFlowPanel.Name = "MatchListFlowPanel";
            this.MatchListFlowPanel.Size = new System.Drawing.Size(433, 377);
            this.MatchListFlowPanel.TabIndex = 0;
            // 
            // MatchListView
            // 
            this.MatchListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MatchId,
            this.RoundFight,
            this.FirstTeamId,
            this.SecondTeamId,
            this.Referee,
            this.MatchTime});
            this.MatchListView.HideSelection = false;
            this.MatchListView.Location = new System.Drawing.Point(470, 49);
            this.MatchListView.Name = "MatchListView";
            this.MatchListView.Size = new System.Drawing.Size(330, 267);
            this.MatchListView.TabIndex = 0;
            this.MatchListView.UseCompatibleStateImageBehavior = false;
            this.MatchListView.View = System.Windows.Forms.View.Details;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Danh sách trận đấu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(478, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Thông tin trận đấu";
            // 
            // MatchId
            // 
            this.MatchId.Text = "ID Trận đấu";
            // 
            // RoundFight
            // 
            this.RoundFight.Text = "Vòng đấu";
            // 
            // FirstTeamId
            // 
            this.FirstTeamId.Text = "Id đội bóng 1";
            // 
            // SecondTeamId
            // 
            this.SecondTeamId.Text = "ID đội bóng 2";
            // 
            // Referee
            // 
            this.Referee.Text = "Trọng tài";
            // 
            // MatchTime
            // 
            this.MatchTime.Text = "Thời gian trận đấu";
            // 
            // ResultBtn
            // 
            this.ResultBtn.Location = new System.Drawing.Point(463, 323);
            this.ResultBtn.Name = "ResultBtn";
            this.ResultBtn.Size = new System.Drawing.Size(140, 103);
            this.ResultBtn.TabIndex = 3;
            this.ResultBtn.Text = "Kết quả trận đấu";
            this.ResultBtn.UseVisualStyleBackColor = true;
            this.ResultBtn.Click += new System.EventHandler(this.ResultBtn_Click);
            // 
            // TeamListBtn
            // 
            this.TeamListBtn.Location = new System.Drawing.Point(665, 323);
            this.TeamListBtn.Name = "TeamListBtn";
            this.TeamListBtn.Size = new System.Drawing.Size(135, 103);
            this.TeamListBtn.TabIndex = 4;
            this.TeamListBtn.Text = "Quay về danh sách câu lạc bộ";
            this.TeamListBtn.UseVisualStyleBackColor = true;
            this.TeamListBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // MatchList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TeamListBtn);
            this.Controls.Add(this.ResultBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MatchListView);
            this.Controls.Add(this.MatchListFlowPanel);
            this.Name = "MatchList";
            this.Text = "MatchList";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel MatchListFlowPanel;
        private System.Windows.Forms.ListView MatchListView;
        private System.Windows.Forms.ColumnHeader MatchId;
        private System.Windows.Forms.ColumnHeader RoundFight;
        private System.Windows.Forms.ColumnHeader FirstTeamId;
        private System.Windows.Forms.ColumnHeader SecondTeamId;
        private System.Windows.Forms.ColumnHeader Referee;
        private System.Windows.Forms.ColumnHeader MatchTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ResultBtn;
        private System.Windows.Forms.Button TeamListBtn;
    }
}