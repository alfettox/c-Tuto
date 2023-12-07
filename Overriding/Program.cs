using System;
using System.Collections.Generic;

namespace Overriding
{
    class Program
    {
        static void Main(string[] args)
        {
            var shapes = new List<Shape>
            {
                new Circle(),
                new Rectangle()
                // Add more shapes if needed
            };

            ShapeDrawer.DrawShapes(shapes);
        }
    }
}
