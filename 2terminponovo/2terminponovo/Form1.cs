using System.Drawing.Drawing2D;

namespace _2terminponovo
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
            //Pen olovka = new Pen(Color.Blue);
            //olovka.Width = 2f;

            //Rectangle prav = new Rectangle(100, 50, 100, 50);
            //g.DrawRectangle(new Pen(Color.Red), prav);
            //g.DrawEllipse(olovka, prav);

            //g.DrawEllipse(olovka, 250, 50, 250, 50);

            //Pen olovka = new Pen(Color.DarkMagenta);
            //olovka.Width = 4f;

            //Rectangle prav = new Rectangle(100, 50, 100, 100);
            //g.DrawEllipse(new Pen(Color.Blue), prav);
            //g.DrawArc(olovka, prav, 0, 90);
            //g.DrawArc(olovka, prav, 180, 90);

            //g.DrawArc(olovka, 30, 100, 150, 150, 135, 180);

            //Pen olovka = new Pen(Color.Red);
            //olovka.Width = 4f;

            //Pen tackaOlovka = new Pen(Color.Black);
            //tackaOlovka.DashStyle = DashStyle.Dot;

            //Rectangle prav = new Rectangle(100, 50, 150, 150);
            //g.DrawPie(olovka, prav, 0, 90);
            //g.DrawRectangle(tackaOlovka, prav);

            //g.DrawPie(olovka, 50, 200, 150, 150, 135, 100);
            //g.DrawRectangle(tackaOlovka, 50, 200, 150, 150);


            //Pen olovka = new Pen(Color.DeepPink);
            //olovka.Width = 5f;

            //Point[] tacka = new Point[]
            //{
            //    new Point(150, 50),
            //    new Point(150, 200),
            //    new Point(100, 50),
            //    new Point(70, 36),
            //    new Point(30, 30)
            //};

            //g.DrawPolygon(olovka, tacka);

            //Pen olovka = new Pen(Color.Chocolate);
            //olovka.Width = 3f;

            ////da bi nacrtali put ovo nam treba
            //GraphicsPath gp = new GraphicsPath();

            //gp.AddArc(20, 20, 100, 100, 90, 90);
            //gp.AddLine(70, 120, 70, 150);
            //gp.AddLine(70, 150, 200, 150);
            //gp.AddLine(200, 150, 260, 70);
            //gp.AddLine(260, 70, 20, 70);

            //g.FillPath(new SolidBrush(Color.Brown), gp);
            //g.DrawPath(olovka, gp);

            //smajli u pokusaju, moram da pogledam resenje i da ga ukapiram
            //Pen spoljna = new Pen(Color.Orange);
            //GraphicsPath path = new GraphicsPath();

            //path.AddEllipse(20, 20, 120, 120);
            //g.FillPath(new SolidBrush(Color.Orange), path);

            //Pen unutrasnja = new Pen(Color.Yellow);
            //GraphicsPath gp = new GraphicsPath();

            //gp.AddEllipse(40, 40, 80, 80);
            //g.FillPath(new SolidBrush(Color.Yellow), gp);

            ////g.DrawEllipse(spoljna, 58, 58, 59, 59);
            ////g.FillEllipse(new SolidBrush(Color.Orange), 58, 58, 59, 58);
            //Pen oko = new Pen(Color.Orange);
            ////oko.Width = 5f;
            //g.DrawLine(oko, 60, 60, 61, 60);
            //g.DrawLine(oko, 100, 60, 101, 60);

            //Rectangle rect = new Rectangle(60, 80, 61, 81);
            //Pen okvir = new Pen(Color.Blue);
            //g.DrawRectangle(okvir, rect);
            ////GraphicsPath usta = new GraphicsPath();
            ////usta.AddLine(60, 80, 100, 80);
            ////usta.AddArc(rect, 0, 180);
            ////g.DrawPath(oko, usta);

            //Pen olovka = new Pen(Color.Black);
            //olovka.Width = 3f;

            ////Brush crvenaCetka = new SolidBrush(Color.Red);
            //Brush crvenaCetka = new HatchBrush(HatchStyle.ZigZag, Color.Red, Color.Blue);
            //g.FillRectangle(crvenaCetka, 50, 50, 150, 150);

            ////Brush plavaCetka = new SolidBrush(Color.Blue);
            //Brush plavaCetka = new HatchBrush(HatchStyle.DiagonalBrick, Color.Blue, Color.White);
            //g.FillEllipse(plavaCetka, 250, 50, 150, 150);

            //Brush gradientBrush1 =
            //    new LinearGradientBrush(new Point(0, 10), new Point(150, 10), Color.Black, Color.White);
            //g.FillRectangle(gradientBrush1, 50, 50, 100, 100);

            //Brush gradientBrush2 =
            //    new LinearGradientBrush(new Point(150, 10), new Point(250, 10), Color.Blue, Color.DeepPink);
            //g.FillEllipse(gradientBrush2, 150, 50, 100, 100);

            Brush cetka = new SolidBrush(Color.DarkMagenta);
            FontStyle stil = FontStyle.Bold | FontStyle.Italic;
            Font font1 = new Font("Arial", 24);
            Font font = new Font("Arial", 24, stil);
            PointF tacka = new PointF(100, 100);
            PointF tacka1 = new PointF(100, 150);

            g.DrawString("Racunarska grafika ETF", font, cetka, tacka);
            g.DrawString("Racunarska grafika ETF", font1, cetka, tacka1);




        }
    }
}