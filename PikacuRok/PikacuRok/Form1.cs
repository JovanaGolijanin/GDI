using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace PikacuRok
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

            g.FillRectangle(new SolidBrush(Color.LightYellow), 0,0, this.ClientRectangle.Width, this.ClientRectangle.Height);
            NacrtajTeren(g, new Point(this.ClientRectangle.Width / 2, this.ClientRectangle.Height / 2), 100);
            NacrtajLinijeTerena(g, new Point(0, 0), 25);
            NacrtajSlike(g, new Point(0, 0),0, 0);
            NacrtajNapad(g, new Point(0, 0), 50, 50);
            NacrtajNaziv(g, new Point(500, 50), 40);
            NacrtajPotpis(g, new Point(900, 950), 35, Color.White);

            Bitmap bitmap = new Bitmap(800, 800);

            Graphics g1 = Graphics.FromImage(bitmap);

            g1.FillRectangle(new SolidBrush(Color.LightYellow), 0, 0, 800,800);
            NacrtajTeren(g1, new Point(800, 800), 100);
            NacrtajLinijeTerena(g1, new Point(0, 0), 25);
            NacrtajSlike(g1, new Point(0, 0), 0, 0);
            NacrtajNapad(g1, new Point(0, 0), 50, 50);
            NacrtajNaziv(g1, new Point(500, 50), 40);
            NacrtajPotpis(g1, new Point(900, 950), 35, Color.White);

            bitmap.Save("pikacu", ImageFormat.Png);

            NacrtajTeren(g1, new Point(800, 800), 100);
            NacrtajLinijeTerena(g1, new Point(0, 0), 25);
            NacrtajSlike(g1, new Point(0, 0), 0, 0);
            NacrtajNapad(g1, new Point(0, 0), 50, 50);
            NacrtajNaziv(g1, new Point(500, 50), 40);
            NacrtajPotpis(g1, new Point(900, 950), 35, Color.White);

            bitmap.Save("pikacu", ImageFormat.Emf);



        }

        static Point RotirajTacku(Point pointToRotate, Point centerPoint, double angleInDegrees)
        {
            int kosinus = (int)(Math.Cos(angleInDegrees));
            int x = (int)(centerPoint.X - pointToRotate.X) * kosinus;

            int sinus = (int)(Math.Sin(angleInDegrees));
            int y = (int)(centerPoint.Y - pointToRotate.Y) * sinus;

            return new Point(x, y);

        }

        //public void NacrtajTeren(Graphics g, Point centar, int dimenzija)
        //{
        //    GraphicsPath gp = new GraphicsPath(FillMode.Alternate);

        //    int x = (int)(centar.X*Math.Cos(60));
        //    int y = (int)(centar.Y*Math.Sin(60));

        //    int k = 0;
        //    for(int i = 0; i < 6; i++)
        //    {
        //        Point[] tacke = new Point[]
        //        {
        //            centar, 
        //            new Point(i*x+dimenzija, i*y+dimenzija),
        //            centar
        //        };
        //        gp.AddPolygon(tacke);
        //        g.DrawPath(new Pen(Color.Black, 1.63f), gp);
        //        if(k%2 == 0 )
        //        {
        //            g.FillPath(new SolidBrush(Color.LightSkyBlue), gp);

        //        }
        //        else
        //        {
        //            g.FillPath(new SolidBrush(Color.LightGray), gp);

        //        }
        //        k++;
        //    }
        //}

        public void NacrtajTeren(Graphics g, Point centar, int dimenzija)
        {
            GraphicsPath gp = new GraphicsPath();


            Point[] t1 = new Point[]
            {
                new Point(300,100),
                new Point(500, 500),
                new Point(700, 100)
            };

            Point[] t2 = new Point[]
           {
                new Point(500, 500),
                new Point(700, 100),
                new Point(900, 500)
           };
            Point[] t3 = new Point[]
           {
                new Point(500,500),
                new Point(900, 500),
                new Point(700, 900)
           };
            Point[] t4 = new Point[]
           {
                new Point(500,500),
                new Point(700, 900),
                new Point(300, 900)
           };
            Point[] t5 = new Point[]
           {
                new Point(500,500),
                new Point(300, 900),
                new Point(100, 500)
           };
            Point[] t6 = new Point[]
           {
                new Point(300,100),
                new Point(500, 500),
                new Point(100, 500)
           };

            g.DrawPolygon(new Pen(Color.Black, 1.63f), t1);
            g.FillPolygon(new SolidBrush(Color.LightSkyBlue), t1);

            g.DrawPolygon(new Pen(Color.Black, 1.63f), t2);
            g.FillPolygon(new SolidBrush(Color.LightGray), t2);

            g.DrawPolygon(new Pen(Color.Black, 1.63f), t3);
            g.FillPolygon(new SolidBrush(Color.LightSkyBlue), t3);

            g.DrawPolygon(new Pen(Color.Black, 1.63f), t4);
            g.FillPolygon(new SolidBrush(Color.LightGray), t4);

            g.DrawPolygon(new Pen(Color.Black, 1.63f), t5);
            g.FillPolygon(new SolidBrush(Color.LightSkyBlue), t5);

            g.DrawPolygon(new Pen(Color.Black, 1.63f), t6);
            g.FillPolygon(new SolidBrush(Color.LightGray), t6);

        }

        public void NacrtajLinijeTerena(Graphics g, Point centar, int dimenzija)
        {
            Point[] t1 = new Point[]
            {
                new Point(300,100),
                new Point(500, 500),
                new Point(700, 100)
            };

            g.DrawPolygon(new Pen(Color.Black, 1.63f), t1);
            g.FillPolygon(new HatchBrush(HatchStyle.Horizontal,Color.Blue, Color.LightSkyBlue  ), t1);

            Point[] t4 = new Point[]
            {
                new Point(500,500),
                new Point(700, 900),
                new Point(300, 900)
            };

            g.DrawPolygon(new Pen(Color.Black, 1.63f), t4);
            g.FillPolygon(new HatchBrush(HatchStyle.Vertical, Color.DarkGray, Color.LightGray), t4);

        }

        public void NacrtajSlike(Graphics g, Point centarTerena, int precnik, int dimenzija)
        {
            Image pikacu = Properties.Resources.pikachu;
            Image dv = Properties.Resources.darth_vader;

            Rectangle pravPikacua = new Rectangle(0,0,pikacu.Width,pikacu.Height);  
            Rectangle pravDV = new Rectangle(0,0, dv.Width, dv.Height);
            g.DrawImage(pikacu,new Rectangle(780, 450, 100, 100), pravPikacua,GraphicsUnit.Pixel);
            g.DrawImage(dv, new Rectangle(120, 450, 100, 100), pravDV, GraphicsUnit.Pixel);

        }

        public void NacrtajNapad(Graphics g, Point centar, int dimenzija, int precnik)
        {
            Pen olovka = new Pen(Color.Yellow, 2.1f);
            Pen crvenaOlovka = new Pen(Color.Red);
            Brush brush = new SolidBrush(Color.Yellow);
            Brush crvena = new SolidBrush(Color.Red);
            Font font = new Font("Arial", 20f );

            RectangleF rect1 = new RectangleF(500f, 200f, (float)precnik,(float) precnik);
            RectangleF rect2 = new RectangleF(300f, 300f, (float)precnik, (float)precnik);
            RectangleF rect3 = new RectangleF(300f, 600f, (float)precnik, (float)precnik);
            RectangleF rect4 = new RectangleF(500f, 700f, (float)precnik, (float)precnik);
            RectangleF rect5 = new RectangleF(400f, 800f, (float)precnik, (float)precnik);



            g.DrawEllipse(olovka, rect1);
            g.FillEllipse(brush, rect1);
            g.DrawString("1", font, crvena, rect1);

            g.DrawEllipse(olovka, rect2);
            g.FillEllipse(brush, rect2);
            g.DrawString("2", font, crvena, rect2);

            g.DrawEllipse(olovka, rect3);
            g.FillEllipse(brush, rect3);
            g.DrawString("3", font, crvena, rect3);

            g.DrawEllipse(olovka, rect4);
            g.FillEllipse(brush, rect4);
            g.DrawString("4", font, crvena, rect4);

            g.DrawEllipse(olovka, rect5);
            g.FillEllipse(brush, rect5);
            g.DrawString("5", font, crvena, rect5);

            g.DrawEllipse(olovka, rect1);
            g.FillEllipse(brush, rect1);
            g.DrawString("1", font, crvena, rect1);
        }

        public void NacrtajNaziv(Graphics g, Point tacka, float velicinaFonta)
        {
            Font font = new Font("Chiller", velicinaFonta, 
                FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Pixel);

            StringFormat stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Center;
            stringFormat.LineAlignment = StringAlignment.Center;

            Brush crnaCetka = new SolidBrush(Color.Black);
            Brush zutaCetka = new SolidBrush(Color.Yellow);


            g.DrawString("Darth Vader vs. Pikachu", font, zutaCetka, tacka, stringFormat);
            tacka.X -= 1;
            tacka.Y -= 1;
            g.DrawString("Darth Vader vs. Pikachu", font, crnaCetka, tacka, stringFormat);

        }

        public void NacrtajPotpis(Graphics g, Point tacka, float velicinaFonta, Color boja)
        {
            Font font = new Font("Chiller", velicinaFonta,
                FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Pixel);

            StringFormat stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Far;
            stringFormat.LineAlignment = StringAlignment.Far;

            Brush crnaCetka = new SolidBrush(Color.Black);
            
            g.DrawString("Jovana Golijanin, 16038", font, crnaCetka, tacka, stringFormat);
            tacka.X -= 1;
            tacka.Y -= 1;
            g.DrawString("Jovana Golijanin, 16038", font, new SolidBrush(boja), tacka, stringFormat);

        }

        private double RadToDeg(int ugao)
        {
            return ugao * Math.PI / 180;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            Invalidate();
        }
    }
}