using System;

namespace Animals
{
  public class Bird : Animal, ITame
  {
    public string name { get; set; }
    public Bird()
    {
      this.name = name;
    }
    public string TalkToOwner()
    {
      return "Tweet!";
    }
    public string ComeHere()
    {
      return this.name + " came to the owner.";
    }
  }
}