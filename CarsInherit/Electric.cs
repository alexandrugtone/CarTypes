using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsInherit
{
    internal class Electric : Car
    {
        public int MaxSpeed { get; set; }
        public int InitialCost { get; set; }
        public int RunningCost { get; set; }

        public Electric()
        {
            MaxSpeed = 100;
            InitialCost = 1000;
            RunningCost = 10;
        }

        public void PrintDetails()
        {
            Console.WriteLine($"The max speed is {MaxSpeed}, initial cost is {InitialCost}" +
                $" and running cost per hour at 10km/h is {RunningCost}");
        }
    }
}
