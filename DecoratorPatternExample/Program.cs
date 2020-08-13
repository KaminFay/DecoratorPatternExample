using System;
using DecoratorPatternExample.DiscountDecorators;
using DecoratorPatternExample.Motercycle;

namespace DecoratorPatternExample
{
    class Program
    {
        static void Main(string[] args)
        {

            int value = -1;
            while (value != 0)
            {
                Vehicle v = new CarImp(); // Just giving initializing it to make sure it doesn't break later
                Console.WriteLine("---------- Demo Options ----------");
                Console.WriteLine("1. Base Demo");
                Console.WriteLine("2. User input Demo");
                Console.WriteLine("0. Quit");
                value = Convert.ToInt32(Console.ReadLine());

                if (value == 1)
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
                }else if (value == 2)
                {
                    Console.WriteLine("-------- Select Vehicle Type ---------");
                    Console.WriteLine("1. Car");
                    Console.WriteLine("2. Truck");
                    Console.WriteLine("3. MotorCycle");
                    Console.WriteLine("0. Quit");
                    value = Convert.ToInt32(Console.ReadLine());

                    switch (value)
                    {
                        case 1:
                            v = new CarImp();
                            break;
                        case 2:
                            v = new TruckImp();
                            break;
                        case 3:
                            v = new CycleImp();
                            break;
                        case 0:
                            break;
                        default:
                            break;
                    }

                    Console.WriteLine("---------- Package Additions ----------");
                    int packageValue = -1;
                    while (packageValue != 0)
                    {
                        Console.WriteLine("-------- Select Package ---------");
                        Console.WriteLine("1. Body Color");
                        Console.WriteLine("2. Tinted Windows");
                        Console.WriteLine("3. Tire Package");
                        Console.WriteLine("4. Turbo Package");
                        Console.WriteLine("5. Save Config");
                        Console.WriteLine("0. Quit");
                        packageValue = Convert.ToInt32(Console.ReadLine());
                        
                        switch (packageValue)
                        {
                            case 1:
                                Console.WriteLine("Input a color (red, white, blue).");
                                string color = Console.ReadLine();
                                v = new BodyColorDecorator(v, color);
                                break;
                            case 2:
                                v = new TintedWindowsDecorators(v);
                                break;
                            case 3:
                                v = new TirePackageDecorator(v);
                                break;
                            case 4:
                                v = new TurboChargerPackage(v);
                                break;
                            case 5:
                                value = 0;
                                Console.WriteLine("Current Config: " + v.PackageDescription());
                                Console.WriteLine("Current Cost: " + v.Cost());
                                break;
                            default:
                                break;
                        }

                        if (packageValue == 5)
                        {
                            Console.WriteLine("-------- Select Discount ---------");
                            Console.WriteLine("1. Loyalty Discount 10%");
                            Console.WriteLine("2. Military Discount 20%");
                            Console.WriteLine("0. Quit");
                            packageValue = Convert.ToInt32(Console.ReadLine());

                            switch (packageValue)
                            {
                                case 1:
                                    v = new LoyaltyDiscountDecorator(v);
                                    break;
                                case 2:
                                    v = new MilitaryDiscountDecorator(v);
                                    break;
                            }
                            Console.WriteLine("Config after discount: " + v.PackageDescription());
                            Console.WriteLine("Cost after discount: " + v.Cost());
                            value = 0;
                            packageValue = 0;
                        }

                    }
                }

            }

 
        }
    }
}