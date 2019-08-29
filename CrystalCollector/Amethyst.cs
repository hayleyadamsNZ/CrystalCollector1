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
        public Image amethystImage;//variable for the amethyst's image

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
        // Methods for the Amethyst class
        public void drawAmethyst(Graphics g)
        {
            amethystRec = new Rectangle(x, y, width, height);
            g.DrawImage(amethystImage, amethystRec);
        }
        public void moveAmethyst()
        {
            amethystRec.Location = new Point(x, y);
            if (amethystRec.Location.Y > 470) //If amethyst's y position is more than 470 then reposition to y = 20
            {
                y = 20;
                amethystRec.Location = new Point(x, y);
            }
            if (amethystRec.Location.X > 680) //If amethyst's x position is more than 680 then reposition at x = 20
            {
                x = 20;
                amethystRec.Location = new Point(x, y);
            }
        }
    }
}
