using System;

namespace Lab2.Geometry2D
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p = new Point();

            p.SetCoords(2, 2);
            p.SetCoords(null, 2);

            Vector v = new Vector();
            v.Set(-1, 1);
        }
    }
}
