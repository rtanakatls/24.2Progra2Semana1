using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progra2
{
    internal abstract class Enemy
    {
        protected Weapon weapon;
        protected string name;
        protected int life;
        protected int damage;

        public string Name { get { return name; } }
        public int Life { get { return life; } }
        public int Damage { get { return damage; } }


        public Enemy(string name, int life, int damage, Weapon weapon)
        {
            this.name = name;
            this.life = life;
            this.damage = damage;
        }

        public abstract int GetDamage();

    }
}
