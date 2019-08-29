using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CrystalCollector
{
    public partial class FrmCrystal : Form
    {
        Graphics g; //declare a graphics object called g
        Collector collector1 = new Collector(); //create the object, collector1
        Amethyst[] amethyst = new Amethyst[4]; //create 4 objects within each class
        Citrine[] citrine = new Citrine[4]; 
        Dodge[] dodge = new Dodge[4];
        Rosequartz[] rosequartz = new Rosequartz[4];
        Random yspeed = new Random(); //declare that the following terms are values which are calculated randomly
        Random xspeed = new Random();
        Random yspeeda = new Random();
        Random xspeeda = new Random();
        Random yspeedb = new Random();
        Random xspeedb = new Random();
        Random yspeedc = new Random();
        Random xspeedc = new Random();
        Random spawnx = new Random();
        Random spawny = new Random();
        int score, lives, diffX, diffY,time; //declare integers
        string collectorName; 
        string timelimit;

        public FrmCrystal()
        {
            score = 0; //score is initially set to 0
            InitializeComponent();
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null, PanelGame, new object[] { true }); //stops game panel from buffering
            for (int i = 0; i < 4; i++)
            {
                int x = 10 + (i * 90);
                amethyst[i] = new Amethyst(x);
                citrine[i] = new Citrine(x);
                rosequartz[i] = new Rosequartz(x);
                dodge[i] = new Dodge(x);
            }
        }
        private void FrmCrystal_Load(object sender, EventArgs e)
        {
            time = int.Parse(TxtTime.Text); //time entered into txtTime is converted to an integer
            MessageBox.Show("Welcome to Crystal Collector!!! How To Play: You will need to click as many of the crystals (Amethyst, Citrine and Rosequartz) as you can while dodging the dirtpiles! For every crystal you collect, you will gain 1 point. For each dirtpile you hit, you will lose 3 points. You are able to choose your time limit for the game, either 20, 40 or 60 seconds. Enjoy!"); //Message is shown
        }

        private void PanelGame_Paint(object sender, PaintEventArgs e)
        {//get the graphics used to paint on the panel control
            g = e.Graphics;
            //call the COllector's class's DrawCollector method to draw the image collector1 
            collector1.drawCollector(g);
            for (int i = 0; i < 4; i++)
            {
                //call the Amethyst class's drawAmethyst method to draw the images
                amethyst[i].drawAmethyst(g);
                citrine[i].drawCitrine(g);
                rosequartz[i].drawRosequartz(g);
                dodge[i].drawDodge(g);
                // generate a random number between set limits and put in rndmspeed(a,b,c)
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
                int rndmxspeedc = xspeedc.Next(1, 3);
                dodge[i].x -= rndmxspeedc;
            }

        }

        private void PanelGame_MouseMove(object sender, MouseEventArgs e)
        {
            collector1.moveCollector(e.X, e.Y); //Mouse moves collector freely around game panel
        }

        private void tmrCollector_Tick(object sender, EventArgs e)
        {
            PanelGame.Invalidate(); //Constantly checking game panel
        }

        private void PanelGame_MouseDown_1(object sender, MouseEventArgs e)
        {
            int xplace = spawnx.Next(10, 670); //xplace is a random value between 10 and 670
            int yplace = spawny.Next(10, 460); //yplace is a random value between 10 and 460
            foreach (Amethyst a in amethyst) //For each amethyst object within the amethyst array
            {
                if (collector1.collectorRec.IntersectsWith(a.amethystRec)) //If the collector's rectangle hits the amethyst object's rectangle
                {
                    score++;//add 1 to the score
                    LabelScore.Text = score.ToString();// display the score in the score label
                    a.y = 10; //reposition to y = 10
                    a.x = xplace; //repositin to xplace (a random value between 10 and 670)
                    checkTime(); //Check whether time has reached 0
                }
            }
            foreach (Citrine a in citrine)
            {
                if (collector1.collectorRec.IntersectsWith(a.citrineRec)) //If the collector's rectangle hits the citrine object's rectangle
                {
                    score++;//add 1 to the score
                    LabelScore.Text = score.ToString();// display the score in the score label
                    a.y = 450; //reposition to y = 450
                    a.x = xplace; //respostion to xplace (a random value between 10 and 670)
                    checkTime(); //Check whetehr time has reached 0
                }
            }
            foreach (Rosequartz a in rosequartz)
            {
                if (collector1.collectorRec.IntersectsWith(a.roseRec)) //If the collector's rectangle hits the rosequartz object's rectangle
                {
                    score++;//add 1 to the score
                    LabelScore.Text = score.ToString();// display the score in the score label
                    a.x = 10; //reposition to x = 10
                    a.y = yplace; //repostion to yplace (a random value between 10 and 460)
                    checkTime(); //Check whether time has reached 0
                }
            }
        }

        private void Menu_Start_Click(object sender, EventArgs e)
        {
            if (TextName.Enabled == false && TxtTime.Enabled == false) //Check if both TextName and TxtTime are disabled (Will disable if valid input has been entered)
            {
                score = 0; //set score to 0
                tmrCollector.Enabled = true; //Enable all timers in order to start the game
                TmrAmethyst.Enabled = true;
                TmrCitrine.Enabled = true;
                TmrRose.Enabled = true;
                TmrTime.Enabled = true;
                TmrDodge.Enabled = true;
            }
        }

        private void Menu_Stop_Click(object sender, EventArgs e)
        {
            Application.Exit(); //Close application
        }

        private void NameBtn_Click(object sender, EventArgs e)
        {
            collectorName = TextName.Text; //collectorname is the text entered into the TextName textbox
            if (Regex.IsMatch(collectorName, @"^[a-zA-Z]+$"))//checks if collectorName only consists of letters
            {
                //if playerName valid (only letters) 
                TxtTime.Focus(); //Focus on player's next input which is TxtTime
                TextName.Enabled = false; //disable textbox and therefore can not be changed
            }
            else
            {
                //invalid playerName, clear TextName and focus on it to retry
                MessageBox.Show("NOT VALID. Please enter a name using ONLY letters.");
                TextName.Clear();

                TextName.Focus(); //Focus on TextName input

            }


        }

        private void TmrTime_Tick(object sender, EventArgs e)
        {
            time--; //Decrease score by 1
            LblTime.Text = time.ToString(); //Display updated score on LblTime
            checkTime(); //Check if time has reached 0
        }

        private void BtnTime_Click(object sender, EventArgs e)
        {
            timelimit = TxtTime.Text; //timelimit is the value entered into the TxtTime textbox

            if (TxtTime.Text == "20") //if player has entered the number 20
            {
                time = 20; //Set time to 20
                LblTime.Text = time.ToString(); //Display time in LblTime
                TxtTime.Enabled = false; //Disable textbox, therefore valid and can not be edited
            }
            if (TxtTime.Text == "40") //if player has entered the number 40
            {
                time = 40; //set time to 40
                LblTime.Text = time.ToString(); //Display time in LblTime
                TxtTime.Enabled = false; //Disable textbox, therefore valid and can not be edited
            }
            if (TxtTime.Text == "60") //if player has entered the number 60
            {
                time = 60; //set time to 60
                LblTime.Text = time.ToString(); //display time in LblTime
                TxtTime.Enabled = false; //Disable textbox, therefore valid and can not be edited
            }
            if (TxtTime.Text != "20" && TxtTime.Text != "40" && TxtTime.Text != "60") //if input entered by player is anything but 20, 40 or 60
            {
                MessageBox.Show("NOT VALID. Please choose from 20, 40 or 60."); //Show message box
                TxtTime.Clear(); //Clear textbox
                TxtTime.Focus(); //Refocus on textbox for new input
                TxtTime.Enabled = true; //Make sure textbox is enabled
            }

        }

        private void TmrDodge_Tick(object sender, EventArgs e)
        {
            int yplace = spawny.Next(10, 460); //yplace is any value between 10 and 460
            for (int i = 0; i < 4; i++)
            {
                dodge[i].moveDodge(); //Call the moveDodge method in the Dodge class
            }
            foreach (Dodge a in dodge) //for each individual dodge item within dodge array
            {
                if (collector1.collectorRec.IntersectsWith(a.dodgeRec)) //if collector's rectangle intersects with the dodge's rectangle
                {
                    a.x = 670; //reposition to x = 670
                    a.y = yplace; //reposition to y = yplace (any value between 10 and 460)
                    score -= 3; //decrease score by 3
                    LabelScore.Text = score.ToString(); //display new score on LabelScore
                    checkTime(); //Check if time has reached 0
                }
            }
        }

        private void BtnScores_Click(object sender, EventArgs e)
        {
            HighScores HighScore2 = new HighScores(TextName.Text,LabelScore.Text);
            Hide();
            HighScore2.ShowDialog();
        }

        private void TmrCitrine_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
            {
                citrine[i].moveCitrine(); //Call the moveCitrine method within the citrine class
            }
        }

        private void TmrRose_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
            {
                rosequartz[i].moveRosequartz(); //Call the moveRosequartz method within the rosequartz class
            }
        }

        private void TmrAmethyst_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
            {
                amethyst[i].moveAmethyst(); //Call the moveAmethyst method within the Amethyst class
            }
        }
        private void checkTime()
        {
            if (time == 0) //If time = 0
            {
                tmrCollector.Enabled = false; //disable all timers and therefore game is over
                TmrAmethyst.Enabled = false;
                TmrCitrine.Enabled = false;
                TmrRose.Enabled = false;
                TmrDodge.Enabled = false;
                TmrTime.Enabled = false;

                MessageBox.Show("Game Over. Thankyou for playing!"); //Display message
            }
        }
    }
}
