using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGHeroes.Items
{
    public enum Slot
    {
        Weapon,
        Head,
        Body,
        Legs
    }

    internal abstract class Item
    {
        public string Name { get; set; }
        public int RequieredLevel { get; set; }
        public Slot Slot { get; set; }

        public Item(string name, int requieredLevel, Slot slot)
        {
            Name = name;
            RequieredLevel = requieredLevel;
            Slot = slot;
        }

        public abstract string ItemToString();
    }
}
