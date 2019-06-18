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
        private Image collectorImage;//variable for the planet's image

        private Rectangle collectorRec;//variable for a rectangle to place our image in

        //Create a constructor (initialises the values of the fields)
        public Collector()
        {
            x = 10;
            y = 10;
            width = 20;
            height = 20;
            collectorImage = Properties.Resources.Collector1;
            collectorRec = new Rectangle(x, y, width, height);
        }
        // Methods for the Planet class
        public void drawPlanet(Graphics g)
        {
            g.DrawImage(collectorImage, collectorRec);
        }
    }
}
