using System;
using System.Collections.Generic;
using System.Text;

namespace SolidVehicles
{
    interface IVehicle
    {
        public int fuelCapacity { get;}
        public VehicleColors Color { get;}
        public int passengerOccupancy { get; }

        void Refuel(int gallons)
        {
        }
    }
    enum VehicleColors
    {
        red,
        yellow,
        green,
        blue,
        purple,
        gray,
        black,
        white
    }
}
