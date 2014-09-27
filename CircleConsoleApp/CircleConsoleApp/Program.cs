using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Circle aCircle = new Circle();

            ////double radius = Console.ReadLine().ToString();
            //double radius = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("\n" + aCircle.GetDiameter(radius) +"\n");
            //Console.WriteLine(aCircle.GetPerimeter(radius)+ "\n");
            //Console.WriteLine(aCircle.GetRadious(radius) + "\n");

            Circle aCircle = new Circle();
            aCircle.radius = 100;

            Console.WriteLine("Perimeter " + aCircle.GetPerimeter());
            Console.WriteLine("Perimeter " + aCircle.GetDiameter());
            Console.WriteLine("Perimeter " + aCircle.GetArea());

            Console.ReadKey();

        }
    }
}
