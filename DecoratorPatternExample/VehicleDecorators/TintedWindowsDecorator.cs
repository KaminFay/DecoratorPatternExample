namespace DecoratorPatternExample
{
    public class TintedWindowsDecorators : VehicleDecorator
    {
        public TintedWindowsDecorators(Vehicle baseVehicle) : base(baseVehicle)
        {
        }

        public override string PackageDescription()
        {
            return base.PackageDescription() + " " + "Tinted Windows Package |";
        }

        public override int Cost()
        {
            return base.Cost() + 500;
        }
    }
}