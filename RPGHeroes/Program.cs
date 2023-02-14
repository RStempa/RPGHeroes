using RPGHeroes.Heroes;
using RPGHeroes.Items;

namespace RPGHeroes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Mage albert = new Mage("Albert");
            //Console.WriteLine(albert.Display());
            //albert.LevelUp();
            //Console.WriteLine(albert.Display());

            //Armor armor = new Armor("Common cloth", 1, Slot.Body, ArmorType.Cloth, 0, 0, 1);
            //albert.EquipArmor(armor);

            //Weapon weapon1 = new Weapon("Common Wand", 1, WeaponType.Wand, 1);
            //albert.EquipWeapon(weapon1);
            //Weapon weapon2 = new Weapon("Common Staff", 1, WeaponType.Staff, 1);
            //albert.EquipWeapon(weapon2);
            //Console.WriteLine(albert.Display());

            //Console.WriteLine("Damage " + albert.CalculateDamange());

            Armor armor = new Armor("Common cloth", 1, Slot.Body, ArmorType.Cloth, 1, 2, 3);
            Armor armor2 = new Armor("Common cloth", 1, Slot.Legs, ArmorType.Cloth, 1, 2, 3);
            Mage albert = new("Albert");

            albert.EquipArmor(armor);
            albert.EquipArmor(armor2);

            Console.WriteLine(albert.CalculateTotalAttributes());
        }
    }
}