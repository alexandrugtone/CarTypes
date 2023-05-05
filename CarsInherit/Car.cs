using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsInherit
{
    abstract class Car
    {
        string Brand { get; set; }
        int ManufactureYear { get; set; }
        public int MaxSpeed { get; set; }
        public int InitialCost { get; set; }
        /// <summary>
        /// Running Cost per 10km/h
        /// </summary>
        public int RunningCost { get; set; }

        public Car()
        {
            Brand = "BMW";
            ManufactureYear = 2020;
        }

        public virtual void PrintCar()
        {
            Console.WriteLine(Brand + " " + ManufactureYear);
        }

        public int TotalCostWithInitialCost(int hours, int speed)
        {
            int sum = InitialCost;
            sum += hours * ((speed/10) * RunningCost);
            return sum;
        }

        public static Car ConstructCarFromInt(int num)
        {
            Car vehicle1;
            switch (num)
            {
                case 1:
                    vehicle1 = new Electric();
                    break;
                case 2:
                    vehicle1 = new Gasoline();
                    break;
                case 3:
                    vehicle1 = new Diesel();
                    break;
                default: throw new Exception("Does not exist " + num);
            }
            return vehicle1;
        }
    }
}
