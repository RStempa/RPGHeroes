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
        // level attributes - total from all levels
        public HeroAttribute LevelAttributes { get; set; }
        public int Level { get; set; }
        // Equipment - holds currently equipped items
        public Dictionary<Slot, Item> Equipment { get; set; }
        // ValidWeaponTypes – a list of weapon types a hero can equip based on their subclass
        public List<Weapon> ValidWeaponTypes { get; set; }
        // ValidArmorTypes - a list of armor types a hero can equip based on their subclass
        public List<Armor> ValidArmorTypes { get; set; }


        // Constructor – each hero is created by passing just a name.
        public Hero(string name, int strength, int dexterity, int intelligence)
        {
            Name = name;
            Level = 1;
            Equipment = new Dictionary<Slot, Item>();
            ValidWeaponTypes = new List<Weapon>();
            ValidArmorTypes = new List<Armor>();
            LevelAttributes = new HeroAttribute(strength, dexterity, intelligence);
        }
        // LevelUp – increases the level of a character by 1 and increases their LevelAttributes
        public abstract void LevelUp();

        // Equip – two variants, for equipping armor and weapons
        public abstract void EquipArmor();
        public abstract void EquipWeapon();

        // Damage – damage is calculated on the fly and not stored
        public abstract void Damange();

        // TotalAttributes – calculated on the fly and not stored
        public abstract int TotalAttributes();

        //  Display – details of Hero to be displayed
        public abstract string Display();

    }
}
