using System;
using System.Security.Cryptography.X509Certificates;

namespace CarsInherit
{
    public class Program
    {
        public static void Main()
        {
            var firstCar = Functions.ChooseCar();
            var secondCar = Functions.ChooseCar();
            Functions.EqualExpense30km(firstCar, secondCar);

            //to do: modifica functia choosecar sa intoarca Car nu int
        }
    }
}
