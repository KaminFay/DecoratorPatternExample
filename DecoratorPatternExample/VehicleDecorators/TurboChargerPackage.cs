namespace DecoratorPatternExample
{
    public class TurboChargerPackage : VehicleCoreDecorator
    {
        public TurboChargerPackage(Vehicle baseVehicle) : base(baseVehicle)
        {
        }

        public override int Cost()
        {
            return base.Cost() + 2000;
        }

        public override string PackageDescription()
        {
            return base.PackageDescription() + " Turbo Package |";
        }
    }
}