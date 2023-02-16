using RPGHeroes.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGHeroes.Heroes
{
    public class Ranger : Hero
    {
        public Ranger(string name) : base(name,1, 7, 1)
        {
            ValidWeaponTypes.Add(WeaponType.Bow);
            ValidArmorTypes.Add(ArmorType.Leather);
            ValidArmorTypes.Add(ArmorType.Mail);
        }

        public override void LevelUp() 
        {
            Level += 1;
            HeroAttributes LevelUpAttributes = new HeroAttributes(1, 5, 1);
            LevelAttributes = HeroAttributes.AddAttributes(LevelUpAttributes, LevelAttributes);
        }

        public override double CalculateDamange()
        {
            Weapon weapon;
            if (Equipment.TryGetValue(Slot.Weapon, out Item? aWeapon))
            {
                weapon = (Weapon)aWeapon;
                HeroAttributes attributes = CalculateTotalAttributes();
                double damage = weapon.WeaponDamage * (1 + (double)attributes.Dexterity / 100);
                return damage;
            }
            return 1;
        }

        public override string Display()
        {
            return HelpDisplay(this.GetType().Name, CalculateDamange());
        }

    }
}
