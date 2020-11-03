using System;
using System.Collections.Generic;

namespace Geometri
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating a list of shapes containing all the classes and giving them their parameters.
            List<Shape> shapes = new List<Shape>
            {
                new Square(5),
                new Rectangle(3, 4),
                new Parallelogram(3, 5, 20),
                new Trapez(10, 9, 8, 9),
                new Triangle(3, 4)
            };

            //displays in the console all the results from shape in the list "shapes".
            foreach (Shape shape in shapes)
            {
                Console.WriteLine(shape.ToString());
            }

            Console.WriteLine("\nPress any key to close program.");
            Console.ReadKey();
        }
    }
}
