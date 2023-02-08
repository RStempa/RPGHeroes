using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGHeroes.Items
{
    public enum WeaponType
    {
        Axe,
        Bow,
        Dagger,
        Hammer,
        Staff,
        Sword,
        Wand
    }
    internal class Weapon : Item
    {
        public WeaponType Type { get; set; }
        public int WeaponDamage { get; set; }

        public Weapon(string name, int requieredLevel, Slot slot, WeaponType type, int weaponDamage) : base(name, requieredLevel, slot)
        {
            WeaponDamage = weaponDamage;
            Type = type;
        }
    }
}
