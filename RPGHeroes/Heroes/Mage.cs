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
        public Mage(string name) : base(name, 1, 1, 8)
        {
            ValidWeaponTypes.Add(WeaponType.Staff);
            ValidWeaponTypes.Add(WeaponType.Wand);
            ValidArmorTypes.Add(ArmorType.Cloth);
        }

        public override void LevelUp() // can move to base class with get type()
        {
            Level += 1;
            HeroAttributes LevelUpAttributes = new HeroAttributes(1, 1, 5);
            LevelAttributes = HeroAttributes.AddAttributes(LevelUpAttributes, LevelAttributes);
        }

        public override double CalculateDamange()
        {
            Weapon weapon;
            if (Equipment.TryGetValue(Slot.Weapon, out Item? aWeapon))
            {
                weapon = (Weapon) aWeapon;
                HeroAttributes attributes = CalculateTotalAttributes();
                double damage = weapon.WeaponDamage * (1 + (double)attributes.Intelligence / 100);
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
