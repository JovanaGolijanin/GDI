namespace Fontovi2
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

            Pen olovka1 = new Pen(Color.Blue);
            Font font1 = new Font("Times New Roman", 20, FontStyle.Regular);
            g.DrawString("Класа Font налази се у простору имена System.Drawing", 
                font1, new SolidBrush(Color.Blue), new Point(20, 20));

            Pen olovka2 = new Pen(Color.Orange);
            Font font2 = new Font("Algerian", 15, FontStyle.Italic);
            g.DrawString("Klasa Font nalazi se u prostoru imena System.Drawing",
                font2, new SolidBrush(Color.Orange), new Point(20, 60));

            Pen olovka3 = new Pen(Color.Green);
            Font font3 = new Font("Calibri", 20, FontStyle.Bold);
            g.DrawString("Klasa Font nalazi se u prostoru imena System.Drawing",
                font3, new SolidBrush(Color.Green), new Point(20, 100));

            Pen olovka4 = new Pen(Color.LightBlue);
            Font font4 = new Font("Arial", 20, FontStyle.Underline);
            g.DrawString("Klasa Font nalazi se u prostoru imena System.Drawing",
                font4, new SolidBrush(Color.LightBlue), new Point(20, 140));

            Pen olovka5 = new Pen(Color.Red);
            Font font5 = new Font("Monotype Corsiva", 12, FontStyle.Strikeout);
            StringFormat format = new StringFormat();
            format.FormatFlags = StringFormatFlags.FitBlackBox;
            g.DrawString("Klasa Font nalazi se u prostoru imena System.Drawing",
                font5, new SolidBrush(Color.Red), new Point(20, 180), format);

            Pen olovka6 = new Pen(Color.Purple);
            Font font6 = new Font("Monotype Corsiva", 18, FontStyle.Underline | FontStyle.Bold);
            StringFormat format2 = new StringFormat();
            format2.FormatFlags = StringFormatFlags.FitBlackBox;
            g.DrawString("Klasa Font nalazi se u prostoru imena System.Drawing",
                font6, new SolidBrush(Color.Purple), new Point(20, 220), format2);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            Invalidate();
        }
    }
}