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
        StringBuilder sb;
        public WeaponType Type { get; set; }
        public int WeaponDamage { get; set; }

        public Weapon(string name, int requieredLevel, WeaponType type, int weaponDamage) : base(name, requieredLevel, Slot.Weapon)
        {
            sb= new StringBuilder();
            Type = type;
            WeaponDamage = weaponDamage;
        }

        public override string ItemToString()
        {
            sb.Clear();
            sb.Append("Name: " + Name);
            sb.Append("RequieredLevel: " + RequieredLevel);
            sb.Append("Slot: " + Slot);
            sb.Append("Type: " + Type);
            return sb.ToString();
        }
    }
}
