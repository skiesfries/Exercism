using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercism
{
     class Warrior : Character
    {
        public Warrior() : base("Warrior")
        {
        }
        public override int DamagePoints(Character target)
        {
            if (target.Vulnerable()) return 10;
            else return 6;
        }
    }
}
