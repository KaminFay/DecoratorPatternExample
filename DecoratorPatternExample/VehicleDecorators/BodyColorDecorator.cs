using System.Collections.Generic;

namespace DecoratorPatternExample
{
    public class BodyColorDecorator : VehicleCoreDecorator
    {
        private string color;
        private List<string> colorOptions = new List<string>{"red", "blue", "white"};
        public BodyColorDecorator(Vehicle baseVehicle, string color) : base(baseVehicle)
        {
            if (colorOptions.Contains(color))
            {
                this.color = color;
            }
            else
            {
                this.color = "black";
            }
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
                default:
                    return base.Cost();
            }
        }

        public override string PackageDescription()
        {
            return base.PackageDescription() + " " + color + " Paint Package |";
        }
    }
}