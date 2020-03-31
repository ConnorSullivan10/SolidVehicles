using System;
using System.Collections.Generic;
using System.Text;

namespace SolidVehicles
{
    class Watercraft : IVehicle
    {
        public int TotalHorsepower { get; set; } = 0;
        public string Length { get; set; } = "";
        public int fuelCapacity => 30;

        public VehicleColors Color => VehicleColors.white;
        public int passengerOccupancy => 8;


        public Watercraft(int totalHorsePower, string length)
        {
            TotalHorsepower = totalHorsePower;
            Length = length;
        }
        public void Drive()
        {
            Console.WriteLine($"Pew pewwwwwwwwww. That {TotalHorsepower}hp boat is pretty fast and looks bigger than it's actual size of {Length}. It passed by like a flash of {Color}, to where you could hardly see there were {passengerOccupancy} people inside.");
        }

        public void Refuel(int gallons)
        {
            if (gallons < fuelCapacity)
            {
                Console.WriteLine($" You have refueled the boat by {gallons} gallons");
            }
            else
            {
                Console.WriteLine($" You tried to refuel the boat by {gallons} gallons, but luckily the gas pump automatically stopped so your fuel tank didn't overflow.");
            }
        }
    }
}
