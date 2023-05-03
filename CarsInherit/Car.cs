using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsInherit
{
    internal class Car
    {
        string Brand { get; set; }
        string Model { get; set; }
        int ManufactureYear { get; set; }

        public Car()
        {
            Brand = "BMW";
            Model = "M2";
            ManufactureYear = 2020;
        }

        public void PrintCar()
        {
            Console.WriteLine(Brand + " " + Model + " " + ManufactureYear);
        }
    }
}
