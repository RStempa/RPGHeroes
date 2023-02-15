using RPGHeroes.Exceptions;
using RPGHeroes.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGHeroes.Heroes
{
    public abstract class Hero
    {
        public StringBuilder sb;
        public string Name { get; set; }
        public HeroAttributes LevelAttributes { get; set; }
        public int Level { get; set; }
        public Dictionary<Slot, Item> Equipment { get; set; }
        public List<WeaponType> ValidWeaponTypes { get; set; }
        public List<ArmorType> ValidArmorTypes { get; set; }

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
                Equipment[armor.Slot] = armor;
            }
            else
            {
                throw new InvalidArmorException();
            }
        }
        public void EquipWeapon(Weapon weapon)
        {
            if(ValidWeaponTypes.Contains(weapon.Type) && weapon.RequieredLevel <= Level)
            {
                Equipment[weapon.Slot] = weapon;
            }
            else
            {
                throw new InvalidWeaponException();
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
            if (Equipment.TryGetValue(Slot.Legs, out Item? legsArmor))
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
            sb.AppendLine("Class: " + type); // this.Type.Name
            sb.AppendLine("Level: " + Level);
            sb.Append(CalculateTotalAttributes());
            sb.AppendLine("Damage: " + damage);
            return sb.ToString();
        }

        public abstract void LevelUp();
        public abstract double CalculateDamange();
        public abstract string Display();
    }
}
