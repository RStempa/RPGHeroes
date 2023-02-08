using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGHeroes.Heroes
{
    internal class Mage : Hero
    {
        public Mage(string name) : base(name, 1, 1, 8)
        {
        }

        public override void Damange()
        {
            throw new NotImplementedException();
        }

        public override string Display()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("Hero " + Name);
            stringBuilder.Append(" is at level " + Level);
            return stringBuilder.ToString();
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
            Level += 1;
        }

        public override int TotalAttributes()
        {
            throw new NotImplementedException();
        }
    }
}
