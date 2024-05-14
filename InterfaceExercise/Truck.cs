using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class Truck : IVehicle, ICompany
    {
        public bool HasFourWheelDrive { get; set; } = false;
        public double BedLength {  get; set; }
        public double EngineSize { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int SeatCount { get; set; }
        public string CompanyName { get; set; }
        public string Motto { get; set; }

        public void Drive()
        {
            if (HasFourWheelDrive)
            {
                Console.WriteLine($"{GetType().Name} now driving forward in 4WD...");
            } else
            {
                Console.WriteLine($"{GetType().Name} now driving forward in 2WD...");
            }

        }
        public void Park()
        {
            Console.WriteLine($"{GetType().Name} now parked ...");
        }

        public void Reverse()
        {
            Console.WriteLine($"{GetType().Name} now driving in reverse ...");
        }
        public void DisplayDetails()
        {
            Console.WriteLine($"This {this.Make} {this.Model} has an engine size of {this.EngineSize} and has {this.SeatCount} seats." +
                $"The company name is'{this.CompanyName}' and the motto is '{this.Motto}'");
            Console.WriteLine($"And more info on the vehicle -- Has 4WD : {HasFourWheelDrive}, Bed length in feet : {BedLength}");
            Drive();
            Park();
            Reverse();
            Console.WriteLine("");
        }
    }
}
