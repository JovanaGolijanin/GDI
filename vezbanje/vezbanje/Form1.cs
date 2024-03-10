using System.Drawing.Drawing2D;

namespace vezbanje
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

            Pen olovka = new Pen(Color.RebeccaPurple);
            olovka.Width = 3f;
            olovka.LineJoin = LineJoin.Round;
            g.PageScale = 3f;
            
            GraphicsPath path = new GraphicsPath(FillMode.Alternate);

            Rectangle rect1 = new Rectangle(50, 10, 80, 40);
            Rectangle rect2 = new Rectangle(50, 50, 80, 40);
            Rectangle rect3 = new Rectangle(60, 40, 60, 20);

            path.AddArc(rect1, 0, -180);
            path.AddLine(50, 30, 10, 30);
            path.AddLine(10, 30, 10, 70);
            path.AddLine(10, 70, 50, 70);
            path.AddArc(rect2, 180, -180);
            path.AddLine(130, 70, 170, 70);
            path.AddLine(170, 70, 170, 30);
            path.AddLine(170, 30, 130, 30);
            path.AddRectangle(rect3);

            g.DrawPath(olovka, path);

        

            Brush cetka = new SolidBrush(Color.Yellow);
            g.FillPath(cetka, path);
            


        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            Invalidate();
        }
    }
}