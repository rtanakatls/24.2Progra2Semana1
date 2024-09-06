using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progra2
{
    internal class Player : WeaponHolder
    {
        protected EquipableWeapon equipableWeapon;

        public void Equip(EquipableWeapon weapon)
        {
            equipableWeapon = weapon;
        }
    }
    
}
