using System;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle:

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: public int NumberOfWheels { get; set; }
             */


            //In ICompany: 

            /* Create 2 members that are specific to each every company
             * regardless of vehicle type.
             * Example: public string Logo { get; set; }
             */

            //In each of your Car, Truck, and SUV classes

            /* Create 2 members that are specific to each class
             * Example for Car: public bool HasTrunk { get; set; }
             * Example for SUV: public int NumberOfSeats { get; set; }
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             */

            //Now, create objects of your 3 classes and give their members values.
            //Creatively display and organize their values

            //Option for displaying values: 
            //Create a stubbed out method called DisplayDetails in your IVehicle interface.
            //Implement the stubbed out method in the derived classes.
            //In the scope of them method, use string interpolation to display property values.
            //In order to also interpolate values from ICompany, research how to extend interfaces.

            var car = new Car() { CompanyName = "Car Company", EngineSize = 3.0, HasTrunk = true, Make = "Honda", Model = "Civic", Motto = "The HONDA Co.", SeatCount = 4, SoundSystemGrade = "premium" };
            var truck = new Truck() { BedLength = 5.5, CompanyName = "Truck Company", EngineSize = 5.0, HasFourWheelDrive = true, Make = "Ford", Model = "F150", Motto = "The FORD Co.", SeatCount = 2};
            var SUV = new SUV() { CompanyName = "SUV Company", EngineSize = 2.5, HasAwd = true, HasFullSizeSpare = true, Make = "Subaru", Model = "Outback", Motto = "The SUBARU Co", SeatCount = 5};

            car.DisplayDetails();
            truck.DisplayDetails();
            SUV.DisplayDetails();
            
        }
    }
}
