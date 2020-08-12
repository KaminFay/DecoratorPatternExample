namespace DecoratorPatternExample
{
    public class VehicleCoreDecorator : Vehicle 
    {
        private Vehicle baseVehicle;

        public VehicleCoreDecorator(Vehicle baseVehicle)
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