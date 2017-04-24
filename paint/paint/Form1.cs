using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace paint
{
    public partial class Form1 : Form
    {
        enum Shape
        {
            LINE,
            RECTANGLE,
            PEN
        };
        Shape shape = Shape.LINE;
        bool mouseClicked = false;
        Point prevPoint = new Point(0, 0);
        Pen pen = new Pen(Color.Black);
        Graphics g;
        Bitmap bmp;
        Graphics gPic;

        public Form1()
        {
            InitializeComponent();
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(bmp);
            gPic = pictureBox1.CreateGraphics();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseClicked = true;
            prevPoint = e.Location;
        
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseClicked = false;
            int w = Math.Abs(prevPoint.X - e.Location.X);
            int h = Math.Abs(prevPoint.Y - e.Location.Y);
            int minX = Math.Min(prevPoint.X, e.Location.X);
            int minY = Math.Min(prevPoint.Y, e.Location.Y);

            g.DrawRectangle(pen, w, h, minX, minY);
            pictureBox1.Refresh();
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseClicked)
            {
                if (shape == Shape.LINE)
                {
                    g.DrawLine(pen, prevPoint.X, prevPoint.Y, e.Location.X, e.Location.Y);
                    prevPoint = e.Location;
                }
                else if (shape == Shape.RECTANGLE)
                {
                    int w = Math.Abs(prevPoint.X - e.Location.X);
                    int h = Math.Abs(prevPoint.Y - e.Location.Y);
                    int minX = Math.Min(prevPoint.X, e.Location.X);
                    int minY = Math.Min(prevPoint.Y, e.Location.Y);

                    gPic.DrawRectangle(pen, minX, minY, w, h);
                }
                pictureBox1.Refresh();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ColorDialog c = new ColorDialog();
            if (c.ShowDialog() == DialogResult.OK)
            {
                pen.Color = c.Color;
            }
        }
    }
}
