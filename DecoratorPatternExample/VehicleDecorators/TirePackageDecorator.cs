namespace DecoratorPatternExample
{
    public class TirePackageDecorator : VehicleCoreDecorator
    {
        private int numberOfTires;
        public TirePackageDecorator(Vehicle vehicle) : base(vehicle)
        {
            if (vehicle.GetType() == typeof(Motercycle.CycleImp))
            {
                numberOfTires = 2;    
            }
            else
            {
                numberOfTires = 4;
            }
        }

        public override string PackageDescription()
        {
            return base.PackageDescription() + " " + WhichTires();
        }

        public string WhichTires()
        {
            return "Adding " + numberOfTires + " upgraded tires (200 per tire) |";
        }

        public override int Cost()
        {
            return base.Cost() + (200 * numberOfTires);
        }
    }
}