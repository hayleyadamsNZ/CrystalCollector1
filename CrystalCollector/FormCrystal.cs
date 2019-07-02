using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
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
        int score, lives;

        public FrmCrystal()
        {
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

        private void PanelGame_MouseHover(object sender, EventArgs e)
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
