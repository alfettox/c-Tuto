namespace AbstractApp
{
    /*
     abstract methods dont have an implementation, 
    all the methods must be overriden by sub,
     abstract classes cant be instantiated. 
    Use abstract to provide common behavior to many classes */

    class Program
    {
        public static void Main(string[] args) {
        
        var circle = new Circle();
            circle.Draw();

            var rectangle = new Rectangle();
            rectangle.Draw(); 
        }
    }

    class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Draw a rectangle");
        }
    }
}