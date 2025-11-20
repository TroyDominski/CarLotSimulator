using System;

namespace CarLotSimulator;

public class Car
{
    public int Year { get; set; }
    public string Make { get; set; }
    public string Model { get; set; }
    public string EngineNoise { get; set; }
    public string HonkNoise  { get; set; }
    public bool IsDrivable { get; set; }

    public void MakeEngineNoise(string engineNoise)
    {
        EngineNoise = engineNoise;
        Console.WriteLine($"The {Year} {Make} {Model}'s engine makes it go {EngineNoise}.");
    }

    public void MakeHonkNoise(string honkNoise)
    {
        HonkNoise = honkNoise;
        Console.WriteLine($"The {Year} {Make} {Model}'s horn makes it go {HonkNoise}.");
    }

    public Car()
    {
        
    }
    
        
    

    public Car(string make, string model, int year, bool isDrivable)
    {
        Make = make;
        Model = model;
        Year = year;
        IsDrivable = isDrivable;
    }
}



//Create a seperate class file called Car
//Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
//Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
//The methods should take one string parameter: the respective noise property