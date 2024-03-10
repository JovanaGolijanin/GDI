using System.Drawing.Drawing2D;

namespace zadatak2
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
            Pen olovka = new Pen(Color.Blue);
            olovka.Width = 0.05f;
            olovka.LineJoin = LineJoin.Miter;
            g.PageUnit = GraphicsUnit.Inch;
            
            GraphicsPath path = new GraphicsPath();
            path.AddArc(new Rectangle(1, 1, 1, 1), 180, 90);
            path.AddLine(1.5f, 1, 3, 1);
            path.AddLine(3, 1, 3, 2);
            path.AddArc(new RectangleF(1.5f, 2, 3, 3), 270, -180);
            path.AddLine(3, 5, 3, 6);
            path.AddLine(3, 6, 1.5f, 6);
            path.AddArc(new Rectangle(1, 5, 1, 1), 90, 90);
            path.AddLine(1, 5.5f, 1, 1.5f);

            g.FillPath(new SolidBrush(Color.Orange), path);
            g.DrawPath(olovka, path);

            g.DrawEllipse(olovka, new RectangleF(1.3f, 1.3f, 0.40f, 0.40f));
            g.FillEllipse(new SolidBrush(Color.White), new RectangleF(1.3f, 1.3f, 0.40f, 0.40f));

            g.DrawEllipse(olovka, new RectangleF(1.3f, 5.3f, 0.40f, 0.40f));
            g.FillEllipse(new SolidBrush(Color.White), new RectangleF(1.3f, 5.3f, 0.40f, 0.40f));

            g.DrawEllipse(olovka, new RectangleF(6.5f, 2, 3, 3));
            g.FillEllipse(new SolidBrush(Color.Orange), new RectangleF(6.5f, 2, 3, 3));

            GraphicsPath gp = new GraphicsPath();
            gp.AddLine(7.80f, 3, 7.80f, 2.50f );
            gp.AddLine(7.80f, 2.50f, 8.20f, 2.50f);
            gp.AddLine(8.20f, 2.50f, 8.20f, 3);
            gp.AddArc(new RectangleF(7.50f, 3, 1, 1), 315, 295);
            

            g.DrawPath(olovka, gp);
            g.FillPath(new SolidBrush(Color.White), gp);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            Invalidate();
        }
    }
}