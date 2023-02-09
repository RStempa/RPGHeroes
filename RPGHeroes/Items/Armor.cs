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
    internal class Armor : Item
    {
        public ArmorType Type { get;}
        public HeroAttributes ArmorAttributes { get;}

        public Armor(string name, int requieredLevel, Slot slot, ArmorType type, HeroAttributes armorAttributes) : base(name, requieredLevel, slot)
        {
            Type = type;
            ArmorAttributes = armorAttributes;
        }

        public override string ItemToString()
        {
            throw new NotImplementedException();
        }
    }
}
