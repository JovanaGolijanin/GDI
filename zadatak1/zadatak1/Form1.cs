using System.Drawing.Drawing2D;

namespace zadatak1
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
            Pen olovka1 = new Pen(Color.Orange);
            g.PageScale = 3.5f;

            Rectangle rect1 = new Rectangle(10, 10, 80, 80);
            g.DrawEllipse(olovka1 , rect1 );
            g.FillEllipse(new SolidBrush(Color.Orange), rect1 );

            Pen olovka2 = new Pen(Color.Yellow);
            Rectangle rect2 = new Rectangle(20, 20, 60, 60);
            g.DrawEllipse (olovka2 , rect2 );
            g.FillEllipse(new SolidBrush(Color.Yellow), rect2 );

            olovka1.Width = 5f;

            olovka1.LineJoin = LineJoin.Round;  
            olovka1.StartCap = LineCap.Round;


           

            GraphicsPath path = new GraphicsPath(FillMode.Alternate);

            Rectangle rect3 = new Rectangle(30, 30, 40, 40);

            
            path.AddLine(30, 50, 70, 50);
            path.AddArc(rect3, 0, 180);
            //path.AddEllipse(oko1);
            //path.AddEllipse(oko2);

            //g.FillPath(new SolidBrush(Color.Orange), path);
            //g.FillEllipse(new SolidBrush(Color.Orange), oko1);
            //g.FillEllipse(new SolidBrush (Color.Orange), oko2);

            g.DrawPath(olovka1, path);


            RectangleF oko1 = new RectangleF(40f, 40f, 1f, 1f);
            RectangleF oko2 = new RectangleF(60f, 40f, 1f, 1f);
            //g.DrawEllipse(olovka1, oko1 );
            //g.DrawEllipse(olovka1, oko2 );

            //g.FillEllipse(new SolidBrush(Color.Orange), oko1);
            //g.FillEllipse(new SolidBrush(Color.Orange), oko2);
            GraphicsPath oci = new GraphicsPath();
            oci.AddArc(oko1, 0, 360);
            oci.AddArc(oko2, 0, 360);

            Brush brush = new SolidBrush(Color.Orange);
            g.FillPath(brush, oci);
            Pen narandzasta = new Pen(Color.Orange);
            narandzasta.Width = 10f;
            g.DrawPath (narandzasta, oci );
            
            
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            Invalidate();
        }
    }
}