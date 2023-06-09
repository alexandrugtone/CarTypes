﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarObjects
{
    internal class Diesel : Car
    {
        public Diesel()
        {
            MaxSpeed = 150;
            InitialCost = 750;
            RunningCost = 15;
            VehicleType = "Diesel";
        }

        public override string PrintCar()
        {
            string description = base.PrintCar() + $"The max speed is {MaxSpeed}, initial cost is {InitialCost}" +
                $" and running cost per hour at 10km/h is {RunningCost}";
            return description;
        }
    }
}
