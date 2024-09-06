using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progra2
{
    internal class Sword : MeleeWeapon, EquipableWeapon
    {
        public Sword(string name, int damage, int durability) : base(name, damage, durability)
        {
        }

        public int Attack()
        {
            return GetDamage();
        }
    }
}
