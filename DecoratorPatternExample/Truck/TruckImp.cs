namespace DecoratorPatternExample
{
    public class TruckImp : Vehicle
    {
        public string PackageDescription()
        {
            return "Base Truck with these extra features: ";
        }

        public int Cost()
        {
            return 25000;
        }
    }
}