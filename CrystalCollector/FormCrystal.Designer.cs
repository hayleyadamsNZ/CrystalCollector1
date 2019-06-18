namespace CrystalCollector
{
    partial class FrmCrystal
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
            this.PanelGame = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TextName = new System.Windows.Forms.TextBox();
            this.LabelScore = new System.Windows.Forms.Label();
            this.TextLives = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // PanelGame
            // 
            this.PanelGame.BackColor = System.Drawing.Color.Black;
            this.PanelGame.ForeColor = System.Drawing.Color.Black;
            this.PanelGame.Location = new System.Drawing.Point(2, 192);
            this.PanelGame.Name = "PanelGame";
            this.PanelGame.Size = new System.Drawing.Size(680, 470);
            this.PanelGame.TabIndex = 0;
            this.PanelGame.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelGame_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Orator Std", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(166, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(359, 43);
            this.label1.TabIndex = 1;
            this.label1.Text = "Crystal Collector";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Orator Std", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Collector\'s Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Orator Std", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(339, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Score";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Orator Std", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(563, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Lives";
            // 
            // TextName
            // 
            this.TextName.Font = new System.Drawing.Font("Orator Std", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextName.Location = new System.Drawing.Point(28, 119);
            this.TextName.Name = "TextName";
            this.TextName.Size = new System.Drawing.Size(180, 33);
            this.TextName.TabIndex = 5;
            // 
            // LabelScore
            // 
            this.LabelScore.AutoSize = true;
            this.LabelScore.BackColor = System.Drawing.Color.White;
            this.LabelScore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LabelScore.Font = new System.Drawing.Font("Orator Std", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelScore.Location = new System.Drawing.Point(360, 119);
            this.LabelScore.Name = "LabelScore";
            this.LabelScore.Size = new System.Drawing.Size(25, 27);
            this.LabelScore.TabIndex = 6;
            this.LabelScore.Text = "0";
            // 
            // TextLives
            // 
            this.TextLives.Font = new System.Drawing.Font("Orator Std", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextLives.Location = new System.Drawing.Point(568, 119);
            this.TextLives.Name = "TextLives";
            this.TextLives.Size = new System.Drawing.Size(50, 33);
            this.TextLives.TabIndex = 7;
            // 
            // FrmCrystal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(684, 661);
            this.Controls.Add(this.TextLives);
            this.Controls.Add(this.LabelScore);
            this.Controls.Add(this.TextName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PanelGame);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "FrmCrystal";
            this.Text = "Crystal Collector 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelGame;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TextName;
        private System.Windows.Forms.Label LabelScore;
        private System.Windows.Forms.TextBox TextLives;
    }
}

