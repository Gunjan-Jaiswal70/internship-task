using System;

namespace VehicleProject 
{
    public interface IStoppable
    {
        void ApplyBrakes();
    }

    public class Car : Vehicle, IStoppable
    {
        public override void StartEngine()
        {
            Console.WriteLine($"{Brand} Car: Button dabaya aur engine start!");
        }

        public void ApplyBrakes()
        {
            Console.WriteLine($"{Brand} Car: ABS brakes lagaye gaye, gaadi turant ruk gayi.");
        }
    }
        public class Truck : Vehicle, IStoppable
    {
        public override void StartEngine()
        {
            Console.WriteLine($"{Brand} Truck: Chabi ghumai aur heavy engine start!");
        }

        public void ApplyBrakes()
        {
            Console.WriteLine($"{Brand} Truck: Air brakes lagaye gaye, gaadi dhire dhire ruki.");
        }
        
        public void LoadCargo()
        {
            Console.WriteLine($"{Brand} Truck: Saman load ho raha hai...");
        }
    }
}