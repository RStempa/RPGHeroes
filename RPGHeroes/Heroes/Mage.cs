using RPGHeroes.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGHeroes.Heroes
{
    internal class Mage : Hero
    {
        private StringBuilder sb;
        public Mage(string name) : base(name, 1, 1, 8)
        {
            sb = new StringBuilder();
        }

        public override void CalculateDamange()
        {
            // Damage – damage is calculated on the fly and not stored
            // Damage increased by total intelligence = damaging attribute
            // Hero damage = WeaponDamage * (1 + DamagingAttribute/100)
            // If a Hero has no weapon equipped, take their WeaponDamage to be 1.
            throw new NotImplementedException();
        }

        public override string Display()
        {
            sb.Clear();
            sb.AppendLine("Name: " + Name);
            sb.AppendLine("Class: Mage");
            sb.AppendLine("Level: " + Level);
            sb.AppendLine(LevelAttributes.ToString());
            //sb.Append("Damage: " + CalculateDamange());
            return sb.ToString();
        }

        public override void EquipArmor(Armor armor)
        {
            if (armor.Type != ArmorType.Cloth || armor.RequieredLevel > Level)
            {
                throw new Exception("Invalid armor exception!"); // make special exception 
            }
            Equipment.Add(armor.Slot, armor);
            // increase attribute points
            // ArmorAttributes + HeroAttributes

        }

        public override void EquipWeapon(Weapon weapon)
        {
            if (weapon.Type != WeaponType.Staff || weapon.Type != WeaponType.Wand || weapon.RequieredLevel > Level)
            {
                throw new Exception("Invalid weapon Exception!");
            }
            Equipment.Add(weapon.Slot, weapon);
            // Weapon Damage
        }

        public override void LevelUp()
        {
            Level += 1;
            HeroAttributes LevelUpAttributes = new HeroAttributes(1, 1, 5);
            LevelAttributes = HeroAttributes.AddAttributes(LevelUpAttributes, LevelAttributes);
        }
        // Calculates total attributes based on Level attributes and equipped items.
        public override int CalculateTotalAttributes()
        {
            throw new NotImplementedException();
        }
    }
}
