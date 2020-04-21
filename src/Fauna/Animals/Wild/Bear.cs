using System;

namespace Animals
{
  public class Bear : Animal, IWild
  {
    public override string MakeSound()
    {
      return "Roar!";
    }
    public string Hunt()
    {
      return this.GetType().Name + " hunts.";
    }
  }
}