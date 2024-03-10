using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using static System.Net.Mime.MediaTypeNames;

namespace Metfajlovi
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
            g.Clear(this.BackColor);
            IntPtr hdc = g.GetHdc();
            Metafile metafile = new
            Metafile(@"C:\Users\jovan\OneDrive\Desktop\metafajl.emf", hdc);
            Graphics g1 = Graphics.FromImage(metafile);
            Rectangle kvadrat = new Rectangle(0, 0, 200, 200);
            g1.FillRectangle(Brushes.Green, kvadrat);
            kvadrat.Y += 110;

            LinearGradientBrush gradientBrush = new LinearGradientBrush(kvadrat, Color.Red, Color.Blue,45.0f);
            g1.FillEllipse(gradientBrush, kvadrat);
            kvadrat.Y += 110;
            Font font = new Font("Vredana", 18, FontStyle.Bold |
            FontStyle.Italic);
            g1.DrawString("Racunarska grafika I. Sarajevo\nMetafile test", font, Brushes.Red, 200, 200, 
            StringFormat.GenericTypographic);
            g.ReleaseHdc();
            metafile.Dispose();
            g1.Dispose();

            metafile = new Metafile(@"C:\Users\jovan\OneDrive\Desktop\metafajl.emf");
            g.DrawImage(metafile, 0, 0);
            metafile.Dispose();

        }
    }
}