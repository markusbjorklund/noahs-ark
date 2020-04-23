using System;
using Animals;

namespace ConsoleApplication
{
  public class Program
  {
    public static void Main(string[] args)
    {
      // Dog doggie = new Dog();
      // Cat cattie = new Cat();
      
      // Console.WriteLine(doggie.TalkToOwner());
      // Console.WriteLine(cattie.TalkToOwner());
      
      Bird birdie = new Bird("Roadrunner");
      Cat cattie = new Cat("Garfield");
      Dog doggie = new Dog("Scooby-Doo");
      Horse heppa = new Horse("Jolly Jumper");
      Bear brownie = new Bear();

      Console.WriteLine(birdie.TalkToOwner());
      Console.WriteLine(cattie.TalkToOwner()); 
      Console.WriteLine(doggie.TalkToOwner());
      Console.WriteLine(heppa.TalkToOwner());
      Console.WriteLine(heppa.ComeHere());
      Console.WriteLine(heppa.MakeSound());
      Console.WriteLine(brownie.Hunt());  
    }
  }
}