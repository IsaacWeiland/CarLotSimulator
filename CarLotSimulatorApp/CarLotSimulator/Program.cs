using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO
            
            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property
            var carTotal = new CarLot();
            var myCar = new Car()
            {
                Year = 2010,
                Make = "Ford",
                Model = "F150",
                EngineNoise = "Purr",
                HonkNoise = "Beep",
                IsDriveable = true
            };
            Car._numberOfCars++;
            carTotal.ListOfCars.Add(myCar);
            Console.WriteLine($"Current car total is: {Car._numberOfCars}");
            var friendCar = new Car();
            friendCar.Year = 2013;
            friendCar.Make = "Honda";
            friendCar.Model = "CRV";
            friendCar.EngineNoise = "Growl";
            friendCar.HonkNoise = "Roar";
            friendCar.IsDriveable = false;
            Car._numberOfCars++;
            carTotal.ListOfCars.Add(friendCar);
            Console.WriteLine($"Current car total is: {Car._numberOfCars}");
            var carFromHell = new Car(2023, "Tesla", "Cybertruck", "Buzz", "Beep Beep", true);
            Car._numberOfCars++;
            Console.WriteLine($"Current car total is: {Car._numberOfCars}");
            carTotal.ListOfCars.Add(carFromHell);
            Car.MakeEngineNoise(myCar.EngineNoise);
            Car.MakeHonkNoise(myCar.HonkNoise);
            Car.MakeEngineNoise(friendCar.EngineNoise);
            Car.MakeHonkNoise(friendCar.HonkNoise);
            Car.MakeEngineNoise(carFromHell.EngineNoise);
            Car.MakeHonkNoise(carFromHell.HonkNoise);
            carTotal.ListOutCars();
            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}
