using System;

namespace Animals
{
    public class Dog : Animal, ITame
    {
        public string name { get; set; }
        public int weight { get; set; }

        public Dog(string name)
        {
            this.name = name;
            this.weight = 0;
        }
        public string TalkToOwner()
        {
            return "Woof!";
        }
        public override string MakeSound()
        {
            return "Woof!";
        }

        public string ComeHere()
        {
            return this.name + " came to the owner.";
        }

    }
}