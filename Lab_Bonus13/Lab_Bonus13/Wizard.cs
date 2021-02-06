using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_Bonus13
{
    public class Wizard : MagicUsingCharacter
    {
        public int SpellNumber { get; set; }

        public Wizard(int spellNumber, int magicalEnergy, string name, int strength, int intelligence) : base(magicalEnergy, name, strength, intelligence)
        {

            SpellNumber = spellNumber;

        }

        public override void Play()
        {
            Console.WriteLine($"Wizard Name: {Name}, Strength: {Strength}, Intelligence: {Intelligence}, Magical Energy: {MagicalEnergy}, Spell Number: {SpellNumber}");
        }
    }
}
