using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class SUV : IVehicle, ICompany
    {
        public bool HasAwd { get; set; } = true;
        public bool HasFullSizeSpare {  get; set; }
        public double EngineSize {  get; set; }
        public string Make {  get; set; }
        public string Model {  get; set; }
        public int SeatCount {  get; set; }
        public string CompanyName {  get; set; }
        public string Motto {  get; set; }

        public void Drive()
        {
            if (HasAwd)
            {
                Console.WriteLine($"{GetType().Name} now driving forward in AWD...");
            }
            else
            {
                Console.WriteLine($"{GetType().Name} now driving forward...");
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
            Console.WriteLine($"And more info on the vehicle -- Has AWD : {HasAwd}, Has full-sized spare : {HasFullSizeSpare}");
            Drive();
            Park();
            Reverse();
            Console.WriteLine("");
        }
    }
}
