namespace Fontovi
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

            Pen olovka = new Pen(Color.BlueViolet);
            olovka.Width = 3f;

            String tekst = "BESKONACNOST";
            int k = 0;
           

            int sirina = this.ClientRectangle.Width/4;
            int visina = this.ClientRectangle.Height/3;

            for (int  i = 0; i < 3; i++)
            {
                for(int j = 0; j < 4; j++)
                {
                    g.DrawEllipse(olovka, j*sirina, i*visina,  sirina, visina );
                }
                
            }
            
            
            Font font = new Font("Arial", 20, FontStyle.Bold);

            Brush brush = new SolidBrush(Color.Indigo);

            for (int i = 0;i<3; i++)
            {
                for(int j=0;j<4; j++)
                {
                    g.DrawString(tekst[k].ToString(), font, brush, new PointF(j * sirina+sirina/4, i * visina+visina/3) );
                    k++;
                }
            }

        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            Invalidate();
        }
    }
}