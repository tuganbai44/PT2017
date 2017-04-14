using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class Calculator
    {
        public double FirstNumber;
        public double SecondNumber;
        public string Operation;
        public double Result;

        public Calculator()
        {
            FirstNumber = 0;
            SecondNumber = 0;
        }

        public void saveFirstNumber (string s)
        {
            FirstNumber = double.Parse(s);
        }
        public void saveSecondNumber (string s)
        {
            SecondNumber = double.Parse(s);
        }   


        public void calculate()
        {
            switch (Operation)
            {
                case "+":
                    Result = FirstNumber + SecondNumber;
                    break;
                case "-":
                    Result = FirstNumber - SecondNumber;
                    break;
                case "*":
                    Result = FirstNumber * SecondNumber;
                    break;
                case "/":
                    Result = FirstNumber / SecondNumber;
                    break;
            }
        }
        public string Back(string s)
        {
            string text = "";
            char[] c = s.ToCharArray();
            for (int i = 0; i < s.Length - 1; i++)
            {
                text = text + c[i];
            }
            return text;
        }
    }
}
