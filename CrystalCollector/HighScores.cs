using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrystalCollector
{
    public partial class HighScores : Form
    {
        string binPath = Application.StartupPath + @"\highscores.txt";
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
            }
        }
    }
}
