namespace DecoratorPatternExample
{
    public class BodyColorDecorator : VehicleDecorator
    {
        private string color;
        public BodyColorDecorator(Vehicle baseVehicle, string color) : base(baseVehicle)
        {
            this.color = color;
        }

        public override int Cost()
        {
            switch (this.color)
            {
                case "red":
                    return base.Cost() + 500;
                case "blue":
                    return base.Cost() + 600;
                case "white":
                    return base.Cost() + 700;
            }

            return base.Cost();
        }

        public override string PackageDescription()
        {
            return base.PackageDescription() + " " + color + " Paint Package |";
        }
    }
}