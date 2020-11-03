using System;
using System.Collections.Generic;
using System.Text;

namespace Classy
{
    class Square
    {
        public int SideLength { get; set; }

        public Square(int side)
        {
            SideLength = side;
        }


        //Methods
        public double CalculatePerimeter()
        {
            int perimeter = SideLength * 4;
            return perimeter;
        }

        public double CalculateArea()
        {
            int area = SideLength * SideLength;
            return area;
        }

    }
}
