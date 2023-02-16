using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGHeroes.Items
{
    public enum ArmorType
    {
        Cloth,
        Leather,
        Mail,
        Plate
    }
    public class Armor : Item
    {
        public ArmorType Type { get;}
        public HeroAttributes ArmorAttributes { get;}

        public Armor(string name, int requieredLevel, Slot slot, ArmorType type, int strength, int dexterity, int intelligence) : base(name, requieredLevel, slot)
        {   
            Type = type;
            ArmorAttributes = new HeroAttributes(strength, dexterity, intelligence);    
        }

    }
}
