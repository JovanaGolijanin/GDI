namespace _2termin
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

            nacrtajPravougaonike(g);

            //linije

            //Pen olovka = new Pen(Brushes.DarkGoldenrod);
            //olovka.Width = 6.0f;

            //Point tacka1 = new Point(20, 20);
            //Point tacka2 = new Point(150, 150);
            ////g.DrawLine(olovka, tacka1, tacka2);
            //g.DrawLine(olovka, tacka1.X, tacka1.Y, tacka2.X, tacka2.Y);

            //PointF tackaF1 = new PointF(53.3f, 20.3f);
            //PointF tackaF2 = new PointF(183.3f, 150.3f);
            //g.DrawLine(olovka, tackaF1, tackaF2);

            //g.DrawLine(olovka, 83, 20, 200, 150);

            //g.DrawLine(olovka, 113.258f, 20.45f, 231.7f, 150.63f);
        }

        public void nacrtajPravougaonike(Graphics g)
        {
            Pen olovka = new Pen(Brushes.ForestGreen);
            olovka.Width = 6.0f;

            g.DrawRectangle(olovka, 20, 20, 150, 100);

            Rectangle pravougaonik = new Rectangle(40, 40, 150, 100);
            g.DrawRectangle(olovka, pravougaonik);

            Point startlok = new Point(60, 60);
            Size velicina = new Size(150, 100);
            Rectangle pravoungaonik2 = new Rectangle(startlok, velicina);
            g.DrawRectangle(olovka, pravoungaonik2);


            Pen olovka2 = new Pen(Color.DeepPink);
            olovka2.Width = 6.0f;

            Rectangle[] pravougaonici = new Rectangle[] {
                new Rectangle(200, 20, 100, 50), 
                new Rectangle(220, 40, 100, 50),
                new Rectangle(240, 60, 100, 50)
            };
            g.DrawRectangles(olovka2, pravougaonici);
        }
    }
       
}