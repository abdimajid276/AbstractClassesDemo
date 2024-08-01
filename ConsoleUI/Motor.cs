using System;

namespace ConsoleUI;

public class Motor : Vehicle
{
   public bool HasSideCart { get; set; }

   public override void DriveAbstract()
   {
      Console.WriteLine("Motorcycle is driving abstract");
   }

   public override void DriveVirtualO()
   {
      Console.WriteLine("Motorcycle is driving virtual");
   }
}