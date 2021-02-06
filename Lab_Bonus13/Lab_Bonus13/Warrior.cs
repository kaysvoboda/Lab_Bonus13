using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_Bonus13
{
    public class Warrior : GameCharacter
    {
        public string WeaponType { get; set; }

        public Warrior(string weaponType, string name, int strength, int intelligence) : base ( name,  strength, intelligence)
        {
            WeaponType = weaponType;
        }

        public override void Play()
        {
            Console.WriteLine($"Warrior Name: {Name}, Strength:{Strength}, Intelligence: {Intelligence}, WeaponType: {WeaponType}");
        }

    }
}
