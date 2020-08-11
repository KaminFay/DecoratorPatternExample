namespace DecoratorPatternExample
{
    public class CarTires : VehicleDecorator
    {
        public CarTires(Vehicle vehicle) : base(vehicle)
        {
            
        }

        public override string PackageDescription()
        {
            return base.PackageDescription() + " " + WhichTires();
        }

        public string WhichTires()
        {
            return "12 inch rims";
        }

        public override int Cost()
        {
            return base.Cost() + 1000;
        }
    }
}