using System;

namespace Overriding
{
    public class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public Position Position { get; set; }

        public virtual void Draw()
        {
            Console.WriteLine("Drawing a shape");
        }
    }

    public class Circle : Shape
    {
        public override void Draw()
        {
            base.Draw();
            Console.WriteLine("Drawing a circle");
        }
    }

    public class Rectangle : Shape
    {
        // Add specific properties or methods for Rectangle if needed
    }
}
