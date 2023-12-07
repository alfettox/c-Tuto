using System;

namespace ConstructInheritance
{
    class Program
    {
        public static void Main(string[] args)
        {
            var car = new Car("555 555 666");
        }
    }

    public class Car : Vehicle
    {
        //public Car(string registrationNumberPassed):base(registrationNumberPassed)    
        //{
        //    Console.WriteLine("CAR HAS BEEN INITIALIZED");
        //}

        public Car(string registrationNumber) : base(registrationNumber)
        {
            Console.WriteLine("CAR INITIALIZED, REGISTRATION NUMBER {0}", registrationNumber);
        }
    }

    public class Vehicle
    {
        protected string _registrationNumber = "#14514513451";

        public Vehicle()
        {
            Console.WriteLine("VEHICLE HAS BEEN INITIALIZED");
        }

        public Vehicle(string registrationNumber)
        {
            _registrationNumber = registrationNumber;
            Console.WriteLine("VEHICLE INITIALIZED, REGISTRATION NUMBER {0}", registrationNumber);
        }
    }
}
