using System;
using System.Collections.Generic;

namespace week3
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("Ford", "Raptor");
            Car car2 = new Car("Nissan", "Ultra");

            Console.WriteLine($"Car = {car1.Make} {car1.Model}");
            Console.WriteLine($"Car = {car2.Make} {car2.Model}");

            Console.WriteLine($"The {car1.Make} {car1.Model} is travelling at speed {car1.Speed}");
            car1.Accelerate();
            car1.Accelerate();
            car1.Accelerate();
            car1.Accelerate();
            car1.Accelerate();
            Console.WriteLine($"The {car1.Make} {car1.Model} is travelling at speed {car1.Speed}");
        }
    }
}
