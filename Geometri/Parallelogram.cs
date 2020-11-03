using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometri
{
    class Parallelogram : Shape
    {
        

        public Parallelogram(double sideA, double sideB, double angle) : base(sideA, sideB, angle)
        {
        }

        //Calculate area of the parallelogram
        public override double Area()
        {
            return Math.Round((sideA * sideB * Math.Sin((Math.PI / 180) * angle)), 2);
        }

        //Calculate circumference of the parallelogram
        public override double Circumference()
        {
            return (sideA * 2 + sideB * 2);
        }
    }
}
