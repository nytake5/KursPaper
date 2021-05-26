using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Analization : Form
    {
        RobotClass robot1 = new RobotClass();
        RobotClass robot2 = new RobotClass();
        Random rnd;
        public Analization()
        {
            InitializeComponent();
            rnd = new Random();
        }

        private void Analization_Load(object sender, EventArgs e)
        {
            int[] Width = new int[3] {100, 350, 750},
                Height = new int[3] { 100, 200, 500};
            int[] n = new int[3] { 100, 1000, 10000 };
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    PictureBox pic1 = new PictureBox();
                    PictureBox pic2 = new PictureBox();
                    pic1.Width = Width[i];
                    pic1.Height = Height[i];
                    pic2.Width = Width[i];
                    pic2.Height = Height[i];
                    Bitmap bmp1 = new Bitmap(pic1.Width, pic1.Height);
                    Graphics graph1 = Graphics.FromImage(bmp1);
                    Bitmap bmp2 = new Bitmap(pic2.Width, pic2.Height);
                    Graphics graph2 = Graphics.FromImage(bmp2);
                    Point point = new Point(rnd.Next(0, Width[i]), rnd.Next(0, Height[i]));
                    robot1.Algo1(point, graph1, n[j], rnd, pic1); 
                    robot2.Algo2(point, graph2, n[j], rnd, pic2);
                    dataGridView1.Rows.Add(Width[i] * Height[i], n[j], robot1.getCleanSurface(bmp1, pic1), robot2.getCleanSurface(bmp2, pic2));
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Width = int.Parse(textBoxWid.Text);
            int Height = int.Parse(textBoxHeig.Text);
            int N = int.Parse(textBoxN.Text);
            PictureBox pic1 = new PictureBox();
            PictureBox pic2 = new PictureBox();
            pic1.Width = Width;
            pic1.Height = Height;
            pic2.Width = Width;
            pic2.Height = Height;
            Bitmap bmp1 = new Bitmap(pic1.Width, pic1.Height);
            Graphics graph1 = Graphics.FromImage(bmp1);
            Bitmap bmp2 = new Bitmap(pic2.Width, pic2.Height);
            Graphics graph2 = Graphics.FromImage(bmp2);
            Point point = new Point(rnd.Next(0, Width), rnd.Next(0, Height));
            robot1.Algo1(point, graph1, N, rnd, pic1);
            robot2.Algo2(point, graph2, N, rnd, pic2);
            dataGridView1.Rows.Add(Width * Height, N, robot1.getCleanSurface(bmp1, pic1), robot2.getCleanSurface(bmp2, pic2));


            ShowForm1 f1 = new ShowForm1();
            f1.Set(Width, Height, N);
            f1.Show();

            ShowForm2 f2 = new ShowForm2();
            f2.Set(Width, Height, N);
            f2.Show();
        }

    }
}
