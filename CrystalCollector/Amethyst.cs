using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace CrystalCollector
{
    class Amethyst
    {
        // declare fields to use in the class
        public int x, y, width, height;//variables for the rectangle
        public Image amethystImage;//variable for the planet's image

        public Rectangle amethystRec;//variable for a rectangle to place our image in
        public int score;
        //Create a constructor (initialises the values of the fields)
        public Amethyst(int spacing)
        {
            x = spacing;
            y = 10;
            width = 20;
            height = 20;
            amethystImage = Image.FromFile("purple.png");
            amethystRec = new Rectangle(x, y, width, height);
        }
        // Methods for the Planet class
        public void drawAmethyst(Graphics g)
        {
            amethystRec = new Rectangle(x, y, width, height);
            g.DrawImage(amethystImage, amethystRec);
        }
        public void moveAmethyst()
        {
            y += 5;
            amethystRec.Location = new Point(x, y);
            if (amethystRec.Location.Y > 470)
            {
                y = 20;
                amethystRec.Location = new Point(x, y);
            }

        }
    }
}
