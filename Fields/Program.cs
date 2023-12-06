namespace Fields


{

    class Program
    {
        static void Main(string[] args)
        {
            var cus = new Customer(1);
            cus.Orders.Add(new Order());
            cus.Orders.Add(new Order());

            cus.Promote();

            Console.WriteLine(cus.Orders.Count);
        }
    }

}