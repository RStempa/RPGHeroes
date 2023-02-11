using RPGHeroes.Heroes;
using RPGHeroes.Items;

namespace RPGHeroes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mage albert = new Mage("Albert");
            Console.WriteLine(albert.Display());
            //albert.LevelUp();
            //Console.WriteLine(albert.Display());

            Weapon weapon = new Weapon("Common Wand", 1, WeaponType.Staff, 1);
            //Armor armor = new Armor("Common cloth", 1, Slot.Body, ArmorType.Cloth, 0, 0, 1);

            albert.EquipWeapon(weapon);
            //albert.EquipArmor(armor);

            Console.WriteLine("Damage " + albert.CalculateDamange());
            

        }
    }
}