namespace DecoratorPatternExample.Motercycle
{
    public class CycleImp : Vehicle
    {
        public string PackageDescription()
        {
            return "Base Motorcycle with these features: ";
        }

        public int Cost()
        {
            return 5000;
        }
    }
}