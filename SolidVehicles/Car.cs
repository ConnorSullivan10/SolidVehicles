using System;
using System.Collections.Generic;
using System.Text;

namespace SolidVehicles
{
    class Car : IVehicle
    {
        public string Make { get; set; } = "";
        public string Model { get; set; } = "";
        public int YearMake { get; set; } = 0;
        public int fuelCapacity => 12;

        public VehicleColors Color => VehicleColors.black;
        public int passengerOccupancy => 4;

        public Car(string make, string model, int yearMake)
        {
            this.Make = make;
            this.Model = model;
            this.YearMake = yearMake;
        }
        public void Drive()
        {
            Console.WriteLine($"Vroom vroom yelled the aggressive {YearMake} {Color} {Model}. All {passengerOccupancy} passengers were at the edge of their seats.");
        }

        public void Brake()
        {
            Console.WriteLine($"The brakes squealed as the {Make} {Model} slowed down");
        }

        public void Refuel(int gallons)
        {
            if (gallons < fuelCapacity) 
            {
                Console.WriteLine($" You have refueled the {Make} {Model} by {gallons} gallons");
            }
            else
            {
                Console.WriteLine($" You tried to refuel the {Make} {Model} by {gallons} gallons, but luckily the gas pump automatically stopped so your fuel tank didn't overflow");
            }
        }
    }
}
