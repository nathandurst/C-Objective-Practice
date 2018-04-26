using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polygons
{
    //must be difined as an abstract class if it contains an abstract member
    public abstract class AbstractRegularPolygon
    {
        public int NumberOfSides { get; set; }
        public int SideLength { get; set; }

        public AbstractRegularPolygon(int sides, int length)
        {
            NumberOfSides = sides;
            SideLength = length;
        }

        //This calculation does not depend on polygon
        //Does not need to be overriden.
        public double GetPerimeter()
        {
            return NumberOfSides * SideLength;
        }

        //This calculation depends on the polygon we are using
        //Must be defined in child class (required)
        public abstract double GetArea();
    }
}
