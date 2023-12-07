using System;

namespace SealedMod
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Create an instance of Circle
            Circle circle = new Circle();

            // Call the Draw method of the Circle class
            circle.Draw();
        }
    }

    class Circle : Shape
    {
        // Using the 'sealed' keyword to prevent further overriding
        public sealed override void Draw()
        {
            Console.WriteLine("Drawing a circle");
        }
    }

    class Shape
    {
        // Marking the method as 'virtual' to allow overriding
        public virtual void Draw() { }
    }
}
