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
      Console.WriteLine(birdie.TalkToOwner());  
    }
  }
}