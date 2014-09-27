using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleConsoleApp
{
    class Circle
    {
        public double radius;

        //public double GetDiameter(double radius)
        //{
        //    return 2*radius;
        //}
        public double GetDiameter()
        {
            return 2 * radius;
        }

        //public double GetPerimeter(double radius)
        //{
        //    return 2*Math.PI*radius;
        //}
        public double GetPerimeter()
        {
            return 2 * Math.PI * radius;
        }

        //public double GetRadious(double radius)
        //{
        //    return Math.PI*radius*radius;
        //}
        public double GetArea()
        {
            return Math.PI * radius * radius;
        }
    }
}
