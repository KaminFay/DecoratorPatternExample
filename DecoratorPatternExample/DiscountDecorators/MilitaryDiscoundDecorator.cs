namespace DecoratorPatternExample.DiscountDecorators
{
    public class MilitaryDiscoundDecorator : VehicleDecorator
    {
        public MilitaryDiscoundDecorator(Vehicle baseVehicle) : base(baseVehicle)
        {
        }

        public override int Cost()
        {
            return base.Cost() - (int) (base.Cost() * .20);
        }
    }
}