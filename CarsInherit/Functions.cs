﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using CarObjects;
using CarsDAL;

namespace CarsInherit
{
    public class Functions
    {
        private readonly CarsService _carsService;
        public Functions(CarsService carsService)
        {
            _carsService = carsService;
        }
        public async Task<Car> ChooseCar()
        {
            bool stopper = false;
            int input = 0;
            string[] objects = { "Electric", "Gasoline", "HybridGas", "Diesel", "HybridDiesel" };
            do
            {
                Console.WriteLine($"Choose a car type:");
                for(int i= 0; i<objects.Length; i++)
                    Console.Write(i+1 + "." + objects[i] + " ");
                Console.WriteLine();
                string carType = Console.ReadLine()??"";
                bool isNumber = int.TryParse(carType, out input);
                if (isNumber && input > 0 && input < objects.Length+1 )
                    stopper = true;
                else
                    Console.WriteLine("Please type in a number corresponding to the displayed choices!");
            }
            while (stopper == false);
            Car vehicle = Car.ConstructCar(input);
            await _carsService.CreateAsync(vehicle);

            return vehicle;
        }

        public static int EqualExpense30km(int car1, int car2)
        {
            var vehicle1 = Car.ConstructCar(car1);
            var vehicle2 = Car.ConstructCar(car2);

            var ret = EqualExpense30km(vehicle1, vehicle2);

            return ret;
        }

        public static int EqualExpense30km(Car vehicle1, Car vehicle2)
        {
            int counter = 1;
            bool stopper = true;
            do
            {
                if (vehicle1.TotalCostWithInitialCost(counter, 30) == vehicle2.TotalCostWithInitialCost(counter, 30))
                {
                    stopper = false;
                    //Console.WriteLine($"At 30km/h, adding the initial car cost, after {counter} hours" +
                    //    $" both cars expenses are equal!");
                }
                else
                    counter++;
            }
            while (stopper);

            return counter;
        }

        public static CombinedCars CompareExpense100km(Car car1, Car car2)
        {
            //we can accept 3 parameters to get the user input also on how many hours to run
            car1.ComparingResult = car1.TotalCostWithoutInitialCost100km(5);
            car2.ComparingResult = car2.TotalCostWithoutInitialCost100km(5);

            CombinedCars combinedCars = new CombinedCars()
            {
                firstCar = car1,
                secondCar = car2,
            };
            return combinedCars;
        }

        public static CombinedCars GetComparisonExpense100km(int firstChoice, int secondChoice)
        {
            Car vehicle1 = Car.ConstructCar(firstChoice);
            Car vehicle2 = Car.ConstructCar(secondChoice);

            var result = CompareExpense100km(vehicle1, vehicle2);
            return result;
        }

        public static CombinedCars CompareTaxiRegime(Car car1, Car car2)
        {
            //we can accept 3 parameters to get the user input also on how many days to run
            car1.ComparingResult = car1.TotalCostTaxiRegime(5);
            car2.ComparingResult = car2.TotalCostTaxiRegime(5);

            CombinedCars combinedCars = new CombinedCars()
            {
                firstCar = car1,
                secondCar = car2,
            };
            return combinedCars;
        }

        public static CombinedCars GetComparisonTaxiRegime(int firstChoice, int secondChoice)
        {
            Car vehicle1 = Car.ConstructCar(firstChoice);
            Car vehicle2 = Car.ConstructCar(secondChoice);

            var result = CompareTaxiRegime(vehicle1, vehicle2);
            return result;
        }
    }
}
