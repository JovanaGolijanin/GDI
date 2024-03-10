using cetke.Properties;
using System.Drawing.Drawing2D;

namespace cetke
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

            Image drvo = Properties.Resources.drvo2;
            TextureBrush tb = new TextureBrush(drvo); 
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            Invalidate();
        }
    }
}