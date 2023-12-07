using System;
using System.Collections; // Include the necessary namespace for ArrayList

namespace Types
{
    class Program
    {
        public static void Main(string[] args)
        {

            /* Boxing and Unboxing
             
               Boxing converts a value type to an object type, such as an Integer wrapper */

            // Use ArrayList for demonstration, but prefer List<T> for better type safety
            var list = new ArrayList();     // Automatically boxing

            list.Add(1); // Automatically boxing
            list.Add("2");
            list.Add(new DateTime());  // Structure = value type

            // Unboxing
            var number = (int)list[0]; // Corrected index to access the integer value

            // Better to use a generic list (List<T>) for type safety
            var list2 = new List<int>();
            list2.Add(1);
            // The following lines are now flagged as errors because List<int> only accepts integers
            // list2.Add("2");
            // list2.Add(new DateTime());


        }
    }
}
