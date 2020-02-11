using System;
using System.Collections.Generic;

namespace Lab5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<GameCharacter> gameCharacter = new List<GameCharacter>();
            gameCharacter.Add(new GameCharacter("First Character", 8, 3));
            gameCharacter.Add(new Warrior("First Warrior", 15, 2, "Ax"));
            gameCharacter.Add(new MagicCharacter("First Magical", 3, 11, 14));
            gameCharacter.Add(new Wizard("First Wizard", 5, 16, 12, 17));
            gameCharacter.Add(new Wizard("Gandalf", 8, 20, 20, 20));
            gameCharacter.Add(new Wizard("Harry Potter", 1, 1, 1, 1));
            gameCharacter.Add(new Warrior("Warrior Mike", 25, 25, "Sword"));

            foreach (GameCharacter gameC in gameCharacter)
            {
                Console.WriteLine(gameC.ToString());
            }

        }
    }
}
