using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarObjects
{
    internal class Gasoline : Car
    {
        public Gasoline()
        {
            MaxSpeed = 200;
            InitialCost = 750;
            RunningCost = 20;
            VehicleType = "Gasoline";
        }

        public override string PrintCar()
        {
            string description = base.PrintCar() + $"The max speed is {MaxSpeed}, initial cost is {InitialCost}" +
                $" and running cost per hour at 10km/h is {RunningCost}";
            return description;
        }
    }
}
