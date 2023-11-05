using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CGE2
{
    public partial class Form1 : Form
    {
        float Y, U, V;

        float R, G, B;

        public Form1()
        {
            InitializeComponent();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            Y = trackBar1.Value;
            YValue.Text = Y.ToString();
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            U = trackBar2.Value;
            UValue.Text = U.ToString(); 
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            V = trackBar3.Value;
            VValue.Text = V.ToString();
        }
    }
}
