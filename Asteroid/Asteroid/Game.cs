using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;


namespace Asteroid
{
    class Game
    {
        public int x, y;
        public int length;
        public Point rocket;
        Pen pen = new Pen(Color.Black);
        Rectangle rect = new Rectangle(0, 0, 900, 800);
        Rectangle leftrect = new Rectangle(0, 0, 10, 800);
        Rectangle uprect = new Rectangle(0, 0, 800, 10);
        Rectangle rightrect = new Rectangle(775, 0, 10, 800);
        Rectangle downrect = new Rectangle(0, 437, 800, 10);
        SolidBrush brushwhite = new SolidBrush(Color.White);
        SolidBrush brushblue = new SolidBrush(Color.Blue);
        SolidBrush brushblack = new SolidBrush(Color.Black);
        SolidBrush brushyellow = new SolidBrush(Color.Yellow);
        SolidBrush brushgreen = new SolidBrush(Color.Green);
        SolidBrush brushred = new SolidBrush(Color.Red);



        public void Ellipse(Graphics g)
        {
            length = 30;
            x = 50; y = 30;
            g.FillRectangle(brushblue, rect);
            g.FillRectangle(brushblack, uprect);
            g.FillRectangle(brushblack, leftrect);
            g.FillRectangle(brushblack, rightrect);
            g.FillRectangle(brushblack, downrect);


        }



    }
}
