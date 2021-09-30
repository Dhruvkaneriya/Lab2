using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2
{
    namespace Geometry2D
    {
        public class Point // public class Point
        {

            public double X { get; set; }
            public double Y { get; set; }

            // Point class constructor
            public Point(double x = 0, double y = 0)
            {
                X = x;
                Y = y;
            }

            // Point class getcords method
            public void GetCoords(out double x, out double y)
            {
                x = X;
                y = Y;
            }

            // Point class setcords method
            public void SetCoords(double? x, double? y)
            {
                X = x ?? X;
                Y = y ?? Y;
            }

            public override string ToString() => $"({X}, {Y})";
        }

        public class Vector // public class Vector
        {
            public double DX { get; private set; }
            public double DY { get; private set; }

            // vector class constructor
            public Vector(double dx = 0, double dy = 0)
            {
                Set(dx, dy);
            }

            // vector classs Set method
            public void Set(double dx, double dy)
            {
                // if else condition check vector argument between [-1,1]
                bool InRange(double x) => x <= 1 && x >= -1;

                if (InRange(dx) && InRange(dy))
                {
                    DX = dx;
                    DY = dy;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Direction components must be in the range [-1, 1]");
                }
            }

            public override string ToString() => $"({DX}, {DY})";
        }

        public class Rectangle // public class Rectangle 
        {
            public double Length { get; }
            public double Width { get; }
            public double Area { get; }

            // Rectangle class Constructor
            public Rectangle(double length, double width)
            {
                Length = length;
                Width = width;
                Area = Length * Width;
            }
        }
    }
}
