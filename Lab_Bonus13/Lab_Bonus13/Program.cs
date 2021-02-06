using System;
using System.Collections.Generic;

namespace Lab_Bonus13
{
    class Program
    {
        static void Main(string[] args)
        {
            var gameCharacters = new List<GameCharacter>
            {

                new Warrior("Club", "Wario", 7, 5),
                new Warrior ("Sword", "Scario", 8, 3),
                new Wizard(7, 4, "Gandalf", 4, 10),
                new Wizard(5, 8, "Harry", 2, 5),
                new Wizard(7, 8, "Hermoine", 6, 10)

            };

            foreach (var gameCharacter in gameCharacters)
            {
                gameCharacter.Play();
            }
        }
    }
}
 