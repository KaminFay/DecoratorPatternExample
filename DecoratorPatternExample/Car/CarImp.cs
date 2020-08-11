namespace DecoratorPatternExample
{
    public class CarImp : Vehicle
    {
        private string make;
        private string model;
        private int cost = 0;
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