using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometri
{
    abstract class Shape
    {
        protected double sideA;
        protected double sideB;
        protected double sideC;
        protected double sideD;
        protected double angle;

        public double Angle { get { return angle; } set { angle = value; } }

        public double SideA { get { return sideA; } set { sideA = value; } }

        public double SideB { get { return sideB; } set { sideB = value; } }

        public double SideC { get { return sideC; } set { sideC = value; } }
        
        public double SideD { get { return sideD; } set { sideD = value; } }

        //Constructor used for square or shapes with all equal sides
        protected Shape(double sideA)
        {
            this.SideA = sideA;
        }

        //Constructor used for shapes with two pairs of matching sides
        protected Shape(double sideA, double sideB) : this(sideA)
        {
            this.SideB = sideB;
        }
        
        //Constructor used for shapes with two pairs of matching sides and an angle
        protected Shape(double sideA, double sideB, double angle) : this(sideA, sideB)
        {
            this.Angle = angle;
        }

        //Constructor used for shapes with 4 sides with different values
        protected Shape(double sideA, double sideB, double sideC, double sideD) : this(sideA, sideB)
        {
            this.SideC = sideC;
            this.SideD = sideD;
        }

        public abstract double Area();

        public abstract double Circumference();

        //Override ToString in Shape to avoid repeated code in other classes
        public override string ToString()
        {
            return GetType().Name + "\nArea: " + Area()
                        + "\nCircumference: " + Circumference() + "\n";
        }
    }
}
