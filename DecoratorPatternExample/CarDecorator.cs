namespace DecoratorPatternExample
{
    public abstract class CarDecorator : Vehicle
    {
        private Vehicle baseVehicle;

        public CarDecorator(Vehicle baseVehicle)
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