using System;
using DecoratorPatternExample.DiscountDecorators;
using DecoratorPatternExample.Motercycle;

namespace DecoratorPatternExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle v1 = new TirePackageDecorator(new CarImp());
            Console.WriteLine(v1.PackageDescription());
            Console.WriteLine(v1.Cost());
            Vehicle v2 = new TintedWindowsDecorators(new TruckImp());
            Console.WriteLine(v2.PackageDescription());
            Console.WriteLine(v2.Cost());
            
            Vehicle v3 = new BodyPackageDecorator(new BodyColorDecorator(new CarImp(), "red"));
            
            Console.WriteLine(v3.PackageDescription());
            Console.WriteLine("Cost before Loyalty Discount " + v3.Cost());
            
            v3 = new LoyaltyDiscountDecorator(v3);
            Console.WriteLine("Cost after Loyalty Discount of 10%: " + v3.Cost());

            Console.WriteLine("What if we apply the discount to the base car then add the packages?");
            Vehicle v4 = new LoyaltyDiscountDecorator(new CarImp());
            Console.WriteLine("Here is the cost: " + v4.Cost());
            v4 = new BodyPackageDecorator(new BodyColorDecorator(v4, "red"));
            Console.WriteLine("Here is the cost after the added things from above: " + v4.Cost());

            Vehicle v5 = new TirePackageDecorator(new CycleImp());
            Vehicle v6 = new TirePackageDecorator(new CarImp());

            Console.WriteLine("Upgraded tire package on motorcycle: ");
            Console.WriteLine(v5.PackageDescription());
            Console.WriteLine(v5.Cost());
            Console.WriteLine("Upgraded tire package on car: ");
            Console.WriteLine(v6.PackageDescription());
            Console.WriteLine(v6.Cost());
        }
    }
}