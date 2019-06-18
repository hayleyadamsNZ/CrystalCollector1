using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace CrystalCollector
{
    class Collector
    {
        // declare fields to use in the class
        public int x, y, width, height;//variables for the rectangle
        public Image collectorImage;//variable for the planet's image

        public Rectangle collectorRec;//variable for a rectangle to place our image in

        //Create a constructor (initialises the values of the fields)
        public Collector()
        {
            x = 10;
            y = 10;
            width = 40;
            height = 50;
            collectorImage = Properties.Resources.Collector1;
            collectorRec = new Rectangle(x, y, width, height);
        }
        // Methods for the Collector class
        public void drawCollector(Graphics g)
        {
            g.DrawImage(collectorImage, collectorRec);
        }
        public void moveCollector(int mouseX, int mouseY)
        {
            collectorRec.X = mouseX - (collectorRec.Width/2);
            collectorRec.Y = mouseY - (collectorRec.Height / 2);
        }
    }
}
