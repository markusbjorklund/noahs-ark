using System;

namespace Animals
{
  public class Wolf : Animal, IWild
  {
    public override string MakeSound()
    {
      return "Owooooo!";
    }
    public string Hunt()
    {
      return this.GetType().Name + " hunts.";
    }
  }
}