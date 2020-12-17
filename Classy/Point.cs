using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Classy
{

    class Point
    {
        private int _x;
        private int _y;

        //public int X { get; set; }
        //public int Y { get; set; }

        public int X { get { return _x; } set { _x = value; }  }
        public int Y { get { return _y; } set { _y = value; } }

        //public Point()
        //{

        //}

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        //public Point(int x, int y, int z)
        //{

        //}

        //Here's the method
        public double CalculateDistance()
        {
            double distance = Math.Sqrt(Math.Pow(X,2) + Math.Pow(Y,2));
            return distance;
        }

        //another way to calculate the distance using the pythagorean theorem (a^2 + b^2 = c^2)
        public double AnotherCalculateDistance()
        {
            double a2 = X * X;
            double b2 = Y * Y;
            double c2 = a2 + b2;
            return Math.Sqrt(c2);
        }

        public double AnotherCalculateDistance1()
        {
            double distance = Math.Sqrt(X * X + Y * Y);
            return distance;
        }
    }
}
