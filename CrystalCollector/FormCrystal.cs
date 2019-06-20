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
        Amethyst[] amethyst = new Amethyst[7]; //create the object, amethyst
        Random yspeed = new Random();
        int score, lives;

        public FrmCrystal()
        {
            InitializeComponent();
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null, PanelGame, new object[] { true });
            for (int i = 0; i < 7; i++)
            {
                int x = 10 + (i * 55);
                amethyst[i] = new Amethyst(x);
            }
        }

        private void PanelGame_Paint(object sender, PaintEventArgs e)
        {
            //get the graphics used to paint on the panel control
            g = e.Graphics;
            //call the Planet class's DrawCollector method to draw the image collector1 
            collector1.drawCollector(g);
            for (int i = 0; i < 7; i++)
            {
                // generate a random number from 5 to 20 and put it in rndmspeed
                int rndmspeed = yspeed.Next(1, 5);
                amethyst[i].y += rndmspeed;
                //call the Amethyst class's drawAmethyst method to draw the images
                amethyst[i].drawAmethyst(g);
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

        private void TmrAmethyst_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 7; i++)
            {
                amethyst[i].moveAmethyst();
            }
            PanelGame.Invalidate();//makes the paint event fire to redraw the panel
        }
    }
}
