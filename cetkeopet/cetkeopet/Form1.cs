using System.Drawing.Drawing2D;

namespace cetkeopet
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

            LinearGradientBrush cetka1 = new LinearGradientBrush(new Point(40, 40), new Point(500, 500),
                Color.Black, Color.White);
            g.FillRectangle(cetka1, new Rectangle(40, 40, 500, 500));
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            Invalidate();
        }
    }
}