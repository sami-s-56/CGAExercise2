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
        float Y = 0, U = 0, V = 0;

        public float R, G, B;

        bool bInvert = false;

        public Form1()
        {
            InitializeComponent();

            YValue.Text = Y.ToString();
            UValue.Text = U.ToString();
            VValue.Text = V.ToString();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            Y = trackBar1.Value;
            YValue.Text = Y.ToString();
            
            CalculateRGB();

        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            U = trackBar2.Value;
            UValue.Text = U.ToString();

            CalculateRGB();
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            V = trackBar3.Value;
            VValue.Text = V.ToString();

            CalculateRGB();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            bInvert = checkBox1.Checked;
        }
        
        private void CalculateRGB()
        {
            R = (Y) + (0) + (1.13983f * V);
            G = (Y) + (-0.39465f * U) + (-0.58060f * V);
            B = (Y) + (2.03211f * U) + (1.13983f * V);
        }
    }
}
