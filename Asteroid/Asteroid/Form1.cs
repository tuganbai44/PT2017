﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asteroid
{
    public partial class Form1 : Form
    {
        Graphics bitG;
        Bitmap bitmap;


        public Form1()
        {
            InitializeComponent();
            bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            bitG = Graphics.FromImage(bitmap);
        }




        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
