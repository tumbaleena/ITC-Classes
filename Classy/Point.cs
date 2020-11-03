using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Classy
{

    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point()
        {

        }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public Point(int x, int y, int z)
        {

        }
        //Here's the method
        public double CalculateDistance()
        {
            double distance = Math.Sqrt(Math.Pow(X, 2) + Math.Pow(Y, 2));
            return distance;
        }
    }
}
