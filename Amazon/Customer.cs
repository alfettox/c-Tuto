/*
 * PUBLIC: Accessible from everywhere in the program
 * PRIVATE: Accessible just inside the class
 * PROTECTED: Accessible only from the class and its derived classes
 * INTERNAL: if you have a class declared as internal assembly
 * PROTECTED INTERNAL: accessible from same assembly or any derived classes
 */

namespace Amazon
{

    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        private int Rating { get; set; }

        protected int CalculateRating()
        {
            return Rating;
        }

        public void Promote()
        {

            var Calculator = new RateCalculator();
            var rating = Calculator.Calculate(this);
            if (rating == 0)
            {
                Console.WriteLine("PROMOTED TO LEVEL +1");
            }
            else
            {
                Console.WriteLine("PROMOTED TO LEVEL +5");
            }

        }

        internal void setRating(int v)
        {
            Rating = v;
        }

        //protected internal void


        class CalcLibrary
        {
            internal class RateCalculator
            {

            }

        }


    }
}