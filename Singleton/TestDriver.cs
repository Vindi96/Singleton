using System;

namespace Singleton
{
    class TestDriver
    {
        static void Main(string[] args)
        {
            Driver obj1 = Driver.Getter();
            Driver obj2 = Driver.Getter();

            Console.WriteLine(obj1.GetHashCode());
            Console.WriteLine(obj2.GetHashCode());
        }
    }
    
}
