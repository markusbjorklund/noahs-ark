using System;

namespace Animals
{
  public class Cat : Animal, ITame
  {
    public string name { get; set; }
    public Cat(string name)
    {
      this.name = name;
    }
    public string TalkToOwner()
    {
      return "Meow!";
    } 
     public override string MakeSound()
    {
      return "Meow!";
    }
    
    public string ComeHere()
    {
      return this.name + " came to the owner.";
    }
  
  }
}