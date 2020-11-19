using System;
using System.Security.Cryptography.X509Certificates;

namespace Classy
{
    class Program
    {
        static void Main(string[] args)
        {
            //EXERCISE 2 - Calculate the perimeter and area of a square from user input for the length of 1 side
            Console.Write("Enter the length of your square's side: ");
            string input = Console.ReadLine();
            var side = int.Parse(input);
            Square square = new Square(side);
            var area = square.CalculateArea();
            var perimeter = square.CalculatePerimeter();
            Console.WriteLine($"You entered: {input}");
            Console.WriteLine($"Your square's area: {area}");
            Console.WriteLine($"Your square's area: {perimeter}");


            //EXERCISE 1 - Code for calculating distance between Points
            /*string input;
            Console.WriteLine("Let's calculate the distance between your coordinate and 0,0 on a graph.");
            Console.Write("Please enter the value for X: ");
            input = Console.ReadLine();
            var x = int.Parse(input);

            Console.Write("Please enter the value for Y: ");
            input = Console.ReadLine();
            var y = int.Parse(input);

            //create point and visually confirm it with the user
            Point point = new Point(x, y);
            Console.WriteLine($"You entered: ({point.X},{point.Y})");

            //calculate the distance
            double answer = point.CalculateDistance();
            Console.WriteLine($"The distance between your point and the origin is: {answer}"); */

            //Example constructors
            /*  Point point1 = new Point(3, 5);
              Point point2 = new Point();
              point2.X = 3;
              point2.Y = 5;

              Point point3 = new Point
              {
                  X = 3,
                  Y = 5
              }; */
        }
        //EXERCISE 2 - Example Class for Square
        class Square1
        {
            public int SideLength { get; set; }

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

}
