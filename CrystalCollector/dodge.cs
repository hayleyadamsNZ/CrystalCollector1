using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace CrystalCollector
{
    class Dodge
    {
        // declare fields to use in the class
        public int x, y, width, height;//variables for the rectangle
        public Image dodgeImage;//variable for the planet's image

        public Rectangle dodgeRec;//variable for a rectangle to place our image in
        public int score;
        //Create a constructor (initialises the values of the fields)

        public Dodge(int spacing)
        {
            x = 650;
            y = spacing;
            width = 20;
            height = 20;
            dodgeImage = Image.FromFile("blue.png");
            dodgeRec = new Rectangle(x, y, width, height);
        }
        // Methods for the Planet class
        public void drawDodge(Graphics g)
        {
            dodgeRec = new Rectangle(x, y, width, height);
            g.DrawImage(dodgeImage, dodgeRec);
        }
        public void moveDodge()
        {
            dodgeRec.Location = new Point(x, y);
            if (dodgeRec.Location.Y < 1)
            {
                y = 450;
                dodgeRec.Location = new Point(x, y);
            }
            if (dodgeRec.Location.X < 1)
            {
                x = 670;
                dodgeRec.Location = new Point(x, y);
            }

        }
    }
}
