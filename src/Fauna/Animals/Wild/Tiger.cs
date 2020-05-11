using System;

namespace Animals
{
    public class Tiger : Animal, IWild
    {
        public int weight { get; set; }

        public Tiger()
        {
            this.weight = 0;
        }

        public override string MakeSound()
        {
            return "Grrr!";
        }
        public string Hunt()
        {
            Random random = new Random();
            int num = random.Next(1, 11);
            if (num <= 6)
            {
                this.weight += 1;
                return this.GetType().Name + " finds food, gains 1 kg and weighs now " + this.weight + " kg.";
            }
            else
            {
                return this.GetType().Name + " does not find food and weighs " + this.weight + " kg.";
            }
        }
    }
}