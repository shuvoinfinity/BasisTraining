using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypeExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputNumber = "12";

            int number = Convert.ToInt32(inputNumber);

            char aChar = (char)number;

            int aNumber = 1244324832;

            string numberString = aNumber.ToString();

        }
    }
}
