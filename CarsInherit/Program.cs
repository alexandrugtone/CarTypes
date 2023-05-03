using System;
using System.Security.Cryptography.X509Certificates;

namespace CarsInherit
{
    public class Program
    {
        public static void Main()
        {
            bool stopper = false;
            int value = 0;
            do
            {
                Console.WriteLine("Choose a car type: 1.Electric 2.Gasoline 3.Diesel");
                string carType = Console.ReadLine();
                bool isNumber = int.TryParse(carType, out value);
                if (isNumber && value>0 && value<4)
                    stopper = true;
                else
                    Console.WriteLine("Please type in a number corresponding to the displayed choices!");
            }
            while (stopper == false);

            if(value == 1)
            {
                Electric electricCar = new Electric();
                Console.WriteLine("You have selected an Electric Car. Here are some information about it:");
                electricCar.PrintCar();
                electricCar.PrintDetails();
            }
            else if(value == 2)
            {
                Gasoline gasolineCar = new Gasoline();
                Console.WriteLine("You have selected an Gasoline Car. Here are some information about it:");
                gasolineCar.PrintCar();
                gasolineCar.PrintDetails();
            }
            else
            {
                Diesel dieselCar = new Diesel();
                Console.WriteLine("You have selected an Diesel Car. Here are some information about it:");
                dieselCar.PrintCar();
                dieselCar.PrintDetails();
            }
        }
    }
}
