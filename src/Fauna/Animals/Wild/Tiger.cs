using System;

namespace Animals
{
  public class Tiger : Animal, IWild
  {
    public override string MakeSound()
    {
      return "Grrr!";
    }
    public string Hunt()
    {
      return this.GetType().Name + " hunts.";
    }
  }
}