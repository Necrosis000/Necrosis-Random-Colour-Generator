using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoxesViewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Generate RGB and HEX
            Random rnd = new Random();
            int R = rnd.Next(1, 256);
            int G = rnd.Next(1, 256);
            int B = rnd.Next(1, 256);
            string randRGB = "RGB: (" + R + "," + G + "," + B + ")";
            Color randRGBclr = Color.FromArgb(R, G, B);
            string hex = "Hex: #" + randRGBclr.R.ToString("X2") + randRGBclr.G.ToString("X2") + randRGBclr.B.ToString("X2");
            rgbLbl.Text = randRGB;
            hexLbl.Text = hex;
            clrPreviewer.BackColor = randRGBclr;
            
            
        }

        

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
