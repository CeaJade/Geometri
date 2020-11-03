using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometri
{
    class Triangle : Shape
    {
        public Triangle(double sideA, double sideB) : base(sideA, sideB)
        {
        }

        //Calculate area of the Triangle using sideB as height
        public override double Area()
        {
            return 0.5 * sideA * sideB;
        }

        //Calculate circumference of the triangle
        public override double Circumference()
        {
            return sideA + sideB + Pythagoras();
        }

        //Calculate pythagoras used to find the circumference 
        private double Pythagoras()
        {
            return Math.Sqrt(Math.Pow(sideA, 2) + Math.Pow(sideB, 2));
        }
    }
}
