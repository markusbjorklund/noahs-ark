using System;
using System.Collections.Generic;
using Animals;

namespace ConsoleApplication
{
  public class Program
  {
    public static void Main(string[] args)
    {

      // start with welcome and list of animals
      string animals = "1 - Wolf \n2 - Tiger \n3 - Bear \n4 - Bird \n5 - Cat \n6 - Dog \n7 - Horse";
      Console.WriteLine("\n=================================\n");
      Console.WriteLine("Welcome to Noahs ark!");
      Console.WriteLine("\nChoose animal with [1-7]");
      Console.WriteLine(animals);
      Console.WriteLine("\n=================================\n");

      // user chooses animal
      int chosenAnimal = Convert.ToInt32(Console.ReadLine());

      // list what the wild animals can do
      string wildNav = "What do you want this wild beast to do?\n1 - Make sound \n2 - Hunt";

      // list what the tame animals can do
      string tameNav = "Cuddle? Or do something of the following?\nE - Eat \nT - Talk to owner \nM - Make sound \nC - Come here \nN - Give name";

      if (chosenAnimal == 1)
      {
        Wolf alpha = new Wolf();
        Console.WriteLine("\n#################################\n");
        Console.WriteLine("Good choice. Here is your wolf!");
        Console.WriteLine("\n#################################\n");
        Console.WriteLine(wildNav);
        {
          int chosenMethod = Convert.ToInt32(Console.ReadLine());
          if (chosenMethod == 1)
          {
            Console.WriteLine("\n#################################\n");
            Console.WriteLine(alpha.MakeSound());
            Console.WriteLine("\n#################################\n");
          }
          if (chosenMethod == 2)
          {
            Console.WriteLine("\n#################################\n");
            Console.WriteLine(alpha.Hunt());
            Console.WriteLine("\n#################################\n");
          }
        }
      }

      if (chosenAnimal == 2)
      {
        Tiger dofus = new Tiger();
        Console.WriteLine("\n#################################\n");
        Console.WriteLine("I see that you like stripes. Or tigers...");
        Console.WriteLine("\n#################################\n");
        Console.WriteLine(wildNav);
        {
          int chosenMethod = Convert.ToInt32(Console.ReadLine());
          if (chosenMethod == 2)
          {
            Console.WriteLine("\n#################################\n");
            Console.WriteLine(dofus.MakeSound());
            Console.WriteLine("\n#################################\n");
          }
          if (chosenMethod == 2)
          {
            Console.WriteLine("\n#################################\n");
            Console.WriteLine(dofus.Hunt());
            Console.WriteLine("\n#################################\n");
          }
        }
      }

      if (chosenAnimal == 3)
      {
        Bear brownie = new Bear();
        Console.WriteLine("\n#################################\n");
        Console.WriteLine("Here is bear. Hide the honey.");
        Console.WriteLine("\n#################################\n");
        Console.WriteLine(wildNav);
        {
          int chosenMethod = Convert.ToInt32(Console.ReadLine());
          if (chosenMethod == 3)
          {
            Console.WriteLine("\n#################################\n");
            Console.WriteLine(brownie.MakeSound());
            Console.WriteLine("\n#################################\n");
          }
          if (chosenMethod == 3)
          {
            Console.WriteLine("\n#################################\n");
            Console.WriteLine(brownie.Hunt());
            Console.WriteLine("\n#################################\n");
          }
        }
      }

      if (chosenAnimal == 4)
      {
        Bird birdie = new Bird("Roadrunner");
        Console.WriteLine(birdie.MakeSound());
        Console.WriteLine(birdie.ComeHere());

        Console.WriteLine("###");
        Console.WriteLine("Rename the animal");
        string newBirdName = Console.ReadLine();
        Bird newbirdie = new Bird(newBirdName);
        Console.WriteLine(newbirdie.MakeSound());
        Console.WriteLine(newbirdie.ComeHere());
      }
    }
  }
}
// string topNav = "What do you want to do? \nL - List all animals\nQ - Quit ";

// Console.WriteLine(topNav);
// Console.WriteLine(animals);
// string navigation = Console.ReadLine();
// navigation.ToString();

// Console.WriteLine("New cat");
// Cat cattie = new Cat("Garfield");
// Console.WriteLine(cattie.MakeSound());
// Console.WriteLine(cattie.ComeHere());

// string rename = Console.ReadLine();
// Cat newcattie = new Cat(rename);
// Console.WriteLine(newcattie.MakeSound());
// Console.WriteLine(newcattie.ComeHere());

// while (true)
// {
//   if (navigation == "1")
//   {

//   }

//   // quit on Q or q
//   if (navigation == "Q" || navigation == "q")
//   {
//     break;
//   }
// }

// /* wolf */
// if (navigation == "1")
// {
//   Wolf alpha = new Wolf();
//   Console.WriteLine("\n#########################################################\n");
//   Console.WriteLine("Good choice. Here is your wolf!");
//   Console.WriteLine("\n#########################################################\n");
//   Console.WriteLine(wildNav);
//   {
//     string method = Console.ReadLine();
//     if (method == "M" || method == "m")
//     {
//       Console.WriteLine("\n#########################################################\n");
//       Console.WriteLine(alpha.MakeSound());
//       Console.WriteLine("\n#########################################################\n");
//       Console.WriteLine(topNav);
//     }
//     if (method == "H" || method == "h")
//     {
//       Console.WriteLine("\n#########################################################\n");
//       Console.WriteLine(alpha.Hunt());
//       Console.WriteLine("\n#########################################################\n");
//       Console.WriteLine(topNav);
//     }

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