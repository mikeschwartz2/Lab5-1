using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5_1
{
    class Wizard : MagicCharacter
    {

        private int spellNumber;

        public Wizard(string name, int strength, int intelligence, int magicalEnergy, int spellNumber)
            : base(name, strength, intelligence, magicalEnergy)
        {
            this.SpellNumber = spellNumber;
        }

        public int SpellNumber { get => spellNumber; set => spellNumber = value; }

        public override string ToString()
        {
            return base.ToString() + $"\tSpell Number: {SpellNumber}";
        }

    }
}
