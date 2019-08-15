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
            this.components = new System.ComponentModel.Container();
            this.PanelGame = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TextName = new System.Windows.Forms.TextBox();
            this.LabelScore = new System.Windows.Forms.Label();
            this.tmrCollector = new System.Windows.Forms.Timer(this.components);
            this.TmrAmethyst = new System.Windows.Forms.Timer(this.components);
            this.TmrCitrine = new System.Windows.Forms.Timer(this.components);
            this.TmrRose = new System.Windows.Forms.Timer(this.components);
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.Menu_Start = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Stop = new System.Windows.Forms.ToolStripMenuItem();
            this.NameBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.LblTime = new System.Windows.Forms.Label();
            this.TmrTime = new System.Windows.Forms.Timer(this.components);
            this.BtnTime = new System.Windows.Forms.Button();
            this.TxtTime = new System.Windows.Forms.TextBox();
            this.TmrDodge = new System.Windows.Forms.Timer(this.components);
            this.BtnScores = new System.Windows.Forms.Button();
            this.Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelGame
            // 
            this.PanelGame.BackColor = System.Drawing.Color.Black;
            this.PanelGame.Cursor = System.Windows.Forms.Cursors.Default;
            this.PanelGame.ForeColor = System.Drawing.Color.Black;
            this.PanelGame.Location = new System.Drawing.Point(2, 192);
            this.PanelGame.Name = "PanelGame";
            this.PanelGame.Size = new System.Drawing.Size(680, 470);
            this.PanelGame.TabIndex = 0;
            this.PanelGame.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelGame_Paint);
            this.PanelGame.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelGame_MouseDown_1);
            this.PanelGame.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelGame_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Orator Std", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 43);
            this.label1.TabIndex = 1;
            this.label1.Text = "Crystal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Orator Std", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(224, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Collector\'s Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Orator Std", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(274, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Score";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Orator Std", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(473, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(199, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Time (30, 60, 90)";
            // 
            // TextName
            // 
            this.TextName.Font = new System.Drawing.Font("Orator Std", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextName.Location = new System.Drawing.Point(229, 52);
            this.TextName.Name = "TextName";
            this.TextName.Size = new System.Drawing.Size(112, 33);
            this.TextName.TabIndex = 5;
            this.TextName.TextChanged += new System.EventHandler(this.TextName_TextChanged);
            // 
            // LabelScore
            // 
            this.LabelScore.AutoSize = true;
            this.LabelScore.BackColor = System.Drawing.Color.White;
            this.LabelScore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LabelScore.Font = new System.Drawing.Font("Orator Std", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelScore.Location = new System.Drawing.Point(347, 137);
            this.LabelScore.Name = "LabelScore";
            this.LabelScore.Size = new System.Drawing.Size(25, 27);
            this.LabelScore.TabIndex = 6;
            this.LabelScore.Text = "0";
            // 
            // tmrCollector
            // 
            this.tmrCollector.Interval = 10;
            this.tmrCollector.Tick += new System.EventHandler(this.tmrCollector_Tick);
            // 
            // TmrAmethyst
            // 
            this.TmrAmethyst.Tick += new System.EventHandler(this.TmrAmethyst_Tick);
            // 
            // TmrCitrine
            // 
            this.TmrCitrine.Tick += new System.EventHandler(this.TmrCitrine_Tick);
            // 
            // TmrRose
            // 
            this.TmrRose.Tick += new System.EventHandler(this.TmrRose_Tick);
            // 
            // Menu
            // 
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_Start,
            this.Menu_Stop});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(684, 24);
            this.Menu.TabIndex = 8;
            this.Menu.Text = "Menu";
            // 
            // Menu_Start
            // 
            this.Menu_Start.Name = "Menu_Start";
            this.Menu_Start.Size = new System.Drawing.Size(43, 20);
            this.Menu_Start.Text = "Start";
            this.Menu_Start.Click += new System.EventHandler(this.Menu_Start_Click);
            // 
            // Menu_Stop
            // 
            this.Menu_Stop.Name = "Menu_Stop";
            this.Menu_Stop.Size = new System.Drawing.Size(42, 20);
            this.Menu_Stop.Text = "Quit";
            this.Menu_Stop.Click += new System.EventHandler(this.Menu_Stop_Click);
            // 
            // NameBtn
            // 
            this.NameBtn.BackColor = System.Drawing.Color.Black;
            this.NameBtn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameBtn.ForeColor = System.Drawing.Color.White;
            this.NameBtn.Location = new System.Drawing.Point(347, 52);
            this.NameBtn.Name = "NameBtn";
            this.NameBtn.Size = new System.Drawing.Size(65, 33);
            this.NameBtn.TabIndex = 9;
            this.NameBtn.Text = "Submit";
            this.NameBtn.UseVisualStyleBackColor = false;
            this.NameBtn.Click += new System.EventHandler(this.NameBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Orator Std", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(-6, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(199, 43);
            this.label5.TabIndex = 10;
            this.label5.Text = "Collector";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Orator Std", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(481, 141);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 21);
            this.label7.TabIndex = 15;
            this.label7.Text = "Time Left";
            // 
            // LblTime
            // 
            this.LblTime.AutoSize = true;
            this.LblTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblTime.Font = new System.Drawing.Font("Orator Std", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTime.ForeColor = System.Drawing.Color.Black;
            this.LblTime.Location = new System.Drawing.Point(587, 137);
            this.LblTime.Name = "LblTime";
            this.LblTime.Size = new System.Drawing.Size(25, 27);
            this.LblTime.TabIndex = 16;
            this.LblTime.Text = "-";
            // 
            // TmrTime
            // 
            this.TmrTime.Interval = 1000;
            this.TmrTime.Tick += new System.EventHandler(this.TmrTime_Tick);
            // 
            // BtnTime
            // 
            this.BtnTime.BackColor = System.Drawing.Color.Black;
            this.BtnTime.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTime.ForeColor = System.Drawing.Color.White;
            this.BtnTime.Location = new System.Drawing.Point(587, 52);
            this.BtnTime.Name = "BtnTime";
            this.BtnTime.Size = new System.Drawing.Size(65, 33);
            this.BtnTime.TabIndex = 17;
            this.BtnTime.Text = "Ok";
            this.BtnTime.UseVisualStyleBackColor = false;
            this.BtnTime.Click += new System.EventHandler(this.BtnTime_Click);
            // 
            // TxtTime
            // 
            this.TxtTime.Font = new System.Drawing.Font("Orator Std", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTime.Location = new System.Drawing.Point(481, 52);
            this.TxtTime.Name = "TxtTime";
            this.TxtTime.Size = new System.Drawing.Size(100, 33);
            this.TxtTime.TabIndex = 18;
            // 
            // TmrDodge
            // 
            this.TmrDodge.Tick += new System.EventHandler(this.TmrDodge_Tick);
            // 
            // BtnScores
            // 
            this.BtnScores.BackColor = System.Drawing.Color.Black;
            this.BtnScores.Font = new System.Drawing.Font("Orator Std", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnScores.ForeColor = System.Drawing.Color.White;
            this.BtnScores.Location = new System.Drawing.Point(12, 150);
            this.BtnScores.Name = "BtnScores";
            this.BtnScores.Size = new System.Drawing.Size(181, 36);
            this.BtnScores.TabIndex = 19;
            this.BtnScores.Text = "High Score List";
            this.BtnScores.UseVisualStyleBackColor = false;
            this.BtnScores.Click += new System.EventHandler(this.BtnScores_Click);
            // 
            // FrmCrystal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(684, 661);
            this.Controls.Add(this.BtnScores);
            this.Controls.Add(this.TxtTime);
            this.Controls.Add(this.BtnTime);
            this.Controls.Add(this.LblTime);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.NameBtn);
            this.Controls.Add(this.LabelScore);
            this.Controls.Add(this.TextName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PanelGame);
            this.Controls.Add(this.Menu);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Black;
            this.MainMenuStrip = this.Menu;
            this.Name = "FrmCrystal";
            this.Text = "Crystal Collector 1";
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
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
        private System.Windows.Forms.Timer tmrCollector;
        private System.Windows.Forms.Timer TmrAmethyst;
        private System.Windows.Forms.Timer TmrCitrine;
        private System.Windows.Forms.Timer TmrRose;
        private System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem Menu_Start;
        private System.Windows.Forms.ToolStripMenuItem Menu_Stop;
        private System.Windows.Forms.Button NameBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label LblTime;
        private System.Windows.Forms.Timer TmrTime;
        private System.Windows.Forms.Button BtnTime;
        private System.Windows.Forms.TextBox TxtTime;
        private System.Windows.Forms.Timer TmrDodge;
        private System.Windows.Forms.Button BtnScores;
    }
}

