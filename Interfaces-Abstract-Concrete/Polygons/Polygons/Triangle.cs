using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polygons
{
    //Since Triangle is based off of an abstract class, it HAS to define the abstract methods
    public class Triangle : AbstractRegularPolygon
    {
        public Triangle(int length) :
            base (3, length)
        { }

        //This definition is required, since it is an abstract method in the abstract class
        public override double GetArea()
        {
            return SideLength * SideLength * Math.Sqrt(3) / 4;
        }
    }
}
