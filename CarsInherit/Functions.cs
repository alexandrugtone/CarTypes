using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CarsInherit
{
    public class Functions
    {
        public static Car ChooseCar()
        {
            bool stopper = false;
            int input = 0;
            string[] objects = { "Electric", "Gasoline", "Diesel" };
            do
            {
                Console.WriteLine($"Choose a car type: 1.{objects[0]} 2.{objects[1]} 3.{objects[2]}");
                string carType = Console.ReadLine()??"";
                bool isNumber = int.TryParse(carType, out input);
                if (isNumber && input > 0 && input < objects.Length+1 )
                    stopper = true;
                else
                    Console.WriteLine("Please type in a number corresponding to the displayed choices!");
            }
            while (stopper == false);
            Car vehicle = Car.ConstructCarFromInt(input);

            return vehicle;
        }

        public static void EqualExpense30km(Car car1, Car car2)
        {
            int counter = 1;
            bool stopper = true;
            do
            {
                if(car1.TotalCostWithInitialCost(counter, 30) == car2.TotalCostWithInitialCost(counter, 30))
                {
                    stopper = false;
                    Console.WriteLine($"At 30km/h, adding the initial car cost, after {counter} hours" +
                        $" both cars expenses are equal!");
                }
                else
                    counter++;
            }
            while (stopper);
        }

        public static void CompareExpense100km(Car car1, Car car2)
        {
            //we can accept 3 parameters to get the user input also on how many hours to run
            int sumVehicle1 = car1.TotalCostWithoutInitialCost100km(5);
            int sumVehicle2 = car2.TotalCostWithoutInitialCost100km(5);
            Console.WriteLine($"{car1.VehicleType} vehicle cost at 100km for 5 hours is: {sumVehicle1} and" +
                $" {car2.VehicleType} vehicle cost is: {sumVehicle2}!");
        }

        public static void CompareTaxiRegime(Car car1, Car car2)
        {
            //we can accept 3 parameters to get the user input also on how many days to run
            int sumVehicle1 = car1.TotalCostTaxiRegime(3);
            int sumVehicle2 = car2.TotalCostTaxiRegime(3);
            Console.WriteLine($"{car1.VehicleType} vehicle cost at 30km for 8h/day for 3 days is: {sumVehicle1} and" +
                $" {car2.VehicleType} vehicle cost is: {sumVehicle2}!");
        }
    }
}
