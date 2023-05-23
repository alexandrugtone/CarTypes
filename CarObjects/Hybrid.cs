using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CarObjects
{
    public class Hybrid : Car
    {
        public Hybrid(int electricP, int gasOrDiesel, CarType choice)
        {
            //todo: make enum instead of int DONE
            //todo: add diesel to hybrid DONE
            //todo: make an exception if the sum of arguments != 100 DONE
            //todo: verify 30km to hybrid DONE
            var sum = electricP + gasOrDiesel;
            if(sum < 100 || sum > 100)
                throw new CarPercentageIncorrectException(electricP, gasOrDiesel);

            var electric = ConstructCar(CarType.Electric);
            var fuel = ConstructCar(choice);
            MaxSpeed = ((electricP * electric.MaxSpeed) + (gasOrDiesel * fuel.MaxSpeed)) / 200;
            InitialCost = ((electricP * electric.InitialCost) + (gasOrDiesel * fuel.InitialCost)) / 200;
            RunningCost = ((electricP * electric.RunningCost) + (gasOrDiesel * fuel.RunningCost)) / 200;
            if (choice == CarType.Gasoline)
                VehicleType = "HybridGas";
            else
                VehicleType = "HybridDiesel";
        }
    }
}
