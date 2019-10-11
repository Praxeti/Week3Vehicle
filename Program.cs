using System;
using System.Collections.Generic;

namespace week3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();

            cars.Add( new Car("Ford", "Raptor"));
            cars.Add( new Car("Nissan", "Ultra"));
            
            foreach(Car car in cars)
            {
                Console.WriteLine($"Car = {car.Make} {car.Model}");
            }
            foreach(Car car in cars)
            {
                 for(int i = 0; i < 3; i++)
                    {
                        AccelerateAndGetSpeed(car);
                    }
            }
        }
        static void AccelerateAndGetSpeed(Car car)
        {
            car.Accelerate();
            Console.WriteLine($"The {car.Make} {car.Model} is travelling at speed {car.Speed}");
        }
    }

}
