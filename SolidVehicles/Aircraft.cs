using System;
using System.Collections.Generic;
using System.Text;

namespace SolidVehicles
{
    class Aircraft : IVehicle
    {
        public string PlaneSerial { get; set; } = "";
        public int NumOfPropellers { get; set; } = 2;
        public int fuelCapacity => 100;

        public VehicleColors Color => VehicleColors.white;
        public int passengerOccupancy => 24;

        public Aircraft(string planeSerial, int numOfPropellers)
        {
            this.PlaneSerial = planeSerial;
            this.NumOfPropellers = numOfPropellers;
        }
        public void Fly()
        {
            Console.WriteLine($" All {NumOfPropellers} propellers on the {Color} Aircraft No. {PlaneSerial} screamed Wooooosh as it flew away, with all {passengerOccupancy} passengers glued to their seats.");
        }

        public void Land()
        {
            Console.WriteLine($" Aircraft {PlaneSerial} is Now landing. Brace yourselves.");
        }

        public void Refuel(int gallons)
        {
            if (gallons < fuelCapacity)
            {
                Console.WriteLine($" You have refueled aircraft {PlaneSerial} by {gallons} gallons");
            }
            else
            {
                Console.WriteLine($" You tried to refuel aircraft {PlaneSerial} by {gallons} gallons, but luckily the gas pump automatically stopped so you didn't potentially put all {passengerOccupancy} passengers in danger");
            }
        }
    }
}
