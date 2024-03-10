namespace Dom1Zad3
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

            g.DrawRectangle(olovka, 50, 50, 50, 50);
        }
    }
}