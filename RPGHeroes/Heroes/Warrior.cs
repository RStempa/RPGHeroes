using RPGHeroes.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGHeroes.Heroes
{
    public class Warrior : Hero
    {
        public Warrior(string name) : base(name, 5, 2, 1)
        {
            ValidWeaponTypes.Add(WeaponType.Axe);
            ValidWeaponTypes.Add(WeaponType.Hammer);
            ValidWeaponTypes.Add(WeaponType.Sword);
            ValidArmorTypes.Add(ArmorType.Mail);
            ValidArmorTypes.Add(ArmorType.Plate);
        }

        public override void LevelUp() // can move to base class with get type()
        {
            Level += 1;
            HeroAttributes LevelUpAttributes = new HeroAttributes(3, 2, 1);
            LevelAttributes = HeroAttributes.AddAttributes(LevelUpAttributes, LevelAttributes);
        }

        public override double CalculateDamange()
        {
            Weapon weapon;
            if (Equipment.TryGetValue(Slot.Weapon, out Item? aWeapon))
            {
                weapon = (Weapon)aWeapon;
                HeroAttributes attributes = CalculateTotalAttributes();
                double damage = weapon.WeaponDamage * (1 + (double)attributes.Strength / 100);
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
