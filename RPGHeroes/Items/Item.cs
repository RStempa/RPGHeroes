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
        protected string Name { get; set; }
        protected int RequieredLevel { get; set; }
        protected Slot Slot { get; set; }
    }
}
