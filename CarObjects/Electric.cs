﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarObjects
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

        public override string PrintCar()
        {
            string description = base.PrintCar() + $"The max speed is {MaxSpeed}, initial cost is {InitialCost}" +
                $" and running cost per hour at 10km/h is {RunningCost}";
            return description;
        }
    }
}
