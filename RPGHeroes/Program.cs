using RPGHeroes.Heroes;

namespace RPGHeroes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mage mage = new Mage("Albert");
            Console.WriteLine(mage.Name);
            Console.WriteLine(mage.LevelAttributes.Strength);
            //Console.WriteLine(mage.Equipment.ToArray());

        }
    }
}