using System;
using System.Collections.Generic;

namespace Overriding
{
    class Canvas
    {
        public void DrawShapes(List<Shape> shapes)
        {
            foreach (var shape in shapes)
            {
                shape.Draw(); // Use polymorphism to call the appropriate Draw method
            }
        }
    }
}
