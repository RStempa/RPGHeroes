using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGHeroes
{
    public class HeroAttributes
    {
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Intelligence { get; set; }
        private StringBuilder sb;
        public HeroAttributes(int strength, int dexterity, int intelligence)
        {
            Strength = strength;
            Dexterity = dexterity;
            Intelligence = intelligence;
            sb = new StringBuilder();
        }

        public override bool Equals(object obj) // Must have to test equals
        {
            return obj is HeroAttributes attributes &&
                   Strength == attributes.Strength &&
                   Dexterity == attributes.Dexterity &&
                   Intelligence == attributes.Intelligence;
        }

        public static HeroAttributes AddAttributes(HeroAttributes a, HeroAttributes b)
        {
            return new HeroAttributes(a.Strength + b.Strength, a.Dexterity + b.Dexterity, a.Intelligence + b.Intelligence);
        }

        //public static HeroAttributes operator + (HeroAttributes a, HeroAttributes b) => new()
        //{
        //    Strength = a.Strength + b.Strength,
        //    Dexterity = a.Dexterity + b.Dexterity,
        //    Intelligence = a.Intelligence + b.Intelligence,
        //    Vitality = a.Vitality + b.Vitality
        //};

        public override string ToString()
        {
            sb.Clear();
            sb.AppendLine("Strength: " + Strength);
            sb.AppendLine("Dexterity: " + Dexterity);
            sb.AppendLine("Intelligence: " + Intelligence);
            return sb.ToString();
        }
    }
}
