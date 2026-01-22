using System;

namespace VehicleProject
{
    
    public class Vehicle
    {
       
        private int speed; 
        
        public string Brand { get; set; }
        
        public int Speed 
        {
            get { return speed; }
            set { speed = value < 0 ? 0 : value; }
        }

         public virtual void StartEngine()
        {
            Console.WriteLine("Vehicle ka engine start ho raha hai...");
        }
    }
}