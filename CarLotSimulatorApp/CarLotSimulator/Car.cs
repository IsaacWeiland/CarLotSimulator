using System;

namespace CarLotSimulator;

public class Car
{
    public static int _numberOfCars = 0;
    public int Year { get; set; }
    public string Make { get; set; }
    public string Model { get; set; }
    public string EngineNoise { get; set; }
    public string HonkNoise { get; set; }
    public bool IsDriveable { get; set; }

    public static void MakeEngineNoise(string engineNoise)
    {
        Console.WriteLine(engineNoise);
    }

    public static void MakeHonkNoise(string honkNoise)
    {
        Console.WriteLine(honkNoise);
    }

    public Car()
    {
        
    }
    public Car(int year, string make, string model, string engineNoise, string honkNoise, bool isDriveable)
    {
        Year = year;
        Make = make;
        Model = model;
        EngineNoise = engineNoise;
        HonkNoise = honkNoise;
        IsDriveable = isDriveable;
    }
}