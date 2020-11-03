using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometri
{
    class Square : Shape
    {

        public Square(double sideA) : base (sideA) 
        {
        }

        //Calculate circumference of the square and overrides Circumference in Shape
        public override double Circumference()
        {
            return sideA * 4;
        }

        //Calculate area of the square and overrides Area in Shape
        public override double Area()
        {
            return Math.Round(Math.Pow((sideA), 2), 2);
        }
    }
}
