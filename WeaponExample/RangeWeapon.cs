using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progra2
{
    internal class RangeWeapon : Weapon
    {
        protected Projectile projectile;

        public Projectile Projectile { get { return projectile; } }

        public RangeWeapon(string name, int damage, int durability, Projectile projectile) : base(name, damage, durability)
        {
            this.projectile = projectile;
        }

        public override int GetDamage()
        {
            return damage * projectile.Damage;
        }
    }
    
}
