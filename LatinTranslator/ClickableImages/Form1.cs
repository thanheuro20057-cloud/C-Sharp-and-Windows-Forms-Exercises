namespace ClickableImages
{
    public partial class frmClickableImages : Form
    {
        public frmClickableImages()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("One", "Clickable Images");

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Two", "Clickable Images");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Three", "Clickable Images");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Four", "Clickable Images");
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Five", "Clickable Images");
        }
    }
}
