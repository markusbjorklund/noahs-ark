using System;

namespace Animals
{
    public class Bird : Animal, ITame
    {
        public string name { get; set; }
        public int weight { get; set; }

        public Bird(string name)
        {
            this.name = name;
            this.weight = 0;
        }
        
        public string TalkToOwner()
        {
            return "Tweet!";
        }
        public override string MakeSound()
        {
            return "Tweet!";
        }

        public string ComeHere()
        {
            return this.name + " came to the owner.";
        }
    }
}