using System.Drawing.Imaging;

namespace PikadoVezbanje
{
    public partial class Form1 : Form
    {
        private float velicinaOlovke;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            int velicinaPikada = (int)(0.9 * manjaDimenzijaForme());
            velicinaOlovke = (float)(0.007 * 0.9 * manjaDimenzijaForme() / 2.0f);
            Point centar = new Point(ClientRectangle.Width / 2, ClientRectangle.Height / 2);

            nacrtajKrugSaBrojevima(g, centar, velicinaPikada / 2);

            Point centarNaziva = new Point(centar.X, centar.Y - (int)(0.44 * ClientRectangle.Height));
            Point centarPotpisa = new Point(centar.X, centar.Y + (int)(0.44* ClientRectangle.Height));

            nacrtajNaziv(g, centarNaziva, 17f, Color.FromArgb(245, 114, 43));
            nacrtajPotpis(g, centarPotpisa, 17f, Color.FromArgb(245, 114, 43));

            //cuvanje slika
            Bitmap bitmap= new Bitmap(1000, 600);
            Graphics g1 = Graphics.FromImage(bitmap);

            velicinaPikada = (int)(0.9 * 600);
            velicinaOlovke = (float)(0.007 * 0.9 * 600 / 2);
            centar = new Point(500, 300);
            centarNaziva = new Point(centar.X, centar.Y - (int)(0.44 * 600));
            centarPotpisa = new Point(centar.X, centar.Y + (int)(0.44 * 600));

            nacrtajKrugSaBrojevima(g1, centar, velicinaPikada/2);
            bitmap.Save("slikaPikado.png", ImageFormat.Png);
            
            nacrtajNaziv(g1, centarNaziva, 17f, Color.FromArgb(245,144,43));
            nacrtajPotpis(g1, centarPotpisa, 17f, Color.FromArgb(245, 144, 43));
            bitmap.Save("slikaPikado.emf", ImageFormat.Emf);
        }
        public int manjaDimenzijaForme()
        {
            return ClientRectangle.Width < ClientRectangle.Height ? ClientRectangle.Width : ClientRectangle.Height;
        }

        public double DegToRad(int ugao)
        {
            return ugao * Math.PI / 180;
        }
        private void nacrtajKruzniIsjecak(Graphics g, Point centar, int poluprecnik,
            Single pocetniUgao, Color boja, Pen olovka)
        {
            Rectangle isjecakRect = new Rectangle(centar.X - poluprecnik, centar.Y - poluprecnik,
               2 * poluprecnik, 2 * poluprecnik);
            g.DrawPie(olovka, isjecakRect, pocetniUgao, 18);
            g.FillPie(new SolidBrush(boja), isjecakRect, pocetniUgao, 18);
        }

        private void nacrtajTablu(Graphics g, Point centar, int poluprecnik)
        {
            int poluprecnik1 = (int)(0.76 * poluprecnik);
            int poluprecnik2 = (int)(0.70 * poluprecnik);
            int poluprecnik3 = (int)(0.48 * poluprecnik);
            int poluprecnik4 = (int)(0.42 * poluprecnik);

            Color boja1, boja2;
            //0.007*0.9*“мања димензија форме“/2
            Pen olovka = new Pen((Color.White), velicinaOlovke);

            for (int i = 0; i < 20; i++)
            {
                if (i % 2 == 0)
                {
                    boja1 = Color.FromArgb(245, 114, 43);
                    boja2 = Color.Black;
                }
                else
                {
                    boja1 = Color.Black;
                    boja2 = Color.FromArgb(245, 114, 43);
                }

                nacrtajKruzniIsjecak(g, centar, poluprecnik1, i * 18 + 9, boja1, olovka);
                nacrtajKruzniIsjecak(g, centar, poluprecnik2, i * 18 + 9, boja2, olovka);
                nacrtajKruzniIsjecak(g, centar, poluprecnik3, i * 18 + 9, boja1, olovka);
                nacrtajKruzniIsjecak(g, centar, poluprecnik4, i * 18 + 9, boja2, olovka);
            }
            nacrtajCentarSaSlikom(g, centar, poluprecnik);
        }

        private void nacrtajCentarSaSlikom(Graphics g, Point centar, int poluprecnik)
        {
            Image logo = Properties.Resources.logo;

            int poluprecnikCrnogKruga = (int)(0.16 * poluprecnik);
            int poluprecnikSlike = (int)(0.11 * poluprecnik);

            Rectangle crniKrugRect = new Rectangle(centar.X - poluprecnikCrnogKruga, centar.Y - poluprecnikCrnogKruga,
                2 * poluprecnikCrnogKruga, 2 * poluprecnikCrnogKruga);
            g.DrawEllipse(new Pen(Color.White, velicinaOlovke), crniKrugRect);
            g.FillEllipse(new SolidBrush(Color.Black), crniKrugRect);

            Rectangle slikaRect = new Rectangle(centar.X - poluprecnikSlike, centar.Y - poluprecnikSlike,
                2 * poluprecnikSlike, 2 * poluprecnikSlike);
            g.DrawEllipse(new Pen(Color.White, velicinaOlovke), slikaRect);
            g.DrawImage(logo, slikaRect);
        }

        private void nacrtajKrugSaBrojevima(Graphics g, Point centar, int poluprecnik)
        {
            int[] broj = { 6, 10, 15, 2, 17, 3, 19, 7, 16, 8, 11, 14, 9, 12, 5, 20, 1, 18, 4, 13 };

            int poluprecnikKruga = (int)(0.98 * poluprecnik);
            int poluprecnikSredinePrstena = (int)(0.87 * poluprecnik);

            Font font = new Font("Calibri", (poluprecnik - poluprecnikKruga) * 6);
            StringFormat format = new StringFormat();
            format.Alignment = StringAlignment.Center;
            format.LineAlignment = StringAlignment.Center;

            Rectangle krugSaBrojevima = new Rectangle(centar.X - poluprecnikKruga, centar.Y - poluprecnikKruga,
                2 * poluprecnikKruga, 2 * poluprecnikKruga);
            g.FillEllipse(new SolidBrush(Color.Black), krugSaBrojevima);

            for (int i = 0; i < 20; i++)
            {
                int x = centar.X + (int)(Math.Cos(DegToRad(i * 18)) * poluprecnikSredinePrstena);
                int y = centar.Y + (int)(Math.Sin(DegToRad(i * 18)) * poluprecnikSredinePrstena);
                Point centarBroja = new Point(x, y);
                g.DrawString(broj[i].ToString(), font, new SolidBrush(Color.White), centarBroja, format);
            }

            nacrtajTablu(g, centar, poluprecnik);
            nacrtajStrelice(g, centar, poluprecnik);
        }

        private void nacrtajStrelice(Graphics g, Point centar, int poluprecnik)
        {
            Image strelice = Properties.Resources.strelice;
            Rectangle crvenaStrelica = new Rectangle(0, 0, strelice.Width / 2, strelice.Height);
            Rectangle plavaStrelica = new Rectangle(strelice.Width / 2, 0, strelice.Width / 2, strelice.Height);

            Point pozicijaStrelice =
                new Point(centar.X + (int)(poluprecnik * 0.12), centar.Y + (int)(poluprecnik * 0.22));
            g.DrawImage(strelice, new Rectangle(pozicijaStrelice, new Size(30, 30)), crvenaStrelica, GraphicsUnit.Pixel);
            pozicijaStrelice =
                new Point(centar.X + (int)(poluprecnik * 0.38), centar.Y - (int)(poluprecnik * 0.18));
            g.DrawImage(strelice, new Rectangle(pozicijaStrelice, new Size(30, 30)), crvenaStrelica, GraphicsUnit.Pixel);
            pozicijaStrelice =
                new Point(centar.X - (int)(poluprecnik * 0.41), centar.Y + (int)(poluprecnik * 0.07));
            g.DrawImage(strelice, new Rectangle(pozicijaStrelice, new Size(30, 30)), crvenaStrelica, GraphicsUnit.Pixel);

            pozicijaStrelice =
                new Point(centar.X - (int)(poluprecnik * 0.15), centar.Y + (int)(poluprecnik * 0.42));
            g.DrawImage(strelice, new Rectangle(pozicijaStrelice, new Size(30, 30)), plavaStrelica, GraphicsUnit.Pixel);
            pozicijaStrelice =
                new Point(centar.X - (int)(poluprecnik * 0.24), centar.Y - (int)(poluprecnik * 0.09));
            g.DrawImage(strelice, new Rectangle(pozicijaStrelice, new Size(30, 30)), plavaStrelica, GraphicsUnit.Pixel);
            pozicijaStrelice =
                new Point(centar.X + (int)(poluprecnik * 0.51), centar.Y + (int)(poluprecnik * 0.13));
            g.DrawImage(strelice, new Rectangle(pozicijaStrelice, new Size(30, 30)), plavaStrelica, GraphicsUnit.Pixel);



        }

        private void nacrtajNaziv(Graphics g, Point tacka, float velicinaFonta, Color boja)
        {
            string naziv = "Pikado 18.04.2020.";

            Font font = new Font("Calibri", velicinaFonta, FontStyle.Bold | FontStyle.Italic);
            StringFormat format = new StringFormat();
            format.LineAlignment = StringAlignment.Far;
            format.Alignment = StringAlignment.Center;

            g.DrawString(naziv, font, new SolidBrush(Color.Black), tacka, format);
            tacka.X -= 1;
            tacka.Y -= 1;
            g.DrawString(naziv, font, new SolidBrush(boja), tacka, format);
            ;

        }

        private void nacrtajPotpis(Graphics g, Point tacka, float velicinaFonta, Color boja)
        {
            string potpis = "Jovana Golijanin, 16038";

            Font font = new Font("Calibri", velicinaFonta, FontStyle.Bold | FontStyle.Italic);
            StringFormat format = new StringFormat();
            format.LineAlignment = StringAlignment.Near;
            format.Alignment = StringAlignment.Center;

            g.DrawString(potpis, font, new SolidBrush(Color.Black), tacka, format);
            tacka.X -= 1;
            tacka.Y -= 1;
            g.DrawString(potpis, font, new SolidBrush(boja), tacka, format);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            Invalidate();
        }
    }
}