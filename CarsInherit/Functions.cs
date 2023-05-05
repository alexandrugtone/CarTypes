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
        public static int ChooseCar()
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

            return input;
        }

        public static void EqualExpense30km(int car1, int car2)
        {
            Car vehicle1 = Car.ConstructCarFromInt(car1);
            Car vehicle2 = Car.ConstructCarFromInt(car2);
            
            int counter = 1;
            bool stopper = true;
            do
            {
                if(vehicle1.TotalCostWithInitialCost(counter, 30) == vehicle2.TotalCostWithInitialCost(counter, 30))
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
    }
}
