using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public static Calculator calc;

           
        public Form1()
        {
            InitializeComponent();
            calc = new Calculator();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void number(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (textBox1.Text == "0")
            {
                textBox1.Text = btn.Text;
            }
            else
            {
                textBox1.Text += btn.Text;
            }

        }


        private void equal_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            cakc
            calc.saveFirstNumber(textBox1.Text);
            calc.Operation = btn.Text;
            textBox1.Text = "";
        }
        
    }
}
