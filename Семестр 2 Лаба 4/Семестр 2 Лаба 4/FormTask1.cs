using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Семестр_2_Лаба_4
{
    public partial class FormTask1 : Form
    {
        class Ring
        {
            public int X = 0;
            public int Y = 0;
            public float K = 1;
            public int Angle = 0;
            public Ring(int x, int y, float k, int angle)
            {
                X = x;
                Y = y;
                K = k;
                Angle = angle;
            }
        }
        Bitmap bmp;
        Graphics graph;
        Pen pen;
        int x = 0;
        int y = 0;
        public FormTask1()
        {
            InitializeComponent();
            timer1.Interval = 1;
            pen = new Pen(Color.Black);
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            graph = Graphics.FromImage(bmp);
            //ring = new Ring(pictureBox1.Width / 2, pictureBox1.Height / 2, 1, 0);
            timer1.Start();
            
        }
        void DrawRing()
        {
            if (y <= 0) x += 5;
            if (x >= pictureBox1.Width - 30) y += 5;
            if (y >= pictureBox1.Height - 30) x -= 5;
            if (x <= 0) y -= 5;
            graph.Clear(pictureBox1.BackColor);
            graph.DrawEllipse(pen, x, y, 30, 30);
            pictureBox1.Image = bmp;
        }

        private void Timer1tick(object sender, EventArgs e)
        {
            DrawRing();
        }

        private void FormTask1_SizeChanged(object sender, EventArgs e)
        {
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            graph = Graphics.FromImage(bmp);
        }

        private void FormTask1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 newForm = new Form1();
            newForm.Show();
        }
    }
}
