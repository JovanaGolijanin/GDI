using System.Drawing.Drawing2D;

namespace sahDomaci
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

            int sirina = this.ClientRectangle.Width/8;
            int visina = this.ClientRectangle.Height/8;

            Image figure = Properties.Resources.figure;
            g.PageUnit = GraphicsUnit.Pixel;
            //zuti piun
            Rectangle zutiPiun = new Rectangle(325, 0, 50, 50);
            //beli piun
            Rectangle beliPiun = new Rectangle(325, 70, 50, 50);
            

            GraphicsPath gp = new GraphicsPath(FillMode.Alternate);
            int l = 1;
            for(int  i = 0; i < this.ClientRectangle.Height ; i++)
            {
                int k = 0;
                l++;
                for (int j = 0; j < this.ClientRectangle.Width; j++)
                {
                    
                    g.DrawRectangle(new Pen(Color.Chocolate), j * sirina, i * visina, sirina, visina);
                    if ((k+l) % 2 == 0)
                    {
                        g.FillRectangle(new SolidBrush(Color.Chocolate), j * sirina, i * visina, sirina, visina);

                    }
                    k++;

                    //zuti piuni
                    if(i==1)
                    {
                        g.DrawImage(figure, new RectangleF(j * sirina, i * visina, sirina, visina),
                            zutiPiun,GraphicsUnit.Pixel);
                    }

                    //beli piuni
                    if (i == 6)
                    {
                        g.DrawImage(figure, new RectangleF(j * sirina, i * visina, sirina, visina),
                            beliPiun, GraphicsUnit.Pixel);
                    }

                }
                
            }

            //zuti top levi
            Rectangle zutiTopLevi = new Rectangle(130, 0, 60, 60);
            g.DrawImage(figure, new RectangleF(0, 0, sirina, visina),zutiTopLevi, GraphicsUnit.Pixel);

            //zuti top desni
            Rectangle zutiTopdesni = new Rectangle(130, 0, 60, 60);
            g.DrawImage(figure, new RectangleF(sirina*7, 0, sirina, visina), zutiTopdesni, GraphicsUnit.Pixel);

            //zuti konj levi
            Rectangle zutiKonjLevi = new Rectangle(190, 0, 60, 60);
            g.DrawImage(figure, new Rectangle(sirina, 0, sirina, visina), zutiKonjLevi, GraphicsUnit.Pixel);

            //zuti konj desni
            Rectangle zutiKonjDesni = new Rectangle(190, 0, 60, 60);
            g.DrawImage(figure, new Rectangle(sirina*6,0, sirina, visina), zutiKonjDesni, GraphicsUnit.Pixel);

            //zuti lovac levi
            Rectangle zutiLovacLevi = new Rectangle(255, 0, 60, 60);
            g.DrawImage(figure, new Rectangle(sirina*2, 0, sirina, visina), zutiLovacLevi, GraphicsUnit.Pixel);

            //zuti lovac desni
            Rectangle zutiLovacDesni = new Rectangle(255, 0, 60, 60);
            g.DrawImage(figure, new Rectangle(sirina * 5, 0, sirina, visina), zutiLovacDesni, GraphicsUnit.Pixel);

            //zuta kraljica
            Rectangle zutaKraljica = new Rectangle(65, 0, 60, 60);
            g.DrawImage(figure, new Rectangle(sirina * 4, 0, sirina, visina), zutaKraljica, GraphicsUnit.Pixel);

            //zuti kralj
            Rectangle zutiKralj = new Rectangle(0, 0, 60, 60);
            g.DrawImage(figure, new Rectangle(sirina * 3, 0, sirina, visina), zutiKralj, GraphicsUnit.Pixel);

            //bei top levi
            Rectangle beliTopLevi = new Rectangle(130,65,60,60);
            g.DrawImage(figure, new Rectangle(0, visina*7, sirina, visina), beliTopLevi, GraphicsUnit.Pixel);

            //bei top desni
            Rectangle beliTopDesni = new Rectangle(130, 65, 60, 60);
            g.DrawImage(figure, new Rectangle(sirina*7, visina * 7, sirina, visina), beliTopDesni, GraphicsUnit.Pixel);

            //beli konj levi
            Rectangle beliKonjLevi = new Rectangle(190, 65, 60, 60);
            g.DrawImage(figure, new Rectangle(sirina, visina*7, sirina, visina), beliKonjLevi, GraphicsUnit.Pixel);

            //beli konj desni
            Rectangle beliKonjDesni = new Rectangle(190, 65, 60, 60);
            g.DrawImage(figure, new Rectangle(sirina*6, visina * 7, sirina, visina), beliKonjDesni, GraphicsUnit.Pixel);

            //beli lovac levi
            Rectangle beliLovacLevi = new Rectangle(255, 65, 60, 60);
            g.DrawImage(figure, new Rectangle(sirina *2, visina * 7, sirina, visina), beliLovacLevi, GraphicsUnit.Pixel);

            //beli lovac desni
            Rectangle beliLovacDesni = new Rectangle(255, 65, 60, 60);
            g.DrawImage(figure, new Rectangle(sirina * 5, visina * 7, sirina, visina), beliLovacDesni, GraphicsUnit.Pixel);

            //bela kraljica
            Rectangle belaKraljica = new Rectangle(60, 65, 60, 60);
            g.DrawImage(figure, new Rectangle(sirina * 4, visina * 7, sirina, visina), belaKraljica, GraphicsUnit.Pixel);

            //beli kralj
            Rectangle beliKralj = new Rectangle(0, 65, 60, 60);
            g.DrawImage(figure, new Rectangle(sirina * 3, visina * 7, sirina, visina), beliKralj, GraphicsUnit.Pixel);


        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            Invalidate();
        }
    }
}