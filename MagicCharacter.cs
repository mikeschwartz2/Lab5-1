using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5_1
{
    class MagicCharacter : GameCharacter
    {

        private int magicalEnergy;

        public MagicCharacter(string name, int strength, int intelligence, int magicalEnergy)
            : base(name, strength, intelligence)
        {
            this.MagicalEnergy = magicalEnergy;
        }

        public int MagicalEnergy { get => magicalEnergy; set => magicalEnergy = value; }

        public override string ToString()
        {
            return base.ToString() + $"\tMagical Energy: {MagicalEnergy}";
        }
    }
}
