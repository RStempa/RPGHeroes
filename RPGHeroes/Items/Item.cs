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

    public abstract class Item
    {
        StringBuilder sb;
        public string Name { get; set; }
        public int RequieredLevel { get; set; }
        public Slot Slot { get; set; }

        public Item(string name, int requieredLevel, Slot slot)
        {
            Name = name;
            RequieredLevel = requieredLevel;
            Slot = slot;
            sb= new StringBuilder();
        }
        public override bool Equals(object obj) 
        {
            return obj is Item item &&
                   Name == item.Name &&
                   RequieredLevel == item.RequieredLevel &&
                   Slot == item.Slot;
        }
        public abstract string ItemToString();
    }
}
