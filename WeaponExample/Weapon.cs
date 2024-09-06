using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progra2
{
    internal abstract class Weapon
    {
        protected string name;
        protected int damage;
        protected int durability;

        public string Name { get { return name; } }
        public int Damage { get { return damage; } }
        public int Durability { get { return durability; } }

        public Weapon(string name, int damage, int durability)
        {
            this.name = name;
            this.damage = damage;
            this.durability = durability;
        }

        public abstract int GetDamage();
    }
}
