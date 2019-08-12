using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CrystalCollector
{
    public partial class FrmCrystal : Form
    {
        Graphics g; //declare a graphics object called g
        Collector collector1 = new Collector(); //create the object, collector1
        Amethyst[] amethyst = new Amethyst[5]; //create the object, amethyst
        Citrine[] citrine = new Citrine[5];
        Rosequartz[] rosequartz = new Rosequartz[5];
        Random yspeed = new Random();
        Random xspeed = new Random();
        Random yspeeda = new Random();
        Random xspeeda = new Random();
        Random yspeedb = new Random();
        Random xspeedb = new Random();
        Random spawnx = new Random();
        Random spawny = new Random();
        int score, lives, diffX, diffY,time;
        string collectorName;
        string timelimit;

        public FrmCrystal()
        {
            score = 0;
            InitializeComponent();
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null, PanelGame, new object[] { true });
            for (int i = 0; i < 5; i++)
            {
                int x = 10 + (i * 90);
                amethyst[i] = new Amethyst(x);
                citrine[i] = new Citrine(x);
                rosequartz[i] = new Rosequartz(x);
            }
        }
        private void FrmCrystal_Load(object sender, EventArgs e)
        {
        }

        private void PanelGame_Paint(object sender, PaintEventArgs e)
        {
            //get the graphics used to paint on the panel control
            g = e.Graphics;
            //call the Planet class's DrawCollector method to draw the image collector1 
            collector1.drawCollector(g);
            for (int i = 0; i < 5; i++)
            {
                //call the Amethyst class's drawAmethyst method to draw the images
                amethyst[i].drawAmethyst(g);
                citrine[i].drawCitrine(g);
                rosequartz[i].drawRosequartz(g);
                // generate a random number from 5 to 20 and put it in rndmspeed
                int rndmyspeed = yspeed.Next(1, 5);
                amethyst[i].y += rndmyspeed;
                int rndmyspeeda = yspeeda.Next(1, 5);
                citrine[i].y -= rndmyspeeda;

                int rndmxspeed = xspeed.Next(1, 3);
                amethyst[i].x += rndmxspeed;
                int rndmxspeeda = xspeeda.Next(1, 3);
                citrine[i].x -= rndmxspeeda;
                int rndmxspeedb = xspeedb.Next(1, 5);
                rosequartz[i].x += rndmxspeedb;
            }

        }

        private void PanelGame_MouseMove(object sender, MouseEventArgs e)
        {
            collector1.moveCollector(e.X, e.Y);
        }

        private void tmrCollector_Tick(object sender, EventArgs e)
        {
            PanelGame.Invalidate();
        }

        private void PanelGame_MouseDown_1(object sender, MouseEventArgs e)
        {
            int xplace = spawnx.Next(10, 670);
            int yplace = spawny.Next(10, 460);
            foreach (Amethyst a in amethyst)
            {
                if (collector1.collectorRec.IntersectsWith(a.amethystRec))
                {
                    score++;//add 1 to the score
                    LabelScore.Text = score.ToString();// display the score
                    a.y = 10;
                    a.x = xplace; 
                }
            }
            foreach (Citrine a in citrine)
            {
                if (collector1.collectorRec.IntersectsWith(a.citrineRec))
                {
                    score++;//add 1 to the score
                    LabelScore.Text = score.ToString();// display the score
                    a.y = 450;
                    a.x = xplace;
                }
            }
            foreach (Rosequartz a in rosequartz)
            {
                if (collector1.collectorRec.IntersectsWith(a.roseRec))
                {
                    score++;//add 1 to the score
                    LabelScore.Text = score.ToString();// display the score
                    a.x = 10;
                    a.y = yplace;
                }
            }
        }

        private void Menu_Start_Click(object sender, EventArgs e)
        {
            score = 0;
            tmrCollector.Start();
            TmrAmethyst.Start();
            TmrCitrine.Start();
            TmrRose.Start();
            TmrTime.Enabled = true;


        }

        private void Menu_Stop_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void NameBtn_Click(object sender, EventArgs e)
        {
            collectorName = TextName.Text;
            if (Regex.IsMatch(collectorName, @"^[a-zA-Z]+$"))//checks playerName for letters
            {
                //if playerName valid (only letters) 
                MessageBox.Show("Valid name, you can now start the game.");
            }
            else
            {
                //invalid playerName, clear txtName and focus on it to try again
                MessageBox.Show("NOT VALID. Please enter a name using ONLY letters.");
                TextName.Clear();

                TextName.Focus();

            }

        }

        private void TmrTime_Tick(object sender, EventArgs e)
        {
            time--;
            LblTime.Text = time.ToString();
            
        }

        private void BtnTime_Click(object sender, EventArgs e)
        {
            timelimit = LblTime.Text;           
            time = int.Parse(comboBox1.SelectedIndex);
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void TmrCitrine_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                citrine[i].moveCitrine();
            }
        }

        private void TmrRose_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                rosequartz[i].moveRosequartz();
            }
        }

        private void TmrAmethyst_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                amethyst[i].moveAmethyst();
            }
        }
    }
}
