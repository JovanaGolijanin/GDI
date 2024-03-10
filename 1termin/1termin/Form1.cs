using System.Drawing.Drawing2D;

namespace _1termin
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
            //g.DrawLine(new Pen(Color.DarkRed),0,0,250,250);

            //g.PageUnit = GraphicsUnit.Millimeter;
            //g.PageScale = 2.0f;
            //g.DrawLine(new Pen(Color.BlueViolet), 20, 20, 50, 20);

            //for (int i = 1; i < 10; i++)
            //    g.DrawLine(new Pen(Color.DarkRed), 20*i, 20, 20 * i, 200);

            //int sirina = this.ClientRectangle.Width;
            //int visina = this.ClientRectangle.Height;

            //g.DrawLine(new Pen(Color.DeepPink), 0, 0, sirina, visina);

            //GraphicsState prethodnoStanje = g.Save();
            //Matrix matricaTrans = new Matrix(1, 0, 0, -1, 0, 0);
            //matricaTrans.Translate(offsetX:this.ClientRectangle.Width/2, offsetY:-this.ClientRectangle.Height/2);

            //g.Transform = matricaTrans;
            //g.DrawLine(new Pen(Color.BlueViolet), 0, 0, 150, 150);

            //g.Restore(prethodnoStanje);
            //g.DrawLine(new Pen(Color.DeepPink), 0, 0, 150, 150);


            //Pen olovka = new Pen(Brushes.DeepPink);
            //olovka.Width = 12.0f;

            //olovka.LineJoin = LineJoin.Miter;

            //olovka.StartCap = LineCap.Square;
            //olovka.EndCap = LineCap.Square;


            //olovka.LineJoin = LineJoin.Miter;

            //g.DrawLine(olovka, 20, 20, 150, 150);
            //g.DrawLine(olovka, 70, 20, 150, 150);

            //olovka.LineJoin = LineJoin.Miter;

            // g.DrawLine(new Pen(Brushes.BlueViolet), 50, 20, 180, 180);


            //Pen olovka = new Pen(Brushes.Blue);
            //olovka.Width = 6.0f;

            //olovka.DashStyle = DashStyle.Dash;
            //g.DrawLine(olovka, 10, 20, 250, 20);

            //olovka.DashStyle = DashStyle.DashDot;
            //g.DrawLine(olovka, 10, 50, 250, 50);

            //olovka.DashStyle = DashStyle.Dot;
            //g.DrawLine(olovka, 10, 80, 250, 80);

            //olovka.DashStyle = DashStyle.DashDotDot;
            //g.DrawLine(olovka, 10, 110, 250, 110);

            //olovka.DashStyle = DashStyle.Solid;
            //g.DrawLine(olovka, 10, 140, 250, 140);

            //float[] nasaLinija = { 8.0f, 1.0f, 8.0f, 1.0f, 1.0f, 1.0f, 1.0f, 1.0f };
            //olovka.DashPattern = nasaLinija;
            //g.DrawLine(olovka, 10, 170, 450, 170);

            //domaci 1. zadatak

            //Pen olovka = new Pen(Color.Red);
            //olovka.Width = 5.0f;

            //g.DrawLine(olovka, 50, 50, 250, 50);
            //g.DrawLine(olovka, 250, 50, 150, 150);
            //g.DrawLine(olovka, 150, 150, 50, 50);

            //domaci 2. zadatak
            //dole u funkciji

            //domaci 3. zadatak

            Pen olovka = new Pen((Color.Aqua),(float)5.5);

            g.PageUnit = GraphicsUnit.Millimeter;

            g.DrawLine(olovka, 50, 50, 100, 50);
            g.DrawLine(olovka, 100, 50, 100, 100);
            g.DrawLine(olovka, 100, 100, 50, 100);
            g.DrawLine(olovka, 50, 100, 50, 50);

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
            //g.DrawLine(new Pen(Color.DarkRed), 0, 0, 250, 250);
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            //Graphics g = (sender as TextBox).CreateGraphics();
            ////Graphics g = ((TextBox)sender).CreateGraphics();
            //for (int i = 1; i <= 10; i++)
            //    g.DrawLine(new Pen(Color.Black),10,20*i,250,20*i );
        }

        //domaci 2. zadatak
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

            base.OnPaint(e);

            //Graphics g = e.Graphics;

            //Pen olovka = new Pen(Color.Black);
            //olovka.Width = 1.75f;

            //int sirina = ClientRectangle.Width;
            //int visina = ClientRectangle.Height;

            //for (int i = 0; i<sirina; i++)
            //    g.DrawLine(olovka, 5 * i, 5, 5 * i, visina);

            //for (int i = 0; i < visina; i++)
            //    g.DrawLine(olovka, 5, 5*i, sirina, 5*i);
        }
    }
}