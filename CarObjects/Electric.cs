using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsInherit
{
    internal class Electric : Car
    {
        public Electric()
        {
            MaxSpeed = 100;
            InitialCost = 1000;
            RunningCost = 10;
            VehicleType = "Electric";
        }

        public override void PrintCar()
        {
            base.PrintCar();
            Console.WriteLine($"The max speed is {MaxSpeed}, initial cost is {InitialCost}" +
                $" and running cost per hour at 10km/h is {RunningCost}");
        }
    }
}
