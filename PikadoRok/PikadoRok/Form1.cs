using System.Drawing.Imaging;

namespace PikadoRok
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
            //antialiasing treba 
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            Pen olovka1 = new Pen(new SolidBrush(Color.Black), (float)(0.007 * 0.9 * manjaDimenzija())/2.0f);

            int x = this.ClientRectangle.Width/2;
            int y = this.ClientRectangle.Height/2;
            Point centar = new Point(x, y);
            //ovde nesto ne valja sa proporcijom prozora
            int poluprecnik = (int)(0.9 * manjaDimenzija())/2;

            nacrtajKrugSaBrojevima(g, centar, poluprecnik);
            nacrtajTablu(g, centar, poluprecnik);
            nacrtajStrelice(g, centar, poluprecnik);
            nacrtajNaziv(g, new Point(centar.X, centar.Y - (int)(0.44 * this.ClientRectangle.Height)), 17f, Color.FromArgb(245, 114, 43));
            nacrtajPotpis(g, new Point(centar.X, centar.Y + (int)(0.44 * this.ClientRectangle.Height)), 17f, Color.FromArgb(245, 114, 43));

            //cuvanje slike

            Bitmap bitmap = new Bitmap(1000, 600);
            Graphics g1 = Graphics.FromImage(bitmap);

            centar = new Point(500,300);
            poluprecnik = (int)(0.9 * 600) / 2;

            nacrtajKrugSaBrojevima(g1, centar, poluprecnik);
            nacrtajTablu(g1, centar, poluprecnik);
            nacrtajStrelice(g1, centar, poluprecnik);

            bitmap.Save("slikaPikado.png", ImageFormat.Png);

            nacrtajNaziv(g1, new Point(centar.X, centar.Y - (int)(0.44 * 600)), 17f, Color.FromArgb(245, 114, 43));
            nacrtajPotpis(g1, new Point(centar.X, centar.Y + (int)(0.44 * 600)), 17f, Color.FromArgb(245, 114, 43));

            bitmap.Save("slikaPikado.emf", ImageFormat.Emf);


        }

        private void nacrtajKruzniIsjecak(Graphics g, Point centar, int poluprecnik, Single pocetniUgao, Color boja, Pen olovka)
        {
            Rectangle rect = new Rectangle(centar.X - poluprecnik, centar.Y - poluprecnik, 2 * poluprecnik, 2 * poluprecnik);            
            g.DrawPie(olovka, rect, pocetniUgao, 18 );
            g.FillPie(new SolidBrush(boja), rect, pocetniUgao, 18);
        }

        private void nacrtajTablu(Graphics g, Point centar, int poluprecnik)
        {
            Color boja1;
            Color boja2;
            Pen olovka = new Pen(Color.White, (int)(0.007 * 0.9 * manjaDimenzija())/2.0f);
            //Pen olovka = new Pen((Color.White), (int)(0.007 * 0.9 * manjaDimenzija()));
            int k = 0;
            for(int i = 0; i < 360; i+=18)
            {
                if(k%2 == 0)
                {
                    boja1 = Color.Black;
                    boja2 = Color.FromArgb(245, 114, 43);
                }
                else
                {
                    boja1 = Color.FromArgb(245, 114, 43);
                    boja2 =  Color.Black;
                }
                nacrtajKruzniIsjecak(g, centar, (int)(poluprecnik * 0.76), i + 9, boja2, olovka);
                nacrtajKruzniIsjecak(g, centar, (int)(poluprecnik * 0.70), i + 9, boja1, olovka);
                nacrtajKruzniIsjecak(g, centar, (int)(poluprecnik * 0.48), i + 9, boja2, olovka);
                nacrtajKruzniIsjecak(g, centar, (int)(poluprecnik * 0.42), i + 9, boja1, olovka);
                k++;
            }
            nacrtajCentarSaSlikom(g, centar, poluprecnik);
        }

        private void nacrtajCentarSaSlikom(Graphics g, Point centar, int poluprecnik)
        {
            Rectangle rect = new Rectangle(new Point(centar.X - (int)(0.16 * poluprecnik), centar.Y - (int)(0.16 * poluprecnik)), new Size(2 * (int)(0.16 * poluprecnik), 2 * (int)(0.16 * poluprecnik)));
            g.DrawEllipse(new Pen(Color.White), rect);
            g.FillEllipse(new SolidBrush(Color.Black), rect);

            Image slika = Properties.Resources.logo;
            Rectangle rectSlike = new Rectangle(new Point(centar.X - (int)(0.11 * poluprecnik), centar.Y - (int)(0.11 * poluprecnik)), new Size(2 * (int)(0.11 * poluprecnik), 2 * (int)(0.11 * poluprecnik)));
            g.DrawImage(slika, rectSlike);
           
        }

        private void nacrtajKrugSaBrojevima(Graphics g, Point centar, int poluprecnik)
        {
            int pp =(int) (poluprecnik * 0.98);
            Rectangle rect = new Rectangle(centar.X - pp, centar.Y - pp, 2 * pp, 2 * pp);
            Pen olovka = new Pen(Color.Black);
            g.DrawEllipse(olovka, rect);
            g.FillEllipse(new SolidBrush(Color.Black), rect );

           

            int[] niz = { 6, 10, 15, 2, 17, 3, 19, 7, 16, 8, 11, 14, 9, 12, 5, 20, 1, 18, 4, 13 };

            StringFormat format = new StringFormat();
            format.Alignment = StringAlignment.Center;
            format.LineAlignment = StringAlignment.Center;

            Font font = new Font("Calibri", (float)((poluprecnik - pp) * 6), FontStyle.Regular, GraphicsUnit.Pixel);

            int ppSlova = (int)(poluprecnik * 0.87);

            for (int i = 0; i < 20; i++)
            {
                g.DrawString(niz[i].ToString(), font, new SolidBrush(Color.White),
                    new Point(centar.X + (int)(Math.Cos(DegToRad(i * 18)) * ppSlova), centar.Y + (int)(Math.Sin(DegToRad(i * 18)) * ppSlova) ), format);
            }

        }

        private void nacrtajStrelice(Graphics g, Point centar, int poluprecnik)
        {
            Image strelice = Properties.Resources.strelice;
            Rectangle crvenaStrelica = new Rectangle(0, 0, strelice.Width / 2, strelice.Height);
            Rectangle plavaStrelica = new Rectangle(strelice.Width/2, 0, strelice.Width/2, strelice.Height);


            g.DrawImage(strelice, new Rectangle(centar.X - (int)(poluprecnik * 0.23), centar.Y - (int)(poluprecnik * 0.43), 50, 50),
                crvenaStrelica, GraphicsUnit.Pixel);                                                                            
            g.DrawImage(strelice, new Rectangle(centar.X - (int)(poluprecnik * 0.43), centar.Y - (int)(poluprecnik * 0.63), 50, 50),
                crvenaStrelica, GraphicsUnit.Pixel);                                                                            
            g.DrawImage(strelice, new Rectangle(centar.X + (int)(poluprecnik * 0.33), centar.Y + (int)(poluprecnik * 0.73), 50, 50),
                crvenaStrelica, GraphicsUnit.Pixel);                                                                            
                                                                                                                                
            g.DrawImage(strelice, new Rectangle(centar.X + (int)(poluprecnik * 0.53), centar.Y + (int)(poluprecnik * 0.63), 50, 50),
                plavaStrelica, GraphicsUnit.Pixel);                                                                             
            g.DrawImage(strelice, new Rectangle(centar.X + (int)(poluprecnik * 0.27), centar.Y + (int)(poluprecnik * 0.56), 50, 50),
                plavaStrelica, GraphicsUnit.Pixel);                                                                             
            g.DrawImage(strelice, new Rectangle(centar.X - (int)(poluprecnik * 0.18), centar.Y - (int)(poluprecnik * 0.47), 50, 50),
                plavaStrelica, GraphicsUnit.Pixel);

        }

        private void nacrtajNaziv(Graphics g, Point tacka, float velicinaFonta, Color boja)
        {
            Font font = new Font("Calibri", velicinaFonta, 
                FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Pixel);

            StringFormat format = new StringFormat();
            format.Alignment = StringAlignment.Center;
            format.LineAlignment = StringAlignment.Center;
            
            g.DrawString("Pikado, 18. 04. 2022.", font, new SolidBrush(Color.Black), tacka, format);
            tacka.X -= 1;
            tacka.Y -= 1;
            g.DrawString("Pikado, 18. 04. 2022.", font, new SolidBrush(boja), tacka, format);


        }

        private void nacrtajPotpis(Graphics g, Point tacka, float velicinaFonta, Color boja)
        {
            Font font = new Font("Calibri", velicinaFonta,
                FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Pixel);

            StringFormat format = new StringFormat();
            format.Alignment = StringAlignment.Center;
            format.LineAlignment = StringAlignment.Center;

            g.DrawString("by Jovana Golijanin, 16038", font, new SolidBrush(Color.Black), tacka, format);
            tacka.X -= 1;
            tacka.Y -= 1;
            g.DrawString("by Jovana Golijanin, 16038", font, new SolidBrush(boja), tacka, format);


        }

        private double DegToRad(int ugao)
        {
            return (Math.PI * ugao)/180;
        }
        private int manjaDimenzija()
        {
            return this.ClientRectangle.Width < this.ClientRectangle.Height ? this.ClientRectangle.Width : this.ClientRectangle.Height;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            Invalidate();
        }
    }
}