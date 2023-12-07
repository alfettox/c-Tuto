/*
 * PUBLIC: Accessible from everywhere in the program
 * PRIVATE: Accessible just inside the class
 * PROTECTED: Accessible only from the class and its derived classes
 * INTERNAL: if you have a class declared as internal assembly
 * PROTECTED INTERNAL: accessible from same assembly or any derived classes
 */

namespace Amazon
{
    public class RateCalculator
    {
        public int Calculate(Customer customer)
        {
            return 0;

        }
    }
}