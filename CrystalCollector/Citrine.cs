﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace CrystalCollector
{
    class Citrine
    {
        // declare fields to use in the class
        public int x, y, width, height;//variables for the rectangle
        public Image citrineImage;//variable for the citrine's image

        public Rectangle citrineRec;//variable for a rectangle to place our image in
        public int score;
        //Create a constructor (initialises the values of the fields)

        public Citrine(int spacing)
        {
            x = spacing;
            y = 450;
            width = 20;
            height = 20;
            citrineImage = Image.FromFile("yellow.png");
            citrineRec = new Rectangle(x, y, width, height);
        }
        // Methods for the Citrine class
        public void drawCitrine(Graphics g)
        {
            citrineRec = new Rectangle(x, y, width, height);
            g.DrawImage(citrineImage, citrineRec);
        }
        public void moveCitrine()
        {
            citrineRec.Location = new Point(x, y);
            if (citrineRec.Location.Y < 1) //If citrine's y position is less than 1 then repositon to y = 450
            {
                y = 450;
                citrineRec.Location = new Point(x, y);
            }
            if (citrineRec.Location.X < 1) //If citrine's x position is less than 1 then reposition to x = 670
            {
                x = 670;
                citrineRec.Location = new Point(x, y);
            }
        }
    }
}
