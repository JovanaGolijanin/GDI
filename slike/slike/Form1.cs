using System.Drawing.Imaging;

namespace slike
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

            //Point[] tacke = new Point[]
            //{
            //    new Point(3, 2),
            //    new Point(11, 2),
            //    new Point(3, 8)
            //};

            //Rectangle rect = new Rectangle(3,2,200,200);

            //g.PageScale = 20;

            //Image slika = Properties.Resources.slika;
            //g.DrawImage(slika, tacke, rect, GraphicsUnit.Point);

            ///////////////////

            //Image slika = Properties.Resources.slika;
            //Image pThumbail = slika.GetThumbnailImage(50, 50, null,
            //new IntPtr());
            //g.DrawImage(pThumbail, 40, 25, 50, 50);
            //Icon icon = new Icon(@"..\ikonica.ico", 128, 128);
            //g.DrawImage(icon.ToBitmap(), 30, 100, 80, 80);


            //////////////////

            Image slika = Properties.Resources.slika;
            ImageAttributes imageAttributes = new ImageAttributes();
            float[][] colorMatrixElements =
            {
                new float[]{2,0,0,0,0}, //faktor skaliranja crvene boje
                new float[]{0,1,0,0,0}, //faktor skaliranja zelene boje
                new float[]{0,0,1,0,0}, //faktor skaliranja plave boje
                new float[]{0,0,0,1,0}, //faktor skaliranja alpha parametra
                new float[]{.2f,.2f,.2f,0,1}
            };
            ColorMatrix matricaBoja = new ColorMatrix(colorMatrixElements);
            imageAttributes.SetColorMatrix(matricaBoja, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
            g.DrawImage(slika, new Point(10, 10));
            g.DrawImage(slika, new Rectangle(10, slika.Height + 30, slika.Width,
            slika.Height), 0, 0, slika.Width, slika.Height, GraphicsUnit.Pixel,
            imageAttributes);


        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            Invalidate();
        }
    }
}