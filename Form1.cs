using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Графика
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string a = "";
        List<List<Point>> list;
        DateTime dt;
        int h, m, s;
        int r;
        int[] x;
        int[] y;
        Random r0;
        int[] dx;
        int[] dy;
        Color[] color;
        int a2, b, wx, wy, fx, fy;

        private void button1_Click(object sender, EventArgs e)
        {    
            if (radioButton1.Checked == true)
            {
                r = 1;
                pictureBox1.Refresh();
            }
            if (radioButton2.Checked == true)
            {
                timer1.Enabled = true;
                timer1.Interval = 1000;
                r = 2;
                timer1.Tick += delegate
                {
                    pictureBox1.Refresh();
                };
            }
            if (radioButton3.Checked == true)
            {
                timer1.Enabled = true;
                timer1.Interval = 100;
                Get();
                r = 3;
                timer1.Tick += delegate
                {
                    pictureBox1.Refresh();
                };               
            }
            if (radioButton4.Checked == true)
            {
                r = 4;
                pictureBox1.Refresh();
            }
        }

        void Paint_1(PaintEventArgs e)
        {
            a = textBox1.Text;
            list = new List<List<Point>>();
            int k = 0;
            for (int b = 0; b < 6; b++)
            {
                List<Point> list1 = new List<Point>();
                int m = 0;
                for (int i = 0; i < 6; i++)
                {
                    int n = 0;
                    for (int j = 0; j < 11; j++)
                    {
                        Pen pen = new Pen(Color.Gray, 2.0F);
                        Pen pen1 = new Pen(Color.White, 2.0F);
                        Brush brush0 = new SolidBrush(Color.White);
                        int x = 25 + m + k;
                        int y = 60 + n;
                        Point point = new Point();
                        point.X = x;
                        point.Y = y;
                        list1.Add(point);
                        if (!(i > 0 && j > 0 && (j + i) <= 4) && !(i > 0 && j > 5 && (j + i) <= 9) && !(i < 5 && j < 10 && (j + i) >= 11) && !(i < 5 && j < 5 && (j + i) >= 6))
                        {
                            e.Graphics.DrawEllipse(pen, x, y, 5, 5);
                            e.Graphics.FillEllipse(brush0, x, y, 5, 5);
                        }
                        else
                        {
                            e.Graphics.DrawEllipse(pen1, x, y, 5, 5);
                            e.Graphics.FillEllipse(brush0, x, y, 5, 5);
                        }
                        n += 6;
                    }
                    m += 6;
                }
                k += 60;
                list.Add(list1);
            }
            if (a.Length < 6)
                while (a.Length < 6)
                    a += '0';
            Brush brush = new SolidBrush(Color.Black);
            char[] a1 = new char[6];
            for (int i = 0; i < 6; i++)
            {
                a1[i] = a[i];
                char l = a1[i];
                if (l == '1')
                {
                    for (int z = 55; z <= 65; z++)
                        e.Graphics.FillEllipse(brush, list[i][z].X, list[i][z].Y, 5, 5);
                    for (int z = 5; z <= 45; z += 10)
                        e.Graphics.FillEllipse(brush, list[i][z].X, list[i][z].Y, 5, 5);
                }
                if (l == '2')
                {
                    for (int z = 0; z <= 55; z += 11)
                        e.Graphics.FillEllipse(brush, list[i][z].X, list[i][z].Y, 5, 5);
                    for (int z = 10; z <= 65; z += 11)
                        e.Graphics.FillEllipse(brush, list[i][z].X, list[i][z].Y, 5, 5);
                    for (int z = 20; z <= 50; z += 10)
                        e.Graphics.FillEllipse(brush, list[i][z].X, list[i][z].Y, 5, 5);
                    for (int z = 55; z <= 60; z++)
                        e.Graphics.FillEllipse(brush, list[i][z].X, list[i][z].Y, 5, 5);
                }
                if (l == '3')
                {
                    for (int z = 0; z <= 55; z += 11)
                        e.Graphics.FillEllipse(brush, list[i][z].X, list[i][z].Y, 5, 5);
                    for (int z = 5; z <= 60; z += 11)
                        e.Graphics.FillEllipse(brush, list[i][z].X, list[i][z].Y, 5, 5);
                    for (int z = 15; z <= 45; z += 10)
                        e.Graphics.FillEllipse(brush, list[i][z].X, list[i][z].Y, 5, 5);
                    for (int z = 10; z <= 50; z += 10)
                        e.Graphics.FillEllipse(brush, list[i][z].X, list[i][z].Y, 5, 5);
                }
                if (l == '4')
                {
                    for (int z = 0; z <= 5; z++)
                        e.Graphics.FillEllipse(brush, list[i][z].X, list[i][z].Y, 5, 5);
                    for (int z = 55; z <= 65; z++)
                        e.Graphics.FillEllipse(brush, list[i][z].X, list[i][z].Y, 5, 5);
                    for (int z = 16; z <= 60; z += 11)
                        e.Graphics.FillEllipse(brush, list[i][z].X, list[i][z].Y, 5, 5);
                }
                if (l == '5')
                {
                    for (int z = 0; z <= 55; z += 11)
                        e.Graphics.FillEllipse(brush, list[i][z].X, list[i][z].Y, 5, 5);
                    for (int z = 5; z <= 60; z += 11)
                        e.Graphics.FillEllipse(brush, list[i][z].X, list[i][z].Y, 5, 5);
                    for (int z = 10; z <= 65; z += 11)
                        e.Graphics.FillEllipse(brush, list[i][z].X, list[i][z].Y, 5, 5);
                    for (int z = 1; z <= 4; z++)
                        e.Graphics.FillEllipse(brush, list[i][z].X, list[i][z].Y, 5, 5);
                    for (int z = 61; z <= 64; z++)
                        e.Graphics.FillEllipse(brush, list[i][z].X, list[i][z].Y, 5, 5);
                }
                if (l == '6')
                {
                    for (int z = 5; z <= 55; z += 10)
                        e.Graphics.FillEllipse(brush, list[i][z].X, list[i][z].Y, 5, 5);
                    for (int z = 6; z <= 10; z++)
                        e.Graphics.FillEllipse(brush, list[i][z].X, list[i][z].Y, 5, 5);
                    for (int z = 61; z <= 65; z++)
                        e.Graphics.FillEllipse(brush, list[i][z].X, list[i][z].Y, 5, 5);
                    for (int z = 16; z <= 60; z += 11)
                        e.Graphics.FillEllipse(brush, list[i][z].X, list[i][z].Y, 5, 5);
                    for (int z = 21; z <= 54; z += 11)
                        e.Graphics.FillEllipse(brush, list[i][z].X, list[i][z].Y, 5, 5);
                }
                if (l == '7')
                {
                    for (int z = 0; z <= 55; z += 11)
                        e.Graphics.FillEllipse(brush, list[i][z].X, list[i][z].Y, 5, 5);
                    for (int z = 5; z <= 45; z += 10)
                        e.Graphics.FillEllipse(brush, list[i][z].X, list[i][z].Y, 5, 5);
                    for (int z = 6; z <= 10; z++)
                        e.Graphics.FillEllipse(brush, list[i][z].X, list[i][z].Y, 5, 5);
                }
                if (l == '8')
                {
                    for (int z = 0; z <= 10; z++)
                        e.Graphics.FillEllipse(brush, list[i][z].X, list[i][z].Y, 5, 5);
                    for (int z = 55; z <= 65; z++)
                        e.Graphics.FillEllipse(brush, list[i][z].X, list[i][z].Y, 5, 5);
                    for (int z = 11; z <= 44; z += 11)
                        e.Graphics.FillEllipse(brush, list[i][z].X, list[i][z].Y, 5, 5);
                    for (int z = 16; z <= 49; z += 11)
                        e.Graphics.FillEllipse(brush, list[i][z].X, list[i][z].Y, 5, 5);
                    for (int z = 21; z <= 54; z += 11)
                        e.Graphics.FillEllipse(brush, list[i][z].X, list[i][z].Y, 5, 5);
                }
                if (l == '9')
                {
                    for (int z = 0; z <= 5; z++)
                        e.Graphics.FillEllipse(brush, list[i][z].X, list[i][z].Y, 5, 5);
                    for (int z = 55; z <= 60; z++)
                        e.Graphics.FillEllipse(brush, list[i][z].X, list[i][z].Y, 5, 5);
                    for (int z = 11; z <= 44; z += 11)
                        e.Graphics.FillEllipse(brush, list[i][z].X, list[i][z].Y, 5, 5);
                    for (int z = 16; z <= 49; z += 11)
                        e.Graphics.FillEllipse(brush, list[i][z].X, list[i][z].Y, 5, 5);
                    for (int z = 10; z <= 50; z += 10)
                        e.Graphics.FillEllipse(brush, list[i][z].X, list[i][z].Y, 5, 5);
                }
                if (l == '0')
                {
                    for (int z = 0; z <= 10; z++)
                        e.Graphics.FillEllipse(brush, list[i][z].X, list[i][z].Y, 5, 5);
                    for (int z = 55; z <= 65; z++)
                        e.Graphics.FillEllipse(brush, list[i][z].X, list[i][z].Y, 5, 5);
                    for (int z = 11; z <= 44; z += 11)
                        e.Graphics.FillEllipse(brush, list[i][z].X, list[i][z].Y, 5, 5);
                    for (int z = 21; z <= 54; z += 11)
                        e.Graphics.FillEllipse(brush, list[i][z].X, list[i][z].Y, 5, 5);
                }
            }    
        }

        void Paint_2(PaintEventArgs e)
        {
            Pen pen0 = new Pen(Color.Black, 5.0F);
            Brush brush = new SolidBrush(Color.Black);
            Graphics gr = pictureBox1.CreateGraphics();
            e.Graphics.DrawEllipse(pen0, 84, 16, 205, 205);
            Font font = new System.Drawing.Font("1", 12);
            double k = 360 / (Math.PI * 2);
            for (int i = 1; i <= 12; i++)
                e.Graphics.DrawString(Convert.ToString(i), font, brush, (int)(180 * (1 + Math.Sin(i * 30 / k) / 2)), (int)(30 * (1 - Math.Cos(i * 30 / k) / 2) * 6 - 70));
            dt = DateTime.Now;
            Pen pen = new Pen(Color.Black, 3.0F);
            Pen pen1 = new Pen(Color.Black, 2.0F);      
            e.Graphics.FillEllipse(brush, 184, 116, 10, 10);
            h = dt.Hour;
            m = dt.Minute;
            s = dt.Second;
            e.Graphics.DrawLine(pen1, 190, 122, (int)(150 * (1 + Math.Sin(s * 6 / k) / 1.9) + 40), (int)(152 * (1 - Math.Cos(s * 6 / k) / 1.9) - 30));
            e.Graphics.DrawLine(pen, 190, 122, (int)(150 * (1 + Math.Sin((m + s / 60) * 6 / k) / 2) + 40), (int)(152 * (1 - Math.Cos((m + s / 60) * 6 / k) / 2) - 30));
            e.Graphics.DrawLine(pen, 190, 122, (int)(150 * (1 + Math.Sin((h + (double)m / 60) * 30 / k) / 3) + 40), (int)(152 * (1 - Math.Cos((h + (double)m / 60) * 30 / k) / 3) - 30));
        }

        void Get()
        {
            x = new int[10];
            y = new int[10];
            dx = new int[10];
            dy = new int[10];
            r0 = new Random();
            color = new Color[10];
            for (int i = 0; i < 10; i++)
            {
                dx[i] = r0.Next(-5, 5);
                dy[i] = r0.Next(-5, 5);
                x[i] = 193 + r0.Next(-40, 40);
                y[i] = 120 + r0.Next(-40, 40);
                color[i] = Color.FromArgb(r0.Next(256), r0.Next(256), r0.Next(256));
            }
        }

        void Paint_3(PaintEventArgs e)
        {
            Pen pen = new Pen(Color.Black, 2.0F);
            Brush brush;
            for (int i = 0; i < 10; i++)
            {
                x[i] += dx[i];
                y[i] += dy[i];                
                for (int j = 0; j < 10; j++)
                {
                    if ((i != j) && (x[i] - x[j] < 20 && y[i] - y[j] < 20))
                    {
                        if (dx[i] < 0)
                            dx[i] = r0.Next(1, 5);
                        if (dx[i] > 0)
                            dx[i] = r0.Next(-5, -1);
                        if (dy[i] > 0)
                            dy[i] = r0.Next(-5, -1);
                        if (dy[i] < 0)
                            dy[i] = r0.Next(1, 5);
                    }
                    break;
                }
                if (x[i] < 0 || x[i] > 367)
                {
                    dx[i] *= -1;
                    if (dx[i] == 0)
                        dx[i] = 1;
                    dx[i] /= dx[i];
                    if (x[i] < 0)
                        dx[i] += r0.Next(0, 5);
                    else if (x[i] > 367)
                        dx[i] -= r0.Next(0, 5);
                }
                if (y[i] < 0 || y[i] > 220)
                {
                    dy[i] *= -1;
                    if (dy[i] == 0)
                        dy[i] = 1;
                    dy[i] /= dy[i];
                    if (y[i] < 0)
                        dy[i] += r0.Next(0, 5);
                    else if (y[i] > 220)
                        dy[i] -= r0.Next(0, 5);
                }              
                brush = new SolidBrush(color[i]);
                e.Graphics.DrawEllipse(pen, x[i], y[i], 20, 20);
                e.Graphics.FillEllipse(brush, x[i], y[i], 20, 20);
            }
        }

        void Paint_4(PaintEventArgs e)
        {
            a2 = int.Parse(textBox2.Text);
            b = int.Parse(textBox3.Text);
            wx = int.Parse(textBox4.Text);
            wy = int.Parse(textBox5.Text);
            fx = int.Parse(textBox6.Text);
            fy = int.Parse(textBox7.Text);
            Pen pen = new Pen(Color.Black, 2.0F);
            Point[] p = new Point[100];
            for (int t = 0; t < 100; t++)
            {
                p[t].X = (int)(a2 * Math.Sin(wx * t + fx)+190);
                p[t].Y = (int)(b * Math.Sin(wy * t + fy)+120);                
            }
            e.Graphics.DrawCurve(pen, p);
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            switch (r)
            {
                case 1: { Paint_1(e); break; }
                case 2: { Paint_2(e); break; }
                case 3: { Paint_3(e); break; }
                case 4: { Paint_4(e); break; }
            }
        }
    }
}
