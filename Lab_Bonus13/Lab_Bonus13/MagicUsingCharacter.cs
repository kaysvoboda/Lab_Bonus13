using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_Bonus13
{
    public class MagicUsingCharacter : GameCharacter
    {

        public int MagicalEnergy { get; set; }

        public MagicUsingCharacter(int magicalEnergy, string name, int strength, int intelligence) : base( name, strength, intelligence)
        {
            MagicalEnergy = magicalEnergy;
        }


        public override void Play()
        {
            Console.WriteLine($"Name: {Name}, Strength: {Strength}, Intelligence: {Intelligence}, Magical Energy: {MagicalEnergy}");
        }


    }
}
