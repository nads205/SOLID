using System;
using System.Collections.Generic;

namespace Solid_Princicles_Class_Library
{
    public class Car {
        public string Name { get; set; }
    }

    public class MileageCalculator
    {
        IEnumerable<Car> _cars;
        public MileageCalculator(IEnumerable<Car> cars) { this._cars = cars; }

        public void CalculateMileage()
        {
            foreach (var car in _cars)
            { //changes required if a new manufacturer is added!
                if (car.Name == "Audi")
                    Console.WriteLine("Mileage of the car {0} is {1}", car.Name, "10M");
                else if (car.Name == "Mercedes")
                    Console.WriteLine("Mileage of the car {0} is {1}", car.Name, "20M");
            }
        }
    }
}
