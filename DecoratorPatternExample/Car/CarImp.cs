namespace DecoratorPatternExample
{
    public class CarImp : Vehicle
    {
        public string PackageDescription()
        {
            return "Base Car With these extra features: ";
        }

        public int Cost()
        {
            return 20000;
        }
    }
}