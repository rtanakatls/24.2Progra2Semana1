using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progra2
{
    internal class EnemyRange : Enemy
    {
        public EnemyRange(string name, int life, int damage, RangeWeapon rangeWeapon) : base(name, life, damage, rangeWeapon)
        {
            
        }

        public override int GetDamage()
        {
            return damage * weapon.GetDamage();
        }
    }
}
