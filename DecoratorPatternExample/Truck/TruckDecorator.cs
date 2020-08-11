namespace DecoratorPatternExample
{
    public class TruckDecorator : Vehicle
    {
        private Vehicle baseTruck;

        public TruckDecorator(Vehicle baseTruck)
        {
            this.baseTruck = baseTruck;
        }

        public string PackageDescription()
        {
            return baseTruck.PackageDescription();
        }

        public virtual int Cost()
        {
            return baseTruck.Cost();
        }
    }
}