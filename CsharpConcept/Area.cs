using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unisys.MathConcept
{
    public class Area
    {
        public static double AreaOfCircle(int r)
        {
            double area = 3.14 * r * r;
            return area;
        }

        public static double AreaOfRectangle(double length, double width)
        {
            return length * width;
        }


    }
}
