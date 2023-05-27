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
            var sum = electricP + gasOrDiesel;
            if(sum < 100 || sum > 100)
                throw new CarPercentageIncorrectException(electricP, gasOrDiesel);

            var electric = ConstructCar(CarType.Electric);
            var fuel = ConstructCar(choice);
            MaxSpeed = ((electricP * electric.MaxSpeed) + (gasOrDiesel * fuel.MaxSpeed)) / 200;
            InitialCost = ((electricP * electric.InitialCost) + (gasOrDiesel * fuel.InitialCost)) / 200;
            RunningCost = ((electricP * electric.RunningCost) + (gasOrDiesel * fuel.RunningCost)) / 200;
            VehicleType = (CarType.Electric | choice).ToString();
        }
    }
}
