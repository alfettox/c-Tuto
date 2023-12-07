using System.Security.Cryptography;

namespace AbstractApp
{
    public abstract class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public abstract void Draw();
        //{

        //}

        public void Copy()
        {
            Console.WriteLine("COPIED TO CLIPBOARD");
        }

        public void Select()
        {
            Console.WriteLine("SELECTED");
        }

    }
}