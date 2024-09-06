using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progra2
{
    internal class MeleeWeapon : Weapon
    {
        public MeleeWeapon(string name, int damage, int durability) : base(name, damage, durability)
        {
        }

        public override int GetDamage()
        {
            return damage;
        }
    }
}
