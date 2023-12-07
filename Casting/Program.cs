using System;

namespace Casting
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating a Car object and assigning it to a Vehicle variable
            Vehicle vehicle = new Car();

            // Explicitly casting the Vehicle object back to a Car
            Car car = vehicle as Car;

            // Type checking to see if the object is a Car
            if (car == null)
            {
                Console.WriteLine("The object is not a Car.");
            }
            else
            {
                // Invoking the RunEngine method on the Car object
                car.RunEngine();
            }

            // Creating a Car object and assigning it to a Vehicle variable
            Vehicle car2 = new Car();

            // Attempting to cast car2 to Car using the as operator
            Car castedCar2 = car2 as Car;

            // Checking if the cast was successful and invoking the RunEngine method
            if (castedCar2 != null)
            {
                castedCar2.RunEngine();
            }
            else
            {
                Console.WriteLine("car2 is not a Car.");
            }

            if (castedCar2 is Car) { Console.WriteLine("YES CASTED CAR IS A CAR");
        }

        }
    }

    // Derived class Car inheriting from base class Vehicle
    public class Car : Vehicle
    {
        // Public method to run the car engine
        public void RunEngine()
        {
            Console.WriteLine("BRUM BRUM");
        }
    }

    // Base class Vehicle
    public class Vehicle
    {
        // You can add common properties or methods for vehicles here
    }
}
