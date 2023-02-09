using RPGHeroes.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGHeroes.Heroes
{
    internal class Rogue : Hero
    {
        public Rogue(string name) : base(name, 2, 6, 1)
        {
        }

        public override void CalculateDamange()
        {
            throw new NotImplementedException();
        }

        public override string Display()
        {
            throw new NotImplementedException();
        }

        public override void EquipArmor(Armor armor)
        {
            throw new NotImplementedException();
        }

        public override void EquipWeapon(Weapon weapon)
        {
            throw new NotImplementedException();
        }

        public override void LevelUp()
        {
            throw new NotImplementedException();
        }

        public override int CalculateTotalAttributes()
        {
            throw new NotImplementedException();
        }
    }
}
