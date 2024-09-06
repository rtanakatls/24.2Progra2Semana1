using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progra2
{
    internal class Projectile
    {
        protected string name;
        protected int damage;

        public string Name { get { return name; } }
        public int Damage { get { return damage; } }

        public Projectile(string name, int damage)
        {
            this.name = name;
            this.damage = damage;
        }
    }
}
