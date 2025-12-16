using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO
            var carLotOne = new CarLot();
            
            var carOne = new Car();
            carOne.Make = "Ford";
            carOne.Model = "Crown Vic";
            carOne.Year = 1992;
            carOne.IsDrivable = true;
            
            carOne.MakeEngineNoise("vroom");
            carOne.MakeHonkNoise("beep");
            carLotOne.ParkingLot.Add(carOne);
            var carTwo = new Car();

            carTwo.Make = "Toyota";
            carTwo.Model = "Camre";
            carTwo.Year = 2000;
            carTwo.IsDrivable = false;
            
            carTwo.MakeEngineNoise("clank");
            carTwo.MakeHonkNoise("beep");
            carLotOne.ParkingLot.Add(carTwo);
            
            var carThree = new Car("Ford", "FiveHundred", 2005, true);
            

            carThree.MakeEngineNoise("grrrrr");
            carThree.MakeHonkNoise("beep beep");
            carLotOne.ParkingLot.Add(carThree);
            carLotOne.CheckCars();
            
            Console.WriteLine($"The number of cars int the lot is: {CarLot.numberOfCars}");




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
