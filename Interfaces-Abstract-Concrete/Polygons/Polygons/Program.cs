using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polygons
{
    class Program
    {
        static void Main(string[] args)
        {
            var square = new Square(5);
            var triangle = new Triangle(5);
            DisplayPolygon("Square", square);
            DisplayPolygon("Triangle", triangle);

            Console.ReadLine();

        }

        public static void DisplayPolygon (string polygonType, dynamic polygon)
        {
            try
            {
                Console.WriteLine(polygonType + ":");
                Console.WriteLine("Number of Sides: " + polygon.NumberOfSides);
                Console.WriteLine("Side Length: " + polygon.SideLength);
                Console.WriteLine("Perimiter: " + polygon.GetPerimeter());
                Console.WriteLine("Area: " + polygon.GetArea() + "\n\n");
                

            }
            catch(Exception )
            {
                Console.WriteLine("Error");
            }
        }
    }
}
