namespace Dom1Zad2
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

            int sirina = this.ClientRectangle.Width;
            int visina = this.ClientRectangle.Height;

            Pen olovka = new Pen(Color.Black);
            olovka.Width = 1.75f;

            for (int x = 5; x < sirina; x += 5)
            {
                g.DrawLine(olovka, x, 0, x, visina);
            }
            for (int y = 5; y < visina; y += 5)
            {
                g.DrawLine(olovka, 0, y, sirina, y);
            }

        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            Invalidate();
        }
    }
}