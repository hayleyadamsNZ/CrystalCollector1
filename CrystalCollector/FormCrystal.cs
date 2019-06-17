using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrystalCollector
{
    public partial class FrmCrystal : Form
    {
        public FrmCrystal()
        {
            Graphics g; //declare a graphics object called g
            Collector collector1 = new Collector(); //create the object, collector1
            InitializeComponent();
        }
    }
}
