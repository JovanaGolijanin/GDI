namespace Fontovi3
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

            Pen olovka = new Pen(Color.Aqua, 5.5f);
            g.PageUnit = GraphicsUnit.Millimeter;

            int sirina = this.ClientRectangle.Width;
            int visina = this.ClientRectangle.Height;

            Rectangle rect = new Rectangle(50, 50, 50, 50);
            g.DrawRectangle(olovka, rect);

            Font font = new Font("Arial", 20, FontStyle.Regular);
            StringFormat stringFormat = new StringFormat();
            stringFormat.LineAlignment = StringAlignment.Center;
            //stringFormat.Alignment = StringAlignment.Center;
            stringFormat.FormatFlags = StringFormatFlags.FitBlackBox;
            stringFormat.FormatFlags |= StringFormatFlags.LineLimit;
            g.DrawString("duzina", font, new SolidBrush(Color.Black), new Rectangle(50,100,50,10), stringFormat);

            Font font2 = new Font("Arial", 20, FontStyle.Regular);
            StringFormat format = new StringFormat();
            format.LineAlignment = StringAlignment.Center;
            //format.Alignment = StringAlignment.Center;
            format.FormatFlags = StringFormatFlags.DirectionVertical;

            g.DrawString("visina", font2, new SolidBrush(Color.Black), new Rectangle(110, 60, 10, 50), format);

        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            Invalidate();   
        }
    }
}