using System.Drawing.Drawing2D;

namespace PikacuPonovoUzSnimak
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
            //SmoothingMode s = SmoothingMode.AntiAlias;
            //g.SmoothingMode = s;

            int x = this.ClientRectangle.Width/2;
            int y = this.ClientRectangle.Height/2;
            Point centar = new Point(x, y);
            int dimenzija = (int)(0.75 * manjaDimenzija());


            NacrtajTeren(g, centar, dimenzija);
        }

        private int manjaDimenzija()
        {
            return this.ClientRectangle.Width < this.ClientRectangle.Height ? 
                this.ClientRectangle.Width : this.ClientRectangle.Height;
        }
        private double DegToRad(int ugao)
        {
            return Math.PI * ugao / 180;
        }
        static Point RotirajTacku(Point pointToRotate, Point centerPoint, double angleInDegrees)
        {
            Point rotiranaTacka;

            int ugaoURad = (int)(angleInDegrees*(Math.PI/180));

            int sinusUgla = (int)Math.Sin(ugaoURad);
            int kosinusUgla =(int)Math.Cos(ugaoURad);

            int x = pointToRotate.X - centerPoint.X ;
            int y = pointToRotate.Y - centerPoint.Y ;

            int r = (int)(Math.Sqrt(x*x + y*y));

            int X = centerPoint.X + r * kosinusUgla;
            int Y = centerPoint.Y + r * sinusUgla;

            rotiranaTacka = new Point(X, Y);

            return rotiranaTacka;
        }

        public void NacrtajTeren(Graphics g, Point centar, int dimenzija)
        {
            int a = dimenzija / 2;
            int h = (int)(Math.Sqrt(3) * a / 2);

            Point pocetna = new Point();
            pocetna.X = centar.X-a/2;
            pocetna.Y = centar.Y - h;

            for(int ugao = 0, i=0; ugao <360; ugao += 60, i++)
            {
                
                Point prva = RotirajTacku(pocetna,centar, ugao);
                Point druga = RotirajTacku(pocetna, centar, ugao+60);

                GraphicsPath gp = new GraphicsPath();
                gp.AddLine(centar, prva);
                gp.AddLine(prva, druga);
                gp.AddLine(druga, centar);

                g.DrawPath(new Pen(Color.Black, 1.63f), gp);

                if (i%2 == 0)
                {
                    g.FillPath(new SolidBrush(Color.LightSkyBlue), gp);

                }
                else
                {
                    g.FillPath(new SolidBrush(Color.LightGray), gp);
                }
                
            }

        }




        private void Form1_Resize(object sender, EventArgs e)
        {
            Invalidate();
        }
    }
}