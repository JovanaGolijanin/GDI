using Microsoft.VisualBasic.Logging;

namespace Sat
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
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            DateTime dateTimeNow = DateTime.Now;
            float brojSati = dateTimeNow.Hour +(dateTimeNow.Minute/60)+1;

            NacrtajBrojeve(g, (int)(0.90 * manjaDimenzija()/2));
            nacrtajKazaljkuSate(g, (int)(0.90 * manjaDimenzija() / 2), brojSati);

        }

        private void nacrtajSat(Graphics g, float brojSati, float brojMinuta, float brojSek)
        {
            //nacrtajBrojeve

            //nacrtajKazaljkuSate
            //nacrtajKazaljkuMinute
            //nacrtajKazaljkuSekunde
        }

        private void nacrtajKazaljkuSate(Graphics g, int poluprecnik, float brojSati)
        {
            brojSati = brojSati>12 ?brojSati-12 : brojSati;

            double ugaoIzmedjuBrojeva = 360 / 12;
            double ugaoSata = -90 + brojSati * ugaoIzmedjuBrojeva;

            int x1 = ClientRectangle.Width / 2;
            int y1 = ClientRectangle.Height / 2;

            int x2 = ClientRectangle.Width / 2 + (int)(Math.Cos(DegToRad(ugaoSata))*poluprecnik*0.7);
            int y2 = ClientRectangle.Height / 2 + (int)(Math.Sin(DegToRad(ugaoSata)) * poluprecnik * 0.7);

            Pen olovka = new Pen(Color.DeepPink, 3f);
            g.DrawLine(olovka, x1, y1, x2, y2 );
        }
        private void NacrtajBrojeve(Graphics g, int poluprecnik)
        {
            double ugaoIzmedjuBrojeva = 360 / 12;
            Font font = new Font("Calibri", (int)(0.1 * poluprecnik), FontStyle.Bold);
            StringFormat format = new StringFormat();
            format.Alignment = StringAlignment.Center;
            format.LineAlignment = StringAlignment.Center;

            for (int i = 1; i <= 12; i++)
            {
                double ugaoBroja = -90 + i * ugaoIzmedjuBrojeva;
                int x = ClientRectangle.Width / 2 + (int)(Math.Cos(DegToRad(ugaoBroja)) * poluprecnik);
                int y = ClientRectangle.Height / 2 + (int)(Math.Sin(DegToRad(ugaoBroja)) * poluprecnik);

                g.DrawString(i.ToString(), font, new SolidBrush(Color.Black), new Point(x, y), format);
            }

        }

        private double DegToRad(double ugaoStepeni)
        {
            return ugaoStepeni * Math.PI / 180;
        }
        public int manjaDimenzija()
        {
            return ClientRectangle.Width < ClientRectangle.Height ? ClientRectangle.Width : ClientRectangle.Height;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            Invalidate();
        }
    }
}