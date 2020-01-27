using System;

namespace ex_01
{
    class Program
    {
        static void Main(string[] args)
        {
            var bumbo = new Car()
            {
                Brand = "Car",
                Model = "A2",
                Year = 1985,
                Color = "Yellow"
            };
            
            Console.WriteLine(bumbo.Display());
        }
    }
}
