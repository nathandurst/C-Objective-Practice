using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polygons
{
    //Purely abstract (no implementation)
    //Should start with I
    //acts like a contract
    public interface IRegularPolygon
    {
        //only declarations
        //no access modifiers, automatically public
        int NumberOfSides { get; set; }
        int SideLength { get; set; }

        double GetPerimeter();
        double GetArea();
    }
}
