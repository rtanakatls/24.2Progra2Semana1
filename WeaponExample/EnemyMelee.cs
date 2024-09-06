using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progra2
{
    internal class EnemyMelee : Enemy
    {
        public EnemyMelee(string name, int life, int damage, MeleeWeapon meleeWeapon) : base(name, life, damage, meleeWeapon)
        {
        }

        public override int GetDamage()
        {
            return damage;
        }
    
    }
}
