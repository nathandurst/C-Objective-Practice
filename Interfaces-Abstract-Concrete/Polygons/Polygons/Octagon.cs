using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polygons
{
    public class Octagon : ConcreteRegularPlygon
    {
        public Octagon(int length):
            base(4, length)
        { }

        public override double GetArea()
        {
            return 2 *(1 + Math.Sqrt(2)) * SideLength * SideLength;
        }
    }
}
