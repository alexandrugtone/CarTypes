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
            Functions.CompareExpense100km(firstCar, secondCar);
            Functions.CompareTaxiRegime(firstCar, secondCar);
        }
    }
}
