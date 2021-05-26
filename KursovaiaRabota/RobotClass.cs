using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace WindowsFormsApp1
{
   
    public class RobotClass
    {
        private double _distance = 0;
        private int _speed;
        private double _time;

        Pen _pen = new Pen(Color.Black);

        public RobotClass()
        {
            _speed = 1;
            _time = 0;
        }

        public RobotClass(int speed)
        {
            this._speed = speed;
        }

        public void sumDistAndDraw(long x, long y, long xT, long yT, System.Windows.Forms.PictureBox pictureBox1, Graphics graph)
        {
            graph.DrawLine(_pen, x, y, xT, yT);

            _distance += Math.Sqrt(Math.Pow(xT - x, 2) + Math.Pow(yT - y, 2));
        }
        public double GetDistance()
        {
            return _distance;
        }

        public string getCleanSurface(Bitmap bmp, PictureBox pictureBox)
        {
            double clearPointCnt = 0;
            for (int i = 0; i < pictureBox.Width; i++)
            {
                for (int j = 0; j < pictureBox.Height; j++)
                {
                    Color color = bmp.GetPixel(i, j);

                    if (color.ToArgb() == Color.Black.ToArgb())
                        clearPointCnt++;
                }
            }
            double temp = (clearPointCnt / (pictureBox.Width * pictureBox.Height)) * 100;
            return temp.ToString("00.00");
        }

        public double getTime()
        {
            _time += _distance / _speed;
            return _time;
        }

        public void nullDist()
        {
            _distance = 0;
        }
        public void Algo2(Point location, Graphics graph, int n, Random rnd, PictureBox pictureBox)
        {
            #region Реализация движения
            this.nullDist();
            int x = location.X,
                y = location.Y;
            int xT, yT, b;
            int temp = rnd.Next(0, 360);
            double value = temp;
            value = value * (Math.PI / 180);
            if (value < 0)
            {
                value += 2 * Math.PI;
            }
            if (value < Math.PI / 2)
            {
                b = (y - (int)(Math.Tan(value) * x));
                xT = pictureBox.Width;
                yT = (int)(Math.Tan(value) * x) + b;
                if (yT > pictureBox.Height || yT < 0)
                {
                    yT = pictureBox.Height;
                    xT = (int)((yT - b) / Math.Tan(value));
                }
                this.sumDistAndDraw(x, y, xT, yT, pictureBox, graph);
                x = xT;
                y = yT;
            }
            else if (value > Math.PI / 2 && value < Math.PI)
            {

                b = (y - (int)(Math.Tan(value) * x));
                yT = pictureBox.Height;
                xT = (int)((yT - b) / Math.Tan(value));
                if (xT > pictureBox.Width || xT < 0)
                {
                    xT = 0;
                    yT = (int)(Math.Tan(value) * x) + b;
                }
                this.sumDistAndDraw(x, y, xT, yT, pictureBox, graph);
                x = xT;
                y = yT;

            }
            else if (value > Math.PI && value < Math.PI * 3 / 2)
            {
                b = (y - (int)(Math.Tan(value) * x));
                xT = 0;
                yT = b;
                if (yT > pictureBox.Height || yT < 0)
                {
                    yT = 0;
                    xT = (int)(-b / Math.Tan(value));
                }
                this.sumDistAndDraw(x, y, xT, yT, pictureBox, graph);
                x = xT;
                y = yT;
            }
            else
            {
                b = (y - (int)(Math.Tan(value) * x));
                yT = 0;
                xT = (int)(-b / Math.Tan(value));
                if (xT > pictureBox.Width || xT < 0)
                {
                    xT = pictureBox.Width;
                    yT = (int)(Math.Tan(value) * xT) + b;
                }
                this.sumDistAndDraw(x, y, xT, yT, pictureBox, graph);
                x = xT;
                y = yT;
            }
            int xOst = x, yOst = y;
            Pen pen1 = new Pen(Color.Black);
            graph.DrawRectangle(pen1, 0, 0, pictureBox.Width, pictureBox.Height);
            if (x == pictureBox.Width && y > 0)
            {
                while (x > 0 && n > 0)
                {
                    this.sumDistAndDraw(x, y, x - 2, 0, pictureBox,  graph);
                    x -= 2;
                    y = 0;
                    this.sumDistAndDraw(x, y, x - 2, pictureBox.Height, pictureBox,  graph);
                    x -= 2;
                    y = pictureBox.Height;
                    n--;
                }

            }
            else if (x > 0 && y == 0)
            {
                while (y < pictureBox.Height && n > 0)
                {
                    this.sumDistAndDraw(x, y, 0, y + 2, pictureBox,  graph);
                    x = 0;
                    y += 2;
                    this.sumDistAndDraw(x, y, pictureBox.Width, y + 2, pictureBox,  graph);
                    y += 2;
                    x = pictureBox.Width;
                    n--;
                }
            }
            else if (x == 0 && y <= pictureBox.Height)
            {
                while (x < pictureBox.Width && n > 0)
                {
                    this.sumDistAndDraw(x, y, x + 2, 0, pictureBox, graph);
                    x += 2;
                    y = 0;
                    this.sumDistAndDraw(x, y, x + 2, pictureBox.Height, pictureBox, graph);
                    x += 2;
                    y = pictureBox.Height;
                    n--;
                }
            }
            else if (x <= pictureBox.Width && y == pictureBox.Height)
            {
                while (y > 0 && n > 0)
                {
                    this.sumDistAndDraw(x, y, 0, y - 2, pictureBox, graph);
                    x = 0;
                    y -= 2;
                    this.sumDistAndDraw(x, y, pictureBox.Width, y - 2, pictureBox,  graph);
                    y -= 2;
                    x = pictureBox.Width;
                    n--;
                }
            }
            #endregion
        }
        public void Algo1(Point location, Graphics graph, int n, Random rnd, PictureBox pictureBox)
        {
            #region Реализация движения
            
            this.nullDist();
            bool flag1, flag2, flag3, flag4;
            flag1 = false;
            flag2 = false;
            flag3 = false;
            flag4 = false;
            long x = location.X,
                y = location.Y;
            long xT, yT, b;

            //Создание объекта для генерации чисел (с указанием начального значения)
            for (int i = n; i > 0; i--)
            {
                //Получить случайное число 
                int temp;
                if (flag1)
                {
                    temp = rnd.Next(180, 360);
                }
                else if (flag2)
                {
                    temp = rnd.Next(-90, 90);
                }
                else if (flag3)
                {
                    temp = rnd.Next(0, 180);
                }
                else if (flag4)
                {
                    temp = rnd.Next(90, 270);
                }
                else
                {
                    temp = rnd.Next(0, 360);
                }
                double value = temp;
                value = value * (Math.PI / 180);
                if (value < Math.PI/2)
                {
                    b = (y - (int)(Math.Tan(value) * x));
                    xT = pictureBox.Width;
                    yT = (int)(Math.Tan(value) * x) + b;
                    flag1 = false;
                    flag2 = false;
                    flag3 = false;
                    flag4 = true;
                    if (yT > pictureBox.Height || yT < 0)
                    {
                        yT = pictureBox.Height;
                        xT = (int)((yT - b) / Math.Tan(value));
                        flag1 = true;
                        flag2 = false;
                        flag3 = false;
                        flag4 = false;
                    }
                    this.sumDistAndDraw(x, y, xT, yT, pictureBox, graph);
                    x = xT;
                    y = yT;

                    
                }
                else if (value > Math.PI/2 && value < Math.PI)
                {

                    b = (y - (int)(Math.Tan(value) * x));
                    yT = pictureBox.Height;
                    xT = (int)((yT - b) / Math.Tan(value));
                    flag1 = true;
                    flag2 = false;
                    flag3 = false;
                    flag4 = false;
                    if (xT > pictureBox.Width || xT < 0)
                    {
                        xT = 0;
                        yT = (int)(Math.Tan(value) * x) + b;
                        flag1 = false;
                        flag2 = true;
                        flag3 = false;
                        flag4 = false;
                    }
                    this.sumDistAndDraw(x, y, xT, yT, pictureBox, graph);
                    x = xT;
                    y = yT;

                }
                else if (value > Math.PI && value < Math.PI*3/2)
                {
                    b = (y - (int)(Math.Tan(value) * x));

                    xT = 0;
                    yT = b;
                    flag1 = false;
                    flag2 = true;
                    flag3 = false;
                    flag4 = false;
                    if (yT > pictureBox.Height || yT < 0)
                    {
                        yT = 0;
                        xT = (int)(-b / Math.Tan(value));
                        flag1 = false;
                        flag2 = false;
                        flag3 = true;
                        flag4 = false;
                    }
                    this.sumDistAndDraw(x, y, xT, yT, pictureBox, graph);
                    x = xT;
                    y = yT;
                }
                else
                {
                    b = (y - (int)(Math.Tan(value) * x));
                    yT = 0;
                    xT = (int)(-b / Math.Tan(value));
                    flag1 = false;
                    flag2 = false;
                    flag3 = true;
                    flag4 = false;
                    if (xT > pictureBox.Width || xT < 0)
                    {
                        xT = pictureBox.Width;
                        yT = (int)(Math.Tan(value) * xT) + b;
                        flag1 = false;
                        flag2 = false;
                        flag3 = false;
                        flag4 = true;
                    }
                    this.sumDistAndDraw(x, y, xT, yT, pictureBox, graph);
                    x = xT;
                    y = yT;
                }
                
            }
            #endregion
        }

    }
}