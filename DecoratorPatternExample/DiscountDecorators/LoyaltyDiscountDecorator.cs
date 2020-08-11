namespace DecoratorPatternExample.DiscountDecorators
{
    public class LoyaltyDiscountDecorator : VehicleDecorator
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