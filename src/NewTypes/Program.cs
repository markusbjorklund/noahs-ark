  
using System;
using Pets;

namespace ConsoleApplication
{
  public class Program
  {
    public static void Main(string[] args)
    {
      Dog doggie = new Dog();
      Console.WriteLine(doggie.TalkToOwner());
    }
  }
}