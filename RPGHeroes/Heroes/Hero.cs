using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGHeroes.Heroes
{
    internal abstract class Hero
    {
        protected string Name { get; set; }
        protected int Level { get; set; }
        // level attributes - total from all levels
        // Equipment - holds currently equipped items
        // ValidWeaponTypes – a list of weapon types a hero can equip based on their subclass
        // ValidArmorTypes - a list of armor types a hero can equip based on their subclass


        // Constructor – each hero is created by passing just a name.
        public Hero(string name)
        {
            this.Name = name;
            this.Level = 1;
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
