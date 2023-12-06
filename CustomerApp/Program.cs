using System.Collections.Generic;
namespace CustomerApp
{

    public class Order
    {
        
    }

    class Program
    {
        public static void Main(string[] args)
        {

            usePoints();


            var customer = new Customer();
            System.Console.WriteLine(customer.Id);
            System.Console.WriteLine(customer.Name);

            customer.Name = "Giovanni";

            customer.Id = 12314;

            System.Console.WriteLine(customer.Id);
            System.Console.WriteLine(customer.Name);

            var customerOver = new Customer(123, "Overloaded");
            System.Console.WriteLine(customerOver.Id);
            System.Console.WriteLine(customerOver.Name);


            var order = new Order();
            //customer.Orders = new List<Order>();
            customer.Orders.Add(order);

            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.Name);

            //int.Parse("invalidStringThatCantBeConvertedToInt");

            int number = 213;
            var result = int.TryParse("this", out number);

            if (result)
            {
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine(number);
            }



        }


        static void useParams()
        {
            var calc = new Calculator();

            Console.WriteLine(calc.Add(1, 2, 3));             //thanks to params
            Console.WriteLine(calc.Add(1, 2, 3, 5, 6));
            Console.WriteLine(calc.Add(1, 2, 3, 5));
            Console.WriteLine(calc.Add(new int[] { 2, 5, 5, 6, 7 }));


        }

        private static void usePoints()
        {
            try
            {
                var point = new Point(10, 20);
                Console.WriteLine("Point is at {0},{1}", point.X, point.Y);

                //point.Move(new Point(5, 30));
                point.Move(null);

                Console.WriteLine("Point is at {0},{1}", point.X, point.Y);

                point.Move(999, 888);
                Console.WriteLine("Point is at {0},{1}", point.X, point.Y);

            }
            catch (Exception)
            {
                Console.WriteLine("Unexpected error happend");
            }
        }
    }
}