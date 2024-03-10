namespace SlikeDomaci1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            //Image slika = Properties.Resources.slika1;
            //g.DrawImage(slika, new Rectangle(0,0, this.ClientRectangle.Width, this.ClientRectangle.Height));

            Image slika = Properties.Resources.figure;
            g.DrawImage(slika, new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));

        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            Invalidate();
        }
    }
}