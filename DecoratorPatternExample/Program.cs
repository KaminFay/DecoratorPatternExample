using System;

namespace DecoratorPatternExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle v1 = new CarTires(new CarImp());
            Console.WriteLine(v1.PackageDescription());
            Console.WriteLine(v1.Cost());
            Vehicle v2 = new CarTires(v1);
            Console.WriteLine(v2.PackageDescription());
            Console.WriteLine(v2.Cost());
        }
    }
}