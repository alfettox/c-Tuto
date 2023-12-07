using System;
using System.Collections.Generic;

namespace Overriding
{
    public static class ShapeDrawer
    {
        public static void DrawShapes(List<Shape> shapes)
        {
            foreach (var shape in shapes)
            {
                shape.Draw();
            }
        }
    }
}
