using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polygons
{
    public class ConcreteRegularPlygon
    {
        public int NumberOfSides { get; set; }
        public int SideLength { get; set; }

        public ConcreteRegularPlygon(int sides, int length)
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
        //Should (but is not required to) be defined in child class
        public virtual double GetArea()
        {
            throw new NotImplementedException();
        }

    }
}
