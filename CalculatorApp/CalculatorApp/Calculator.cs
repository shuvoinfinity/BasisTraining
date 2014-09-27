using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp
{
    class Calculator


    {

        public string Add(double firstNumber, double secondNumber)
        {
          return  (firstNumber + secondNumber).ToString();
        }

        public string Subtract(double firstNumber, double secondNumber)
        {
             return  (firstNumber - secondNumber).ToString();
        }

        public string Multiply(double firstNumber, double secondNumber)
        {
             return  (firstNumber * secondNumber).ToString();
        }

        public string Divide(double firstNumber, double secondNumber)
        {
            return (firstNumber / secondNumber).ToString();
        }
    }
}
