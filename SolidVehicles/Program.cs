using System;
using System.Collections.Generic;

namespace SolidVehicles
{
    class Program
    {
        public static void Main()
        {
           // Build a collection of all vehicles that fly
           List<Aircraft> flyingThings = new List<Aircraft>();
            Aircraft plane1 = new Aircraft("ZVxTN10", 2);
            Aircraft helicopter2 = new Aircraft("VYX5RN", 1);
            Aircraft bigPlane3 = new Aircraft("RAS8490", 3);
            flyingThings.Add(plane1);
            flyingThings.Add(helicopter2);
            flyingThings.Add(bigPlane3);
            // With a single `foreach`, have each vehicle Fly()
            foreach (var flyingThing in flyingThings)
            {
                flyingThing.Fly();
            }

            // Build a collection of all vehicles that operate on roads
            List<Car> roadThings = new List<Car>();
            Car roadWarrior1 = new Car("Toyota", "Prius", 2014);
            Car roadWarrior2 = new Car("Toyota", "Camry", 2015);
            Car roadWarrior3 = new Car("Toyota", "Supra", 2019);
            roadThings.Add(roadWarrior1);
            roadThings.Add(roadWarrior2);
            roadThings.Add(roadWarrior3);
            // With a single `foreach`, have each road vehicle Drive()
            foreach (var roadThing in roadThings)
            {
                roadThing.Drive();
            }

            // Build a collection of all vehicles that operate on water
            List<Watercraft> waterThings = new List<Watercraft>();
            Watercraft fancyBoat1 = new Watercraft(222, "20 ft");
            Watercraft fancyBoat2 = new Watercraft(350, "30 ft");
            Watercraft fancyBoat3 = new Watercraft(800, "60 ft");
            waterThings.Add(fancyBoat1);
            waterThings.Add(fancyBoat2);
            waterThings.Add(fancyBoat3);
            // With a single `foreach`, have each water vehicle Drive()
            foreach (var waterThing in waterThings)
            {
                waterThing.Drive();
            }

            helicopter2.Refuel(20);
            roadWarrior1.Refuel(14);
            fancyBoat3.Refuel(22);
        }
    }
}