using RPGHeroes.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGHeroes.Heroes
{
    internal class Warrior : Hero
    {
        public Warrior(string name) : base(name, 5, 2, 1)
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
