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
        public Hybrid(int electricP, int gasolineP)
        {
            //todo: make enum instead of int
            //todo: add diesel to hybrid
            //todo: make an exception if the sum of arguments != 100
            //todo: verify 30km to hybrid
            var electric = ConstructCarFromInt(1);
            var gas = ConstructCarFromInt(2);
            MaxSpeed = ((electricP * electric.MaxSpeed) + (gasolineP * gas.MaxSpeed)) / 200;
        }
    }
}
