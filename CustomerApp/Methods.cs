using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerApp

{

    internal class Methods
    {
        public class Calculator
        {
            public int Add(int x)
            {
                return x;
            }

            public int Add(int x, int y)
            {
                return x + y;
            }

            public int Add(int x, int y, int z)
            {
                return x + y + z;
            }

            public int Add(int[] nums)
            {
                // You need to implement the logic for summing the elements in the array
                return nums.Sum();
            }
        }
    }
}

    //    public static void Main(string[] args)
    //    {
    //        Calculator calculator = new Calculator();

    //        // Example usage
    //        int result1 = calculator.Add(5);
    //        int result2 = calculator.Add(3, 7);
    //        int result3 = calculator.Add(1, 2, 3);

    //        int[] numbers = { 1, 2, 3, 4 };
    //        int result4 = calculator.Add(numbers);

    //        Console.WriteLine($"Result 1: {result1}");
    //        Console.WriteLine($"Result 2: {result2}");
    //        Console.WriteLine($"Result 3: {result3}");
    //        Console.WriteLine($"Result 4: {result4}");
    //    }
    //}
//}
