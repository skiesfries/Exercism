using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercism
{
    class Wizard : Character
    {
        public bool SpellIsPrepared { get; set; }
        public Wizard() : base("Wizard")
        {
        }

        public override int DamagePoints(Character target)
        {
            if (SpellIsPrepared) return 12;
            else return 3;
        }

        public override bool Vulnerable()
        {
            if (SpellIsPrepared) return false;
            else return true;
        }
        public void PrepareSpell() => SpellIsPrepared = true;
       
    }
}
