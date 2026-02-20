using System;
using System.Collections.Generic;
using System.Windows.Forms; 

namespace LatinTranslator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSinister_Click(object sender, EventArgs e)
        {
            lblOutput.Text = "Left";
            lblOutput.Left = 130;
        }

        private void btnMedium_Click(object sender, EventArgs e)
        {
            lblOutput.Text = "Center";
            lblOutput.Left = (this.ClientSize.Width - lblOutput.Width) / 2;

        }

        private void btnDexter_Click(object sender, EventArgs e)
        {
            lblOutput.Text = "Right";
            lblOutput.Left = 625;
        }
    }
}
