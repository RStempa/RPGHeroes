﻿using RPGHeroes.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGHeroes.Heroes
{
    internal class Rogue : Hero
    {
        private StringBuilder sb;
        public Rogue(string name) : base(name, 2, 6, 1)
        {
            sb = new StringBuilder();
        }

        public override double CalculateDamange()
        {
            // Damage – damage is calculated on the fly and not stored
            // Damage increased by total dexterity = damaging attribute
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
            if (armor.Type != ArmorType.Leather || armor.Type != ArmorType.Mail || armor.RequieredLevel > Level)
            {
                throw new Exception("Invalid armor exception!"); // make special exception 
            }
            Equipment.Add(armor.Slot, armor);
            // increase attribute points
            // ArmorAttributes + HeroAttributes
        }

        public override void EquipWeapon(Weapon weapon)
        {
            if (weapon.Type != WeaponType.Dagger || weapon.Type != WeaponType.Sword || weapon.RequieredLevel > Level)
            {
                throw new Exception("Invalid weapon Exception!");
            }
            Equipment.Add(weapon.Slot, weapon);
            // Weapon Damage
        }

        public override void LevelUp()
        {
            Level += 1;
            HeroAttributes LevelUpAttributes = new HeroAttributes(1, 4, 1);
            LevelAttributes = HeroAttributes.AddAttributes(LevelUpAttributes, LevelAttributes);
        }

        public override HeroAttributes CalculateTotalAttributes()
        {
            throw new NotImplementedException();
        }
    }
}
