namespace FromInheritanceToComp
{
    class Program
    {
        public static void Main(string[] args)
        {
            Person p = new Person();
            p.Sleep();
            p.Walk();


            Fish f = new Fish();
            f.Age = 1;

            Console.WriteLine("AGE: " + f.Age);
            f.Swim();   
            f.Sleep();
            f.Eat();

        }
    }

    class Animal
    {
        public int Age { get; set; }

        public void Eat()
        {
            Console.WriteLine("Eating");
        }

        public void Sleep()
        {
            Console.WriteLine("Sleeping");
        }
    }



    interface Walkable
    {
        public void Walk()
        {
        }

    }

    interface Swimmable
    {
        public void Swim()
        {
        }

    }

    class WalkingBehavior : Walkable
    {
        public void Walk()
        {
            Console.WriteLine("Walking");
        }
    }

    class SwimmingBehavior : Swimmable
    {
        public void Swim()
        { Console.WriteLine("Swimming"); }
    }


    class Person : Animal
    {
        private readonly Walkable walkingBehavior = new WalkingBehavior();

        public void Walk()
        {
            walkingBehavior.Walk();
        }
    }

    class Fish : Animal
    {
        private readonly Swimmable swimmingBehavior = new SwimmingBehavior();

        public void Swim()
        {
            swimmingBehavior.Swim();
        }

    }
}