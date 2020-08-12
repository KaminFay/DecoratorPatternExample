namespace DecoratorPatternExample
{
    public class BodyPackageDecorator : VehicleCoreDecorator
    {
        public BodyPackageDecorator(Vehicle baseVehicle) : base(baseVehicle)
        {
        }

        public override int Cost()
        {
            return base.Cost() + 500;
        }

        public override string PackageDescription()
        {
            return base.PackageDescription() + " Upgraded Body Package |";
        }
    }
}