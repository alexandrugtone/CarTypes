using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarObjects
{
    public abstract class Car
    {
        string Brand { get; set; }
        int ManufactureYear { get; set; }
        public int MaxSpeed { get; set; }
        public int InitialCost { get; set; }
        public string VehicleType { get; set; }
        /// <summary>
        /// Running Cost per 10km/h
        /// </summary>
        public int RunningCost { get; set; }

        public Car()
        {
            Brand = "BMW";
            ManufactureYear = 2020;
        }

        public virtual string PrintCar()
        {
            string description = $"{this.Brand} {this.ManufactureYear} can reach {this.MaxSpeed} and costs {this.RunningCost}!";
            return description;
        }

        public static Car GetCar(int id)
        {
            var carInfo = ConstructCarFromInt(id);
            return carInfo;
        }

        public int TotalCostWithInitialCost(int hours, int speed)
        {
            int sum = InitialCost;
            sum += hours * ((speed/10) * RunningCost);
            return sum;
        }

        public int TotalCostWithoutInitialCost100km(int hours)
        {
            int sum = hours * (10 * RunningCost);
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

        public int TotalCostTaxiRegime(int days)
        {
            const int dailyHours = 8;
            const int maxSpeedperH = 30;
            int sum = days * (dailyHours * (maxSpeedperH / 10 * RunningCost));
            return sum;
        }
    }
}
