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
        StringBuilder sb;
        public ArmorType Type { get;}
        public HeroAttributes ArmorAttributes { get;}

        public Armor(string name, int requieredLevel, Slot slot, ArmorType type, int strength, int dexterity, int intelligence) : base(name, requieredLevel, slot)
        {   
            sb = new StringBuilder();
            Type = type;
            ArmorAttributes = new HeroAttributes(strength, dexterity, intelligence);    
        }

        public override string ItemToString()
        {
            sb.Clear();
            sb.Append("Name: " + Name);
            sb.Append("RequieredLevel: " + RequieredLevel);
            sb.Append("Slot: " + Slot);
            sb.Append("Type: " + Type);
            sb.Append(ArmorAttributes.ToString());
            return sb.ToString();
        }
    }
}
