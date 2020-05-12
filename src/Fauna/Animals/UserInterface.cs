using System;
using System.Collections.Generic;

namespace Animals
{
  public class UserInterface
  {
    public UserInterface()
    {
      Console.Clear();
      Console.WriteLine("\n==============================================================\n");
      Console.WriteLine("Welcome to Noahs ark!\n");
      Console.WriteLine("This is a program about the vessel that holds all the animals \n" +
        "in the world. The current animal population is seven and they \n" +
        "are all in THIS ark. If you like animals and are afraid of \n" +
        "the flood this is where you want to be. Even the bird is nice. \n" +
        "And the bear is just too cute with it's manly and dark roar \n" +
        "and sharp long teeths.\n");
      Console.WriteLine("Enjoy your stay and remember to be nice! You're on a vessel \n" +
        "surrounded by water and the help is 2000 or 3000 years away.");
    }

    // quit the program
    public void Stop()
    {
      Environment.Exit(1);
    }

    // start UI
    public void Start()
    {
      // list of animals
      string animals = "1 - Wolf \n2 - Tiger \n3 - Bear \n4 - Bird \n5 - Cat \n6 - Dog \n7 - Horse";
      Console.WriteLine("\n==============================================================\n");
      Console.WriteLine("What animal do you want to play with?\n");
      Console.WriteLine(animals);

      // user chooses animal
      Console.WriteLine("\nChoose animal with [1-7] - Quit with [0]");
      int chosenAnimal = Convert.ToInt32(Console.ReadLine());

      // quit in selection menu
      if (chosenAnimal == 0)
      {
        Stop();
      }

      // list what the wild animals can do and option to quit
      string wildNav = "1 - Make sound \n2 - Hunt \n\nChoose with [1-2] - Choose new animal with [5] - Quit with [0]";

      // list what the tame animals can do and option to quit
      string tameNav = "1 - Eat \n2 - Talk to owner \n3 - Make sound \n4 - Come here \n\nChoose with [1-4] - Choose new animal with [5] - Quit with [0]";

      if (chosenAnimal == 1)
      {
        Console.Clear();
        Wolf alpha = new Wolf();
        {
          while (chosenAnimal == 1)
          {
            Console.WriteLine("\n==============================================================\n");
            Console.WriteLine("What do you want the wolf to do?\n\n" + wildNav);
            int chosenMethod = Convert.ToInt32(Console.ReadLine());
            if (chosenMethod == 1)
            {
              Console.Clear();
              Console.WriteLine("\n==============================================================\n");
              Console.WriteLine(alpha.MakeSound());
            }
            if (chosenMethod == 2)
            {
              Console.Clear();
              Console.WriteLine("\n==============================================================\n");
              Console.WriteLine(alpha.Hunt());
            }
            if (chosenMethod == 5)
            {
              Console.Clear();
              Start();
            }
            if (chosenMethod == 0)
            {
              Stop();
            }
          }
        }
      }

      if (chosenAnimal == 2)
      {
        Console.Clear();
        Tiger dofus = new Tiger();
        while (chosenAnimal == 2)
        {
          Console.WriteLine("\n==============================================================\n");
          Console.WriteLine("What do you want the tiger to do?\n\n" + wildNav);
          int chosenMethod = Convert.ToInt32(Console.ReadLine());
          {
            if (chosenMethod == 1)
            {
              Console.Clear();
              Console.WriteLine("\n==============================================================\n");
              Console.WriteLine(dofus.MakeSound());
            }
            if (chosenMethod == 2)
            {
              Console.Clear();
              Console.WriteLine("\n==============================================================\n");
              Console.WriteLine(dofus.Hunt());
            }
            if (chosenMethod == 5)
            {
              Console.Clear();
              Start();
            }
            if (chosenMethod == 0)
            {
              Stop();
            }
          }
        }
      }

      if (chosenAnimal == 3)
      {
        Console.Clear();
        Bear brownie = new Bear();
        while (chosenAnimal == 3)
        {
          Console.WriteLine("\n==============================================================\n");
          Console.WriteLine("What do you want the bear to do?\n\n" + wildNav);
          int chosenMethod = Convert.ToInt32(Console.ReadLine());
          {
            if (chosenMethod == 1)
            {
              Console.Clear();
              Console.WriteLine("\n==============================================================\n");
              Console.WriteLine(brownie.MakeSound());
            }
            if (chosenMethod == 2)
            {
              Console.Clear();
              Console.WriteLine("\n==============================================================\n");
              Console.WriteLine(brownie.Hunt());
            }
            if (chosenMethod == 5)
            {
              Console.Clear();
              Start();
            }
            if (chosenMethod == 0)
            {
              Stop();
            }
          }
        }
      }

      if (chosenAnimal == 4)
      {
        Console.Clear();
        Console.WriteLine("\n==============================================================\n");
        Console.WriteLine("May we suggest that you start with giving the bird a name:");
        string birdName = Console.ReadLine();
        Bird birdie = new Bird(birdName);
        Console.Clear();
        while (chosenAnimal == 4)
        {
          Console.WriteLine("\n==============================================================\n");
          Console.WriteLine("What do you want " + birdName + " to do?\n\n" + tameNav);
          {
            int chosenMethod = Convert.ToInt32(Console.ReadLine());
            if (chosenMethod == 1)
            {
              Console.Clear();
              Console.WriteLine("\n==============================================================\n");
              Console.WriteLine(birdie.Eat());
            }
            if (chosenMethod == 2)
            {
              Console.Clear();
              Console.WriteLine("\n==============================================================\n");
              Console.WriteLine(birdie.TalkToOwner());
            }
            if (chosenMethod == 3)
            {
              Console.Clear();
              Console.WriteLine("\n==============================================================\n");
              Console.WriteLine(birdie.MakeSound());
            }
            if (chosenMethod == 4)
            {
              Console.Clear();
              Console.WriteLine("\n==============================================================\n");
              Console.WriteLine(birdie.ComeHere());
            }
            if (chosenMethod == 5)
            {
              Console.Clear();
              Start();
            }
            if (chosenMethod == 0)
            {
              Stop();
            }
          }
        }
      }

      if (chosenAnimal == 5)
      {
        Console.Clear();
        Console.WriteLine("\n==============================================================\n");
        Console.WriteLine("May we suggest that you start with giving the cat a name:");
        string catName = Console.ReadLine();
        Cat cattie = new Cat(catName);
        Console.Clear();
        while (chosenAnimal == 5)
        {
          Console.WriteLine("\n==============================================================\n");
          Console.WriteLine("What do you want " + catName + " to do?\n\n" + tameNav);
          {
            int chosenMethod = Convert.ToInt32(Console.ReadLine());
            if (chosenMethod == 1)
            {
              Console.Clear();
              Console.WriteLine("\n==============================================================\n");
              Console.WriteLine(cattie.Eat());
            }
            if (chosenMethod == 2)
            {
              Console.Clear();
              Console.WriteLine("\n==============================================================\n");
              Console.WriteLine(cattie.TalkToOwner());
            }
            if (chosenMethod == 3)
            {
              Console.Clear();
              Console.WriteLine("\n==============================================================\n");
              Console.WriteLine(cattie.MakeSound());
            }
            if (chosenMethod == 4)
            {
              Console.Clear();
              Console.WriteLine("\n==============================================================\n");
              Console.WriteLine(cattie.ComeHere());
            }
            if (chosenMethod == 5)
            {
              Console.Clear();
              Start();
            }
            if (chosenMethod == 0)
            {
              Stop();
            }
          }
        }
      }

      if (chosenAnimal == 6)
      {
        Console.Clear();
        Console.WriteLine("\n==============================================================\n");
        Console.WriteLine("May we suggest that you start with giving the dog a name:");
        string dogName = Console.ReadLine();
        Dog doggie = new Dog(dogName);
        Console.Clear();
        while (chosenAnimal == 6)
        {
          Console.WriteLine("\n==============================================================\n");
          Console.WriteLine("What do you want " + dogName + " to do?\n\n" + tameNav);
          {
            int chosenMethod = Convert.ToInt32(Console.ReadLine());
            if (chosenMethod == 1)
            {
              Console.Clear();
              Console.WriteLine("\n==============================================================\n");
              Console.WriteLine(doggie.Eat());
            }
            if (chosenMethod == 2)
            {
              Console.Clear();
              Console.WriteLine("\n==============================================================\n");
              Console.WriteLine(doggie.TalkToOwner());
            }
            if (chosenMethod == 3)
            {
              Console.Clear();
              Console.WriteLine("\n==============================================================\n");
              Console.WriteLine(doggie.MakeSound());
            }
            if (chosenMethod == 4)
            {
              Console.Clear();
              Console.WriteLine("\n==============================================================\n");
              Console.WriteLine(doggie.ComeHere());
            }
            if (chosenMethod == 5)
            {
              Console.Clear();
              Start();
            }
            if (chosenMethod == 0)
            {
              Stop();
            }
          }
        }
      }

      if (chosenAnimal == 7)
      {
        Console.Clear();
        Console.WriteLine("\n==============================================================\n");
        Console.WriteLine("May we suggest that you start with giving the horse a name:");
        string horseName = Console.ReadLine();
        Horse heppa = new Horse(horseName);
        Console.Clear();
        while (chosenAnimal == 7)
        {
          Console.WriteLine("\n==============================================================\n");
          Console.WriteLine("What do you want " + horseName + " to do?\n\n" + tameNav);
          {
            int chosenMethod = Convert.ToInt32(Console.ReadLine());
            if (chosenMethod == 1)
            {
              Console.Clear();
              Console.WriteLine("\n==============================================================\n");
              Console.WriteLine(heppa.Eat());
            }
            if (chosenMethod == 2)
            {
              Console.Clear();
              Console.WriteLine("\n==============================================================\n");
              Console.WriteLine(heppa.TalkToOwner());
            }
            if (chosenMethod == 3)
            {
              Console.Clear();
              Console.WriteLine("\n==============================================================\n");
              Console.WriteLine(heppa.MakeSound());
            }
            if (chosenMethod == 4)
            {
              Console.Clear();
              Console.WriteLine("\n==============================================================\n");
              Console.WriteLine(heppa.ComeHere());
            }
            if (chosenMethod == 5)
            {
              Console.Clear();
              Start();
            }
            if (chosenMethod == 0)
            {
              Stop();
            }
          }
        }
      }
    }
  }
}