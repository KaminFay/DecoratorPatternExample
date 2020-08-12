namespace DecoratorPatternExample.DiscountDecorators
{
    public class LoyaltyDiscountDecorator : VehicleCoreDecorator
    {
        public LoyaltyDiscountDecorator(Vehicle baseVehicle) : base(baseVehicle)
        {
        }
        
        public override int Cost()
        {
            return base.Cost() - (int) (base.Cost() * .10);
        }
    }
}