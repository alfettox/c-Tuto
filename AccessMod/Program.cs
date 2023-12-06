namespace AccessMod
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person(new DateTime(1985, 1, 5));

            // Console.WriteLine(p.GetDate());
            // p.SetBirthday();
            // Console.WriteLine(p.GetDate());

            // p.BirthDate = new DateTime(1985, 1, 5); // This line is unnecessary because you've already set it in the constructor.

            Console.WriteLine($"Age: {p.Age}");
        }
    }
}