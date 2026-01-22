using System;
using System.Collections.Generic;

namespace VehicleProject
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> showroom = new List<Vehicle>();
            showroom.Add(new Car { Brand = "Toyota", Speed = 120 });
            showroom.Add(new Truck { Brand = "Tata", Speed = 80 });

            Console.WriteLine("=== Vehicle System Test Started ===");
            Console.WriteLine();

            foreach (var v in showroom)
            {
                v.StartEngine();
                if (v is IStoppable stoppableVehicle)
                {
                    stoppableVehicle.ApplyBrakes();
                }
                
                if (v is Truck myTruck)
                {
                    myTruck.LoadCargo();
                }

                Console.WriteLine("-----------------------------------");
            }

            Console.WriteLine("=== Test Completed Successfully ===");
        }
    }
}