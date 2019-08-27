using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace CrystalCollector
{
    public partial class HighScores : Form
    {
        string binPath = Application.StartupPath + @"\highscores.txt";
        List<HighScores> highScores = new List<HighScores>();
        public HighScores(string playerName, string playerScore)
        {
            InitializeComponent();
            LblPlayerName.Text = playerName;
            LblPlayerScore.Text = playerScore;
            var reader = new StreamReader(binPath);
            while(!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line.Split(',');
                string value1 = values[1];
               
                highScores.Add(new HighScores(values[0],value2));
              /*  highScores.Add(new HighScores(values[0], int.Parse(values[1])));*/ //Int32.Parse(values[1])));
            }
            reader.Close();
        }
        public void DisplayHighScores()
        {
            foreach(HighScores s in highScores)
            {
                ListBoxName.Items.Add(s.Name);
                ListBoxScore.Items.Add(s.Score);
            }
        }

        private void HighScores_Load(object sender, EventArgs e)
        {
            int lowest_score = highScores[(highScores.Count - 1)].Score;
            if (int.Parse(LblPlayerScore.Text) > lowest_score)
            {
                LblMessage.Text = "You have made the Top Ten! Well Done!";
                highScores.Add(new HighScores(LblPlayerName.Text, int.Parse(LblPlayerScore.Text)));
            }
            else
            {
                LblMessage.Text = "Keep trying to make the top ten!";
            }
            SortHighScores();
            DisplayHighScores();
        }
        public void SortHighScores()
        {
            highScores = highScores.OrderByDescending(hs => hs.Score).Take(10).ToList();
        }
        public void SaveHighScores()
        {
            StringBuilder builder = new StringBuilder();
            foreach(HighScores score in highScores)
            {
                //{0} is for the Name, {1} is for the Score and {2} is for a new line
                builder.Append(string.Format("{0},{1}{2}", score.Name, score.Score, Environment.NewLine));
            }
            File.WriteAllText(binPath, builder.ToString());
        }

        private void BtnReturn_Click(object sender, EventArgs e)
        {
            FrmCrystal FrmCrystal2 = new FrmCrystal();
            Hide();
            FrmCrystal2.ShowDialog();
        }
    }
}
