using CarObjects;
using System;
using System.Security.Cryptography.X509Certificates;

namespace CarsInherit
{
    public class Program
    {
        public static void Main()
        {
            //todo: make a hybrid with percentage <> 100
            //intercept custom exception
            //display to the user how much is different than 100

            Hybrid h = new Hybrid(75, 25);
            Console.WriteLine(h.MaxSpeed);
            //try
            //{
            //    CarObjects.Car.ConstructCarFromInt(100);
            //}
            //catch(CarCannotBeConstructedException ex1)
            //{
            //    Console.WriteLine("The number provided is wrong: " + ex1.nrCar);
            //}
            //catch(Exception)
            //{
            //    //Console.WriteLine("A aparut o exceptie: " + ex.Message);
                
            //    return;
            //}

            var firstCar = Functions.ChooseCar();
            var secondCar = Functions.ChooseCar();
            Functions.EqualExpense30km(firstCar, secondCar);
            Functions.CompareExpense100km(firstCar, secondCar);
            Functions.CompareTaxiRegime(firstCar, secondCar);
            Console.WriteLine(firstCar.PrintCar());
        }
    }
}
