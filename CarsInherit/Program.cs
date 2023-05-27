using CarObjects;
using System;
using System.Security.Cryptography.X509Certificates;

namespace CarsInherit
{
    public class Program
    {
        public static void Main()
        {
            //var test1 = Car.ConstructCar(CarType.Electric | CarType.Gasoline);
            //var test2 = Car.ConstructCar(CarType.Gasoline);
            var test3 = Car.ConstructCar(5);
            Console.WriteLine(CarType.Gasoline | CarType.Electric);
            try
            {
                Hybrid h = new Hybrid(25, 75, CarType.Gasoline);
                Console.WriteLine(h.MaxSpeed);
            }
            catch (CarCannotBeConstructedException ex1)
            {
                Console.WriteLine("The number provided is wrong: " + ex1.nrCar);
            }
            catch (CarPercentageIncorrectException ex2)
            {
                Console.WriteLine("The percentages provided doesn't add to 100: " +
                    ex2.electricP + "+" + ex2.fuelP + "=" + ex2.sum);
            }
            catch (Exception ex3)
            {
                Console.WriteLine("A aparut o exceptie: " + ex3.Message);
                return;
            }

            var firstCar = Functions.ChooseCar();
            var secondCar = Functions.ChooseCar();
            Functions.EqualExpense30km(firstCar, secondCar);
            Functions.CompareExpense100km(firstCar, secondCar);
            Functions.CompareTaxiRegime(firstCar, secondCar);
            Console.WriteLine(firstCar.PrintCar());
        }
    }
}
