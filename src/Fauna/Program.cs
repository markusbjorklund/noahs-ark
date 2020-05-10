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
      Console.WriteLine("\n==============================================================\n");
      Console.WriteLine("Welcome to Noahs ark!");
      Console.WriteLine("\n==============================================================\n");
      Console.WriteLine("Here is our list of animals:\n");
      Console.WriteLine(animals);

      // user chooses animal
      Console.WriteLine("\nChoose animal with [1-7]:");
      int chosenAnimal = Convert.ToInt32(Console.ReadLine());

      // list what the wild animals can do and option to quit
      string wildNav = "1 - Make sound \n2 - Hunt \n\nQuit the program with [0]";

      // list what the tame animals can do and option to quit
      string tameNav = "1 - Eat \n2 - Talk to owner \n3 - Make sound \n4 - Come here \n\nQuit the program with [0]";

      while (chosenAnimal == 1)
      {
        Wolf alpha = new Wolf();
        Console.WriteLine("\n==============================================================\n");
        Console.WriteLine("What do you want the wolf to do?\n\n" + wildNav);
        {
          int chosenMethod = Convert.ToInt32(Console.ReadLine());
          if (chosenMethod == 1)
          {
            Console.WriteLine("\n==============================================================\n");
            Console.WriteLine(alpha.MakeSound());

          }
          if (chosenMethod == 2)
          {
            Console.WriteLine("\n==============================================================\n");
            Console.WriteLine(alpha.Hunt());
          }
          if (chosenMethod == 0)
          {
            break;
          }
        }
      }

      while (chosenAnimal == 2)
      {
        Tiger dofus = new Tiger();
        Console.WriteLine("\n==============================================================\n");
        Console.WriteLine("What do you want the tiger to do?\n\n" + wildNav);
        {
          int chosenMethod = Convert.ToInt32(Console.ReadLine());
          if (chosenMethod == 1)
          {
            Console.WriteLine("\n==============================================================\n");
            Console.WriteLine(dofus.MakeSound());
          }
          if (chosenMethod == 2)
          {
            Console.WriteLine("\n==============================================================\n");
            Console.WriteLine(dofus.Hunt());
          }
          if (chosenMethod == 0)
          {
            break;
          }
        }
      }

      while (chosenAnimal == 3)
      {
        Bear brownie = new Bear();
        Console.WriteLine("\n==============================================================\n");
        Console.WriteLine("What do you want the bear to do?\n\n" + wildNav);
        {
          int chosenMethod = Convert.ToInt32(Console.ReadLine());
          if (chosenMethod == 1)
          {
            Console.WriteLine("\n==============================================================\n");
            Console.WriteLine(brownie.MakeSound());
          }
          if (chosenMethod == 2)
          {
            Console.WriteLine("\n==============================================================\n");
            Console.WriteLine(brownie.Hunt());
          }
          if (chosenMethod == 0)
          {
            break;
          }
        }
      }

      if (chosenAnimal == 4)
      {
        Console.WriteLine("\n==============================================================\n");
        Console.WriteLine("May I suggest that you start with giving your pet a name:");
        string birdName = Console.ReadLine();
        Bird birdie = new Bird(birdName);
        while (chosenAnimal == 4)
        {
          Console.WriteLine("\n==============================================================\n");
          Console.WriteLine("What do you want " + birdName + " to do?\n\n" + tameNav);
          {
            int chosenMethod = Convert.ToInt32(Console.ReadLine());
            if (chosenMethod == 1)
            {
              Console.WriteLine("\n==============================================================\n");
              Console.WriteLine("This is for the eat function!");
            }
            if (chosenMethod == 2)
            {
              Console.WriteLine("\n==============================================================\n");
              Console.WriteLine(birdie.TalkToOwner());
            }
            if (chosenMethod == 3)
            {
              Console.WriteLine("\n==============================================================\n");
              Console.WriteLine(birdie.MakeSound());
            }
            if (chosenMethod == 4)
            {
              Console.WriteLine("\n==============================================================\n");
              Console.WriteLine(birdie.ComeHere());
            }
            if (chosenMethod == 0)
            {
              break;
            }
          }
        }
      }

      if (chosenAnimal == 5)
      {
        Console.WriteLine("\n==============================================================\n");
        Console.WriteLine("May I suggest that you start with giving your pet a name:");
        string catName = Console.ReadLine();
        Cat cattie = new Cat(catName);
        while (chosenAnimal == 5)
        {
          Console.WriteLine("\n==============================================================\n");
          Console.WriteLine("What do you want " + catName + " to do?\n\n" + tameNav);
          {
            int chosenMethod = Convert.ToInt32(Console.ReadLine());
            if (chosenMethod == 1)
            {
              Console.WriteLine("\n==============================================================\n");
              Console.WriteLine("This is for the eat function!");
            }
            if (chosenMethod == 2)
            {
              Console.WriteLine("\n==============================================================\n");
              Console.WriteLine(cattie.TalkToOwner());
            }
            if (chosenMethod == 3)
            {
              Console.WriteLine("\n==============================================================\n");
              Console.WriteLine(cattie.MakeSound());
            }
            if (chosenMethod == 4)
            {
              Console.WriteLine("\n==============================================================\n");
              Console.WriteLine(cattie.ComeHere());
            }
            if (chosenMethod == 0)
            {
              break;
            }
          }
        }
      }

      if (chosenAnimal == 6)
      {
        Console.WriteLine("\n==============================================================\n");
        Console.WriteLine("May I suggest that you start with giving your pet a name:");
        string dogName = Console.ReadLine();
        Dog doggie = new Dog(dogName);
        while (chosenAnimal == 6)
        {
          Console.WriteLine("\n==============================================================\n");
          Console.WriteLine("What do you want " + dogName + " to do?\n\n" + tameNav);
          {
            int chosenMethod = Convert.ToInt32(Console.ReadLine());
            if (chosenMethod == 1)
            {
              Console.WriteLine("\n==============================================================\n");
              Console.WriteLine("This is for the eat function!");
            }
            if (chosenMethod == 2)
            {
              Console.WriteLine("\n==============================================================\n");
              Console.WriteLine(doggie.TalkToOwner());
            }
            if (chosenMethod == 3)
            {
              Console.WriteLine("\n==============================================================\n");
              Console.WriteLine(doggie.MakeSound());
            }
            if (chosenMethod == 4)
            {
              Console.WriteLine("\n==============================================================\n");
              Console.WriteLine(doggie.ComeHere());
            }
            if (chosenMethod == 0)
            {
              break;
            }
          }
        }
      }

      if (chosenAnimal == 7)
      {
        Console.WriteLine("\n==============================================================\n");
        Console.WriteLine("May I suggest that you start with giving your pet a name:");
        string horseName = Console.ReadLine();
        Horse heppa = new Horse(horseName);
        while (chosenAnimal == 7)
        {
          Console.WriteLine("\n==============================================================\n");
          Console.WriteLine("What do you want " + horseName + " to do?\n\n" + tameNav);
          {
            int chosenMethod = Convert.ToInt32(Console.ReadLine());
            if (chosenMethod == 1)
            {
              Console.WriteLine("\n==============================================================\n");
              Console.WriteLine("This is for the eat function!");
            }
            if (chosenMethod == 2)
            {
              Console.WriteLine("\n==============================================================\n");
              Console.WriteLine(heppa.TalkToOwner());
            }
            if (chosenMethod == 3)
            {
              Console.WriteLine("\n==============================================================\n");
              Console.WriteLine(heppa.MakeSound());
            }
            if (chosenMethod == 4)
            {
              Console.WriteLine("\n==============================================================\n");
              Console.WriteLine(heppa.ComeHere());
            }
            if (chosenMethod == 0)
            {
              break;
            }
          }
        }
      }
    }
  }
}