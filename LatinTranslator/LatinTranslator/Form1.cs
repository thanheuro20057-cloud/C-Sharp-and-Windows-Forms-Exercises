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
            lblOutput.Left = 50;
        }
    }
}
