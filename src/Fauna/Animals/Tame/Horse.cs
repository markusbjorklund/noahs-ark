using System;

namespace Animals
{
    public class Horse : Animal, ITame
    {
        public string name { get; set; }
        public int weight { get; set; }
        public Horse(string name)
        {
            this.name = name;
            this.weight = 0;
        }
        public string TalkToOwner()
        {
            return "Ihahaa!";
        }
        public override string MakeSound()
        {
            return "Hello!";
        }

        public string ComeHere()
        {
            return this.name + " came to the owner.";
        }

    }
}