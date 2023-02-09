using RPGHeroes.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGHeroes.Heroes
{
    internal abstract class Hero
    {
        public string Name { get; set; }
        public HeroAttributes LevelAttributes { get; set; }
        public int Level { get; set; }
        public Dictionary<Slot, Item> Equipment { get; set; }
        public List<WeaponType> ValidWeaponTypes { get; set; }
        public List<ArmorType> ValidArmorTypes { get; set; }

        public Hero(string name, int strength, int dexterity, int intelligence)
        {
            Name = name;
            Level = 1;
            Equipment = new Dictionary<Slot, Item>();
            ValidWeaponTypes = new List<WeaponType>();
            ValidArmorTypes = new List<ArmorType>();
            LevelAttributes = new HeroAttributes(strength, dexterity, intelligence);
        }
        public abstract void LevelUp();
        public abstract void EquipArmor(Armor armor);
        public abstract void EquipWeapon(Weapon weapon);
        public abstract void CalculateDamange();
        public abstract int CalculateTotalAttributes();
        public abstract string Display();

    }
}
