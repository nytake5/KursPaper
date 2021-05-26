using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ShowForm1 : Form
    {
        int pWidth;
        int pHeight;
        int N;
        RobotClass robot1 = new RobotClass();
        Random rnd;
        public ShowForm1()
        {
            InitializeComponent();
            rnd = new Random();
        }

        public void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics graph = Graphics.FromImage(bmp);
            Point point = new Point(rnd.Next(0, Width), rnd.Next(0, Height));
            robot1.Algo1(point, graph, N, rnd, pictureBox1);
            pictureBox1.Image = bmp;
        }

        public void Set(int tWidth, int tHeight, int N)
        {
            this.pWidth = tWidth;
            this.pHeight = tHeight;
            this.N = N;
            Size MySize = new Size(tWidth, tHeight);
            this.Size = MySize;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Draw();
        }
    }
}
