namespace SatDomaci
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

            Pen olovka = new Pen(Color.Black);
            olovka.Width = 6f;

            g.DrawEllipse(olovka, 100, 100, 300, 300);
            g.FillEllipse(new SolidBrush(Color.DarkGreen), 100,100, 300, 300);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            Invalidate();
        }
    }
}