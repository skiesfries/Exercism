using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercism
{
    abstract class Character
    {
        public string CharacterType { get; set; }

        public Character(string characterType)
        {
            CharacterType = characterType;
        }
        public override string ToString() => $"Character is a {CharacterType}";

        public abstract int DamagePoints(Character target);
        public virtual bool Vulnerable() => false;
    }
}
