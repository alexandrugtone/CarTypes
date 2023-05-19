using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarObjects
{
    public class CarCannotBeConstructedException : Exception
    {
        public int nrCar;
        public CarCannotBeConstructedException(int nrCar):base("Car cannot be constructed!")
        {
            this.nrCar = nrCar;
        }
    }
}
