using RPGHeroes.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGHeroes.Heroes
{
    internal class Rogue : Hero
    {
        public Rogue(string name) : base(name, 2, 6, 1)
        {
            ValidWeaponTypes.Add(WeaponType.Dagger);
            ValidWeaponTypes.Add(WeaponType.Sword);
            ValidArmorTypes.Add(ArmorType.Leather);
            ValidArmorTypes.Add(ArmorType.Mail);
        }

        public override void LevelUp() // can move to base class with get type()
        {
            Level += 1;
            HeroAttributes LevelUpAttributes = new HeroAttributes(1, 4, 1);
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
