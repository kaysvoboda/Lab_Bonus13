using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_Bonus13
{
    public class GameCharacter
    {
        public string Name { get; set; } 

        public int Strength { get; set; }

        public int Intelligence { get; set; }


        public GameCharacter(string name, int strength, int intelligence)
        {
            Name = name;
            Strength = strength;
            Intelligence = intelligence;
        }

        public virtual void Play()
        {
            Console.WriteLine($"Name: {Name}, Strength:{Strength}, Intelligence: {Intelligence}");
        }

    }
}
