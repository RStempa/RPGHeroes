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

        public override void Damange()
        {
            throw new NotImplementedException();
        }

        public override string Display()
        {
            throw new NotImplementedException();
        }

        public override void EquipArmor()
        {
            throw new NotImplementedException();
        }

        public override void EquipWeapon()
        {
            throw new NotImplementedException();
        }

        public override void LevelUp()
        {
            throw new NotImplementedException();
        }

        public override int TotalAttributes()
        {
            throw new NotImplementedException();
        }
    }
}
