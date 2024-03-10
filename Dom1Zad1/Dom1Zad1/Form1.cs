namespace Dom1Zad1
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

            Pen olovka = new Pen(Color.Red);
            olovka.Width = 5f;

            //g.DrawLine(olovka, 50, 50, 250, 50);
            //g.DrawLine(olovka, 250, 50, 150, 50);
            //g.DrawLine(olovka, 150, 50, 50, 50);

            Point[] tacke = new Point[]
            {
                new Point(50, 50),
                new Point(250, 50),
                new Point(150, 150)

            };

            g.DrawPolygon(olovka, tacke);
        }
    }
}