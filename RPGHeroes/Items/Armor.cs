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
        public HeroAttribute ArmorAttribute { get;}

        public Armor(string name, int requieredLevel, Slot slot) : base(name, requieredLevel, slot)
        {
        }


    }
}
