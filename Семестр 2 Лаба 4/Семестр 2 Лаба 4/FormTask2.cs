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
    public partial class FormTask2 : Form
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
        Ring ring;
        public FormTask2()
        {
            InitializeComponent();
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            graph = Graphics.FromImage(bmp);
            pen = new Pen(Color.Black);
            ring = new Ring(pictureBox1.Width / 2, pictureBox1.Height / 2, 1, 0);
            DrawRing(12);
        }
        void DrawRing(float n)
        {
            //graph.Clear(pictureBox1.BackColor);
            graph.DrawEllipse(pen, ring.X + (float)Math.Cos(n/2)*100, ring.Y + (float)Math.Sin(n/2)*100, 30 * ring.K, 30 * ring.K);
            pictureBox1.Image = bmp;
            if (n > 1) DrawRing(n - 1);
        }

        private void FormTask2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 newForm = new Form1();
            newForm.Show();
        }
    }
}
