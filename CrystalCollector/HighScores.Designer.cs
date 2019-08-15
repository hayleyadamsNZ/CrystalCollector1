namespace CrystalCollector
{
    partial class HighScores
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
            this.LblPlayerName = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LblPlayerScore = new System.Windows.Forms.Label();
            this.LblMessage = new System.Windows.Forms.Label();
            this.BtnReturn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "NAME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(182, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "SCORE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Player\'s Name";
            // 
            // LblPlayerName
            // 
            this.LblPlayerName.AutoSize = true;
            this.LblPlayerName.Location = new System.Drawing.Point(164, 132);
            this.LblPlayerName.Name = "LblPlayerName";
            this.LblPlayerName.Size = new System.Drawing.Size(35, 13);
            this.LblPlayerName.TabIndex = 3;
            this.LblPlayerName.Text = "Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Player\'s Score";
            // 
            // LblPlayerScore
            // 
            this.LblPlayerScore.AutoSize = true;
            this.LblPlayerScore.Location = new System.Drawing.Point(164, 189);
            this.LblPlayerScore.Name = "LblPlayerScore";
            this.LblPlayerScore.Size = new System.Drawing.Size(35, 13);
            this.LblPlayerScore.TabIndex = 5;
            this.LblPlayerScore.Text = "Score";
            // 
            // LblMessage
            // 
            this.LblMessage.AutoSize = true;
            this.LblMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblMessage.Location = new System.Drawing.Point(54, 239);
            this.LblMessage.Name = "LblMessage";
            this.LblMessage.Size = new System.Drawing.Size(2, 15);
            this.LblMessage.TabIndex = 6;
            // 
            // BtnReturn
            // 
            this.BtnReturn.Location = new System.Drawing.Point(249, 156);
            this.BtnReturn.Name = "BtnReturn";
            this.BtnReturn.Size = new System.Drawing.Size(144, 23);
            this.BtnReturn.TabIndex = 7;
            this.BtnReturn.Text = "Return to Game Form";
            this.BtnReturn.UseVisualStyleBackColor = true;
            // 
            // HighScores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 368);
            this.Controls.Add(this.BtnReturn);
            this.Controls.Add(this.LblMessage);
            this.Controls.Add(this.LblPlayerScore);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LblPlayerName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "HighScores";
            this.Text = "Crystal Collector High Scores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblPlayerName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LblPlayerScore;
        private System.Windows.Forms.Label LblMessage;
        private System.Windows.Forms.Button BtnReturn;
    }
}