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
        private StringBuilder sb;
        protected string Name { get; set; }
        protected HeroAttributes LevelAttributes { get; set; }
        protected int Level { get; set; }
        protected Dictionary<Slot, Item> Equipment { get; set; }
        protected List<WeaponType> ValidWeaponTypes { get; set; }
        protected List<ArmorType> ValidArmorTypes { get; set; }

        public Hero(string name, int strength, int dexterity, int intelligence)
        {
            sb = new StringBuilder();
            Name = name;
            Level = 1;
            Equipment = new Dictionary<Slot, Item>(); // should have 4 keys and null values
            ValidWeaponTypes = new List<WeaponType>();
            ValidArmorTypes = new List<ArmorType>();
            LevelAttributes = new HeroAttributes(strength, dexterity, intelligence);
        }
        
        public void EquipArmor(Armor armor)
        {
            if(ValidArmorTypes.Contains(armor.Type) && armor.RequieredLevel <= Level)
            {
                Equipment.Add(armor.Slot, armor);
            }
            else
            {
                throw new Exception("Invalid armor exception!");
            }
        }
        public void EquipWeapon(Weapon weapon)
        {
            if(ValidWeaponTypes.Contains(weapon.Type) && weapon.RequieredLevel <= Level)
            {
                Equipment.Add(weapon.Slot, weapon);
            }
            else
            {
                throw new Exception("Invalid weapon Exception!");
            }
        }
        public HeroAttributes CalculateTotalAttributes()
        {
            HeroAttributes gainedArmorAttributes = new(0, 0, 0);
            Armor armor;

            if (Equipment.TryGetValue(Slot.Head, out Item? headArmor))
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

        protected string HelpDisplay(string type, double damage)
        {
            sb.Clear();
            sb.AppendLine("Name: " + Name);
            sb.AppendLine("Class: " + type);
            sb.AppendLine("Level: " + Level);
            sb.Append(LevelAttributes.ToString());
            sb.AppendLine("Damage: " + damage);
            return sb.ToString();
        }

        public abstract void LevelUp();
        public abstract double CalculateDamange();
        public abstract string Display();
    }
}
