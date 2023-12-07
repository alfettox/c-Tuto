/*
 * PUBLIC: Accessible from everywhere in the program
 * PRIVATE: Accessible just inside the class
 * PROTECTED: Accessible only from the class and its derived classes
 * INTERNAL: if you have a class declared as internal assembly
 * PROTECTED INTERNAL: accessible from same assembly or any derived classes
 */

using Amazon;

namespace AccessModifiers
{
    class Program
    {
        public static void Main(string[] args)
        {
            Customer cus = new Customer();

            //cus.setRating(3);
            //cus.Promote();

            Amazon.RateCalculator cal = new Amazon.RateCalculator();

        }
    }
}