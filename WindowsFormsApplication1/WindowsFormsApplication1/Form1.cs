using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public static Calculator calc;
        double mem = 0;

        public Form1()
        {
            InitializeComponent();
            calc = new Calculator();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void number_click(object sender, EventArgs e)
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

        private void Clear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            calc.FirstNumber = 0;
            calc.SecondNumber = 0;
            calc.Result = 0;
            calc.Operation = " ";
        }

        private void ClearE_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            calc.SecondNumber = 0;
        }
        private void operation_click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            calc.saveFirstNumber(textBox1.Text);
            calc.Operation = btn.Text;
            textBox1.Text = "";
        }

        private void root_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            calc.saveFirstNumber(textBox1.Text);
            textBox1.Text = (Math.Sqrt(calc.FirstNumber)).ToString();
        }

        private void negative_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            calc.saveFirstNumber(textBox1.Text);
            textBox1.Text = Convert.ToString(calc.FirstNumber * (-1));
        }

        private void percent_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            calc.saveSecondNumber(textBox1.Text);
            textBox1.Text = Convert.ToString(calc.FirstNumber * calc.SecondNumber / 100);
        }

        private void equal_Click(object sender, EventArgs e)
        {
            calc.saveSecondNumber(textBox1.Text);
            calc.calculate();
            if (calc.Result == calc.FirstNumber / 0)
            {
                textBox1.Text = "can not divide by zero";


            }
            else
            {
                textBox1.Text = calc.Result.ToString();
                calc.FirstNumber = double.Parse(textBox1.Text);
            }
        }

        private void drob_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            textBox1.Text += btn.Text;
        }

        private void button1dx_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            calc.saveFirstNumber(textBox1.Text);
            if (calc.FirstNumber == 0)
            {
                textBox1.Text = "can not divide by zero ";
            }
            else
            {
                textBox1.Text = Convert.ToString(1 / calc.FirstNumber);
            }
        }

        private void backspace_Click(object sender, EventArgs e)
        {
            int a;
            a = int.Parse(textBox1.Text);
            Button btn = sender as Button;
            if (textBox1.Text != "" && a % 10 != a)
            {
                textBox1.Text = calc.Back(textBox1.Text);
            }
            else if (a % 10 == a)
            {
                textBox1.Text = "0";
            }
            else
            {
                textBox1.Text = "0";
            }
        }

        private void number0_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (textBox1.Text == "0")
            {
                textBox1.Text = "0";
            }
            else
            {
                textBox1.Text += btn.Text;
            }
        }

        private void memory_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            switch (btn.Text)
            {
                case "MS":
                    mem = double.Parse(textBox1.Text);
                    textBox1.Text = "";
                    break;
                case "M+":
                    mem = mem + double.Parse(textBox1.Text);
                    break;
                case "M-":
                    mem = mem - double.Parse(textBox1.Text);
                    break;
                case "MR":
                    textBox1.Text = mem.ToString();
                    break;
                case "MC":
                    mem = 0;
                    textBox1.Text = "0";
                    break;
            }
        }

    }
}
