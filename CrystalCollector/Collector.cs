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
        public int score;
        //Create a constructor (initialises the values of the fields)
        public Collector()
        {
            x = 10;
            y = 10;
            width = 20;
            height = 20;
            collectorImage = Image.FromFile("Collector1.png");
            collectorRec = new Rectangle(x, y, width, height);
        }

    }
}
