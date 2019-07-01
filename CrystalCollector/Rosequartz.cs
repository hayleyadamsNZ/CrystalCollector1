﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace CrystalCollector
{
    class Rosequartz
    {
        // declare fields to use in the class
        public int x, y, width, height;//variables for the rectangle
        public Image roseImage;//variable for the planet's image

        public Rectangle roseRec;//variable for a rectangle to place our image in
        public int score;
        //Create a constructor (initialises the values of the fields)

        public Rosequartz(int spacing)
        {
            x = spacing;
            y = 450;
            width = 20;
            height = 20;
            roseImage = Image.FromFile("pink.png");
            roseRec = new Rectangle(x, y, width, height);
        }
        // Methods for the Planet class
        public void drawCitrine(Graphics g)
        {
            roseRec = new Rectangle(x, y, width, height);
            g.DrawImage(roseImage, roseRec);
        }
        public void moveCitrine()
        {
            roseRec.Location = new Point(x, y);
            if (roseRec.Location.Y < 1)
            {
                y = 450;
                roseRec.Location = new Point(x, y);
            }
            if (roseRec.Location.X < 1)
            {
                x = 670;
                roseRec.Location = new Point(x, y);
            }
        }
    }
}