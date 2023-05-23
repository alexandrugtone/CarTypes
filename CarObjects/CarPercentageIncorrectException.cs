namespace CarObjects
{
    public class CarPercentageIncorrectException : Exception
    {
        public int electricP;
        public int fuelP;
        public int sum;

        public CarPercentageIncorrectException(int electricP, int fuelP):base("Car cannot be constructed!")
        {
            this.electricP = electricP;
            this.fuelP = fuelP;
            this.sum = electricP + fuelP;
        }
    }
}