namespace DecoratorPatternExample.DiscountDecorators
{
    public class MilitaryDiscountDecorator : VehicleCoreDecorator
    {
        public MilitaryDiscountDecorator(Vehicle baseVehicle) : base(baseVehicle)
        {
        }

        public override int Cost()
        {
            return base.Cost() - (int) (base.Cost() * .20);
        }
    }
}