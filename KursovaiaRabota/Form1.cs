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
    public partial class Form1 : Form
    {
        public Point location;
        Random rnd;

        RobotClass robot = new RobotClass();

        public Form1()
        {
            InitializeComponent();
            MessageBox.Show("Выбирете алгоритм и поставьте точку");
            rnd = new Random();
        }


        //создание и обозначения метода Draw для рисования в форме
        private void Draw(bool flag)
        {
            //Подключаем Bitmap, который используется для работы с изображениями
            //определяемыми данными пикселей 
            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            //Grahp инкапусулирует поверхность Bitmap для рисования 
            Graphics graph = Graphics.FromImage(bmp);
            
            //Инициализируем ручку, которая и будет визуализировать движение пылесоса 
            Pen pen = new Pen(Color.Black);
            //Rectangle rect = new Rectangle(0, 0, pictureBox1.Width, pictureBox1.Height);
            //graph.DrawRectangle(new Pen(Color.Red, 3), rect);
            //передаём точку начала движения и вызываем метод, который реализует наш алгоритм 

            int n = 10000;
            if (flag)
            {   
                HaoticForm f = new HaoticForm();
                f.Owner = this;
                f.ShowDialog();
                robot.Algo1(location, graph, f.IterCnt(), rnd, pictureBox1);
            }
            else
                robot.Algo2(location, graph, n, rnd, pictureBox1);

            pictureBox1.Image = bmp;
        }

        

        private void Start_Click(object sender, EventArgs e)
        {
            bool flag = false;
            if (comboBox1.Text.Equals("Хаотический алгоритм"))
            {
                flag = true;
            }
            Draw(flag);
        }
        //функция считывает координты нажатия на picturebox
        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            location = pictureBox1.PointToClient(Cursor.Position);
        }   

        private void buttonShow1_Click(object sender, EventArgs e)
        {
            Analization f = new Analization();
            f.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
