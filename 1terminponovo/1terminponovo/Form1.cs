using System.Drawing.Drawing2D;

namespace _1terminponovo
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
            //g.DrawLine(new Pen(Color.DarkRed), 0, 0, 250, 250);
            //g.PageUnit = GraphicsUnit.Millimeter;
            //g.PageScale = 1.0f;
            //g.DrawLine(new Pen(Color.Red), 20, 25, 70, 25);

            //for (int i = 0; i < 10; i++)
            //    g.DrawLine(new Pen(Color.Red), i * 30, 30, i * 30, 300);

            //int sirina = this.ClientRectangle.Width;
            //int visina = this.ClientRectangle.Height;

            //g.DrawLine(new Pen(Color.DeepPink), 0, 0, sirina, visina);

            //Pen olovka = new Pen(Brushes.Blue);
            //olovka.Width = 6.0f;

            ////Specificiranje DashStyle-a
            //olovka.DashStyle = DashStyle.Dash;
            //g.DrawLine(olovka, 20, 20, 250, 20);

            //olovka.DashStyle = DashStyle.DashDot;
            //g.DrawLine(olovka, 20, 60, 220, 60);

            //olovka.DashStyle = DashStyle.Dot;
            //g.DrawLine(olovka, 20, 100, 220, 100);

            //olovka.DashStyle = DashStyle.Solid;
            //g.DrawLine(olovka, 20, 140, 220, 140);


            //float [] nasaOlovka = { 5.0f, 5.0f, 5.0f, 5.0f, 1.0f, 1.0f, 1.0f, 1.0f};
            //olovka.DashPattern = nasaOlovka;
            //g.DrawLine(olovka, 20, 180, 220, 180);

            Pen olovka = new Pen(Brushes.Blue);
            olovka.Width = 5.0f;

            Point tacka1 = new Point(20, 100);
            Point tacka2 = new Point(250, 100);
            g.DrawLine(olovka, tacka1, tacka2);

            PointF tacka1F = new PointF(20f, 140f);
            PointF tacka2F = new PointF(250.2f, 140.5f);
            g.DrawLine(olovka, tacka1F, tacka2F);

            g.DrawLine(olovka, 20, 20, 250, 20);
            g.DrawLine(olovka, 20.4f, 60.7f, 250.0f, 60.5f);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            //Graphics g = e.Graphics;
            //g.DrawLine(new Pen(Color.Blue), 0, 250, 250, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Graphics g = (sender as Button).CreateGraphics();
            //g.DrawLine(new Pen(Color.Red), 0, 0, 250, 250);
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            //Graphics g = (sender as TextBox).CreateGraphics();
            //for (int i = 1; i < 10; i++)
            //    g.DrawLine(new Pen(Color.Black), 10, 20 * i, 250, 20 * i);
        }
    }
}