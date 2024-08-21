using System;
using System.Collections.Generic;

namespace CarLotSimulator;

public class CarLot
{
    public List<Car> ListOfCars { get; set; } = new List<Car>();

    public void ListOutCars()
    {
        Console.WriteLine("Car Lot:");
        foreach (var car in ListOfCars)
        {
            Console.WriteLine($"{car.Year} {car.Make} {car.Model}");
        }
    }
}