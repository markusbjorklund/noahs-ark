using System;
using System.Collections.Generic;
using Animals;

namespace ConsoleApplication
{
  public class Program
  {
    public static void Main(string[] args)
    {

      string wildAnimals = "1 - Wolf \n2 - Tiger \n3 - Bear \n";
      string tameAnimals = "4 - Bird \n5 - Cat \n6 - Dog \n7 - Horse";
      string wildHunts = "M - Make sound \nH - Hunt";
      string tameEats = "E - Eat \nT - Talk to owner \nM - Make sound \nN - Give name";

      string question = "What do you want to do?";
      string initialOptions = "Q - Quit \nL - List all animals";

      Console.WriteLine(question);
      Console.WriteLine(initialOptions);

      while (true)
      {
        string navigation = Console.ReadLine();
        navigation.ToString();

        // quit on Q or q
        if (navigation == "Q" || navigation == "q")
        {
          break;
        }

        // list animals
        if (navigation == "L" || navigation == "l")
        {
          Console.WriteLine(wildAnimals + tameAnimals);
        }

        /* wolf */
        if (navigation == "1")
        {
          string name = "Wolf";
          Console.WriteLine("You have chosen " + name);
          Console.WriteLine(question + "\n" + wildHunts);
        }
      }
    }
  }
}
// Dog doggie = new Dog();
// Cat cattie = new Cat();

// Console.WriteLine(doggie.TalkToOwner());
// Console.WriteLine(cattie.TalkToOwner());

// Bird birdie = new Bird("Roadrunner");
// Cat cattie = new Cat("Garfield");
// Dog doggie = new Dog("Scooby-Doo");
// Horse heppa = new Horse("Jolly Jumper");
// Bear brownie = new Bear();

// Console.WriteLine(birdie.TalkToOwner());
// Console.WriteLine(cattie.MakeSound()); 
// Console.WriteLine(doggie.ComeHere());
// Console.WriteLine(heppa.TalkToOwner());
// Console.WriteLine(heppa.ComeHere());
// Console.WriteLine(heppa.MakeSound());
// Console.WriteLine(brownie.Hunt());