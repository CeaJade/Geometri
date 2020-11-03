using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometri
{
    class Trapez : Shape
    {

        public Trapez(double sideA, double sideB, double sideC, double sideD) : base(sideA, sideB, sideC, sideD)
        {
        }

        //Calculate height of the trapez
        private double Height()
        {
            double s = (sideA + sideB - sideC + sideD) / 2;
            double height = (2 / (sideA - sideC) * Math.Sqrt(s * (s - sideA + sideC) * (s - sideB) * (s - sideD)));
            return Math.Round(height, 2);
        }

        //Calculate area of the trapezium
        public override double Area()
        {
            return Math.Round(0.5 * (sideA + sideB) * Height(), 2);
        }

        //Calculate circumference of the trapezium
        public override double Circumference()
        {
            return (sideA + sideB + sideC + sideD);
        }

        //Add height to the result in string to the superclass
        public override string ToString()
        {
            return base.ToString() + "Height: " + Height() + "\n";
        }
    }
}
