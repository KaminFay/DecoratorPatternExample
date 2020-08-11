namespace DecoratorPatternExample
{
    public abstract class VehicleDecorator : Vehicle
    {
        private Vehicle baseVehicle;

        public VehicleDecorator(Vehicle baseVehicle)
        {
            this.baseVehicle = baseVehicle;
        }
        
        public virtual string PackageDescription()
        {
            return baseVehicle.PackageDescription();
        }

        public virtual int Cost()
        {
            return baseVehicle.Cost();
        }
    }
}