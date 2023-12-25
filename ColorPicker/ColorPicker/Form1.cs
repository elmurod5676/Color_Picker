using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorPicker
{
    public partial class Form1 : Form
    {
        int R = 0;
        int G = 0;
        int B = 0;
        int rgblabel;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Rbar_ValueChanged(object sender, EventArgs e)
        {
            R = Rbar.Value;
            Rlabel.Text = Rbar.Value.ToString();
            UpdateColor();
        }

        private void Gbar_ValueChanged(object sender, EventArgs e)
        {
            G = Gbar.Value;
            Glabel.Text = Gbar.Value.ToString();
            UpdateColor();
        }

        private void Bbar_ValueChanged(object sender, EventArgs e)
        {
            B = Bbar.Value;
            Blabel.Text = Bbar.Value.ToString();
            UpdateColor();
        }

        private void UpdateColor()
        {
          colorviewer.BackColor = Color.FromArgb(100, R, G, B);
        }
        
    }
}
