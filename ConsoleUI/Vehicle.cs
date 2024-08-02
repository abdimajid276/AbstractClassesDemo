using System;

namespace ConsoleUI;

public abstract class Vehicle
{
    public string Year { get; set; } = "2020";
    public string Make { get; set; } = "Generic Make";
    public string Model { get; set; } = "Generic Model";

    public abstract void DriveAbstract();

    public virtual void DriveVirtualO()
    {
        Console.WriteLine("Vehicle is driving virtual!");
    }

}