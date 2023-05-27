using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarObjects
{
    //todo: comment hybrid diesel/gasoline and implement switch
    [Flags]
    public enum CarType
    {
        None = 0,
        Electric = 1,
        Gasoline = 2,
        Diesel = 4,
        //HybridDiesel = 5,
        //HybridGas = 3,
    }

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
        public int ComparingResult { get; set; }

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
            var carInfo = ConstructCar(id);
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

        public int TotalCostTaxiRegime(int days)
        {
            const int dailyHours = 8;
            const int maxSpeedperH = 30;
            int sum = days * (dailyHours * (maxSpeedperH / 10 * RunningCost));
            return sum;
        }

        public static Car ConstructCar(int num)
        {
            CarType choice = (CarType)num;
            return ConstructCar(choice);
        }

        public static Car ConstructCar(CarType choice)
        {
            Car vehicle1;
            switch (choice)
            {
                case CarType.Electric:
                    vehicle1 = new Electric(); break;
                case CarType.Gasoline:
                    vehicle1 = new Gasoline(); break;
                case CarType.Diesel:
                    vehicle1 = new Diesel(); break;
                case CarType.Electric | CarType.Gasoline: //todo: delete hybridgas and identify with flags the combination
                    vehicle1 = new Hybrid(25, 75, CarType.Gasoline); break;
                case CarType.Electric | CarType.Diesel:
                    vehicle1 = new Hybrid(25, 75, CarType.Diesel); break;
                default: throw new Exception();
            }
            return vehicle1;
        }
    }
}
