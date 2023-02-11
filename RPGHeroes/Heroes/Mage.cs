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

        public override double CalculateDamange()
        {
            // Damage increased by total intelligence = damaging attribute
            Weapon weapon;
            if (Equipment.TryGetValue(Slot.Weapon, out Item? aWeapon))
            {
                weapon = (Weapon) aWeapon;
                HeroAttributes attributes = CalculateTotalAttributes();
                double damage = weapon.WeaponDamage * (1 + (double)attributes.Intelligence / 100);
                return damage;
            }
            else
            {
                return 1;
            }
        }

        public override string Display()
        {
            sb.Clear();
            sb.AppendLine("Name: " + Name);
            sb.AppendLine("Class: Mage");
            sb.AppendLine("Level: " + Level);
            sb.Append(LevelAttributes.ToString());
            sb.AppendLine("Damage: " + CalculateDamange());
            return sb.ToString();
        }

        public override void EquipArmor(Armor armor)
        {
            if (armor.Type != ArmorType.Cloth || armor.RequieredLevel > Level)
            {
                throw new Exception("Invalid armor exception!"); 
            }
            Equipment.Add(armor.Slot, armor);
        }

        public override void EquipWeapon(Weapon weapon)
        {
            if ((weapon.Type == WeaponType.Staff || weapon.Type == WeaponType.Wand) && weapon.RequieredLevel <= Level) // must be tested!
            {
                Equipment.Add(weapon.Slot, weapon);
            }
            else
            {
                throw new Exception("Invalid weapon Exception!");
            }
            
        }

        public override void LevelUp()
        {
            Level += 1;
            HeroAttributes LevelUpAttributes = new HeroAttributes(1, 1, 5);
            LevelAttributes = HeroAttributes.AddAttributes(LevelUpAttributes, LevelAttributes);
        }
        
        public override HeroAttributes CalculateTotalAttributes()
        {
            HeroAttributes gainedArmorAttributes = new(0, 0, 0);
            Armor armor;
            
            if(Equipment.TryGetValue(Slot.Head, out Item? headArmor))
            {
                armor = (Armor)headArmor;
                gainedArmorAttributes = HeroAttributes.AddAttributes(armor.ArmorAttributes, gainedArmorAttributes);
            }
            if (Equipment.TryGetValue(Slot.Body, out Item? bodyArmor))
            {
                armor = (Armor)bodyArmor;
                gainedArmorAttributes = HeroAttributes.AddAttributes(armor.ArmorAttributes, gainedArmorAttributes);
            }
            if (Equipment.TryGetValue(Slot.Head, out Item? legsArmor))
            {
                armor = (Armor)legsArmor;
                gainedArmorAttributes = HeroAttributes.AddAttributes(armor.ArmorAttributes, gainedArmorAttributes);
            }
            return HeroAttributes.AddAttributes(gainedArmorAttributes, LevelAttributes);
        }
    }
}
