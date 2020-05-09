using System;
using System.Collections.Generic;
using Animals;

namespace ConsoleApplication
{
  public class Program
  {
    public static void Main(string[] args)
    {

      string animals = "1 - Wolf \n2 - Tiger \n3 - Bear \n4 - Bird \n5 - Cat \n6 - Dog \n7 - Horse";
      string wildNav = "What do you want this wild beast to do?\nM - Make sound \nH - Hunt";
      string tameNav = "Cuddle? Or do something of the following?\nE - Eat \nT - Talk to owner \nM - Make sound \nN - Give name";

      string topNav = "What do you want to do? \nL - List all animals\nQ - Quit ";

      Console.WriteLine(topNav);

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
          Console.WriteLine("\n==================================\n");
          Console.WriteLine("Choose animal with [1-7]\n\n" + animals);
          Console.WriteLine("\n==================================\n");
        }

        /* wolf */
        if (navigation == "1")
        {
          Wolf alpha = new Wolf();
          Console.WriteLine("\n#########################################################\n");
          Console.WriteLine("Good choice. Here is your wolf!");
          Console.WriteLine("\n#########################################################\n");
          Console.WriteLine(wildNav);
          {
            string method = Console.ReadLine();
            if (method == "M" || method == "m")
            {
              Console.WriteLine("\n#########################################################\n");
              Console.WriteLine(alpha.MakeSound());
              Console.WriteLine("\n#########################################################\n");
              Console.WriteLine(topNav);
            }
            if (method == "H" || method == "h")
            {
              Console.WriteLine("\n#########################################################\n");
              Console.WriteLine(alpha.Hunt());
              Console.WriteLine("\n#########################################################\n");
              Console.WriteLine(topNav);
            }
          }
        }

        /* tiger */
        if (navigation == "2")
        {
          Tiger dofus = new Tiger();
          Console.WriteLine("\n#########################################################\n");
          Console.WriteLine("I see that you like stripes. Or tigers...");
          Console.WriteLine("\n#########################################################\n");
          Console.WriteLine(wildNav);
          {
            string method = Console.ReadLine();
            if (method == "M" || method == "m")
            {
              Console.WriteLine("\n#########################################################\n");
              Console.WriteLine(dofus.MakeSound());
              Console.WriteLine("\n#########################################################\n");
              Console.WriteLine(topNav);
            }
            if (method == "H" || method == "h")
            {
              Console.WriteLine("\n#########################################################\n");
              Console.WriteLine(dofus.Hunt());
              Console.WriteLine("\n#########################################################\n");
              Console.WriteLine(topNav);
            }
          }
        }

        /* bear */
        if (navigation == "3")
        {
          Bear brownie = new Bear();
          Console.WriteLine("\n#########################################################\n");
          Console.WriteLine("Here is bear. Hide the honey.");
          Console.WriteLine("\n#########################################################\n");
          Console.WriteLine(wildNav);
          {
            string method = Console.ReadLine();
            if (method == "M" || method == "m")
            {
              Console.WriteLine("\n#########################################################\n");
              Console.WriteLine(brownie.MakeSound());
              Console.WriteLine("\n#########################################################\n");
              Console.WriteLine(topNav);
            }
            if (method == "H" || method == "h")
            {
              Console.WriteLine("\n#########################################################\n");
              Console.WriteLine(brownie.Hunt());
              Console.WriteLine("\n#########################################################\n");
              Console.WriteLine(topNav);

            }
          }
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