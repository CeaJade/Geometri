using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometri
{
    internal class Rectangle : Shape
    {

        public Rectangle(double sideA, double sideB) : base(sideA, sideB)
        {
        }

        //Calculate circumference of the rectangle
        public override double Circumference()
        {
            return (sideA * 2 + sideB * 2);
        }

        //Calculate area of the rectangle
        public override double Area()
        {
            return Math.Round((sideA * sideB), 2);
        }


    }
}
