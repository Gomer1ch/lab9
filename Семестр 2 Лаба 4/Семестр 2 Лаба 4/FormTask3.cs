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
    public partial class FormTask3 : Form
    {
        double t = 0;
        Rectangle rct;
        public FormTask3()
        {
            InitializeComponent();
            timer1.Interval = 10;
            timer1.Start();
            sun = new Bitmap("sun2.jpg");
            earth = new Bitmap("earth.png");
            this.BackgroundImage = new Bitmap("sun2.jpg");
            earth.MakeTransparent();
            this.ClientSize = new System.Drawing.Size(new Point(BackgroundImage.Width, BackgroundImage.Height));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            g = Graphics.FromImage(BackgroundImage);
            rct.X = 0;
            rct.Y = 0;
            rct.Width = sun.Width;
            rct.Height = sun.Height;

        }
        System.Drawing.Bitmap sun, earth;
        Graphics g; // рабочая графическая поверхность

        private void FormTask3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 newForm = new Form1();
            newForm.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            t++;
            g.DrawImage(sun, new Point(0, 0));
            //graph.Clear(pictureBox1.BackColor);
            //graph.DrawEllipse(pen, car.X + (float)Math.Cos(t/40) * 100, car.Y + (float)Math.Sin(t/40) * 100, 30, 30);
            //g.DrawImage(earth, 100, 100);
            //pictureBox1.Image = bmp;
            g.DrawImage(earth, rct.X + this.Width/2-60 + (float)Math.Cos(t / 40) * 200, rct.Y + this.Height/2-65 + (float)Math.Sin(t / 40) * 200);
            this.Invalidate(rct);
        }
    }
}
