using System.Drawing.Imaging;

namespace _3termin
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

            //Brush cetka = new SolidBrush(Color.BlueViolet);
            //FontStyle stil = FontStyle.Bold | FontStyle.Italic;
            //Font font = new Font("Arial", 25, stil, GraphicsUnit.Millimeter);
            //PointF tacka = new PointF(50, 50);

            //g.DrawString("Racunarska grafika\nElektrotehnikci fakultet", font, cetka, tacka);

            //Brush cetka = new SolidBrush(Color.DeepPink);
            //FontStyle stil = FontStyle.Bold | FontStyle.Italic;
            //Font font = new Font("Arial", 6, stil, GraphicsUnit.Millimeter);
            //PointF tacka = new PointF(100, 30);

            //StringFormat format = new StringFormat();
            //format.Alignment = StringAlignment.Near;
            //format.LineAlignment = StringAlignment.Far;
            //format.FormatFlags = StringFormatFlags.DirectionVertical;

            //g.DrawString("Racunarska grafika\nETF", font, cetka, tacka, format);

            //Point[] tacke = new Point[]
            //{
            //    new Point(10, 10),
            //    new Point(700, 10),
            //    new Point(10, 700)
            //};

            //g.DrawImage(Image.FromFile("C:\\Users\\jovan\\OneDrive\\Desktop\\slika.jpg"), new Point(10,10));
            //g.DrawImage(Image.FromFile("C:\\Users\\jovan\\OneDrive\\Desktop\\slika.jpg"),tacke,
            //    new Rectangle(10, 10, 400, 400), GraphicsUnit.Pixel );


            //g.DrawImage(Image.FromFile("C:\\Users\\jovan\\OneDrive\\Desktop\\slika.jpg"), new Rectangle(200, 200, 300, 300),
            //    new Rectangle(10, 10, 300, 300), GraphicsUnit.Pixel);

            //g.DrawImage(Image.FromFile("C:\\Users\\jovan\\OneDrive\\Desktop\\bmp.bmp"), new Rectangle(200, 200, 300, 300),
            //    new Rectangle(10, 10, 300, 300), GraphicsUnit.Pixel);

            //g.DrawImage(Image.FromFile("C:\\Users\\jovan\\OneDrive\\Desktop\\gif.gif"), new Rectangle(200, 200, 300, 300),
            //    new Rectangle(10, 10, 300, 300), GraphicsUnit.Pixel);

            //g.DrawImage(Image.FromFile("C:\\Users\\jovan\\OneDrive\\Desktop\\exif.avif"), new Rectangle(200, 200, 300, 300),
            //    new Rectangle(10, 10, 300, 300), GraphicsUnit.Pixel);

            //g.DrawImage(Image.FromFile("C:\\Users\\jovan\\OneDrive\\Desktop\\png.png"), new Rectangle(200, 200, 300, 300),
            //    new Rectangle(10, 10, 500, 500), GraphicsUnit.Pixel);

            //Bitmap pozadina = Properties.Resources.slika;
            //g.DrawImage(pozadina, new Point(10, 10));


            //Bitmap pozadina = Properties.Resources.slika;
            //ImageAttributes imageAttributes = new ImageAttributes();

            //float[][] matrix =
            //{
            //    new float[] {3, 0, 0, 0, 0},
            //    new float[] {0, 1, 0, 0, 0},
            //    new float[] {0, 0, 1, 0, 0},
            //    new float[] {0, 0, 0, 1, 0},
            //    new float[] {.3f, .3f, .3f, 0, 1}
            //};

            //ColorMatrix matricaBoja = new ColorMatrix(matrix);
            //imageAttributes.SetColorMatrix(matricaBoja, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);

            //g.DrawImage(pozadina, new Rectangle(0, 0, 500, 500),
            //    0, 0, pozadina.Width, pozadina.Height, GraphicsUnit.Pixel, imageAttributes);

            //g.DrawImage(Image.FromFile("C:\\Users\\jovan\\OneDrive\\Desktop\\chess.jpg"), new Rectangle(0, 0, 300, 300),
            //    new Rectangle(6, 14, 87, 172), GraphicsUnit.Pixel);


            g.Clear(this.BackColor);

            IntPtr hdc = g.GetHdc();

            Metafile metafile = new Metafile("C:/Users/jovan/OneDrive/Desktop/test.emf", hdc);

            Graphics g1 = Graphics.FromImage(metafile);

            Rectangle kvadrat = new Rectangle(10, 10, 200, 200);
            g1.DrawRectangle(new Pen(Color.BlueViolet), kvadrat);
            g1.FillRectangle(new SolidBrush(Color.DeepPink), kvadrat);

            Brush cetka = new SolidBrush(Color.Blue);
            FontStyle stil = FontStyle.Bold | FontStyle.Underline;
            Font font = new Font("Arial", 14, stil);
            g1.DrawString("Racunarska grafika - ETF", font, cetka, 50, 50);

            g.ReleaseHdc(hdc);
            //metafile.Dispose();
            g1.Dispose();

            g.DrawImage(metafile, 0, 0);

        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            Invalidate();   
        }
    }
}