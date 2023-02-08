using RPGHeroes.Heroes;

namespace RPGHeroes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mage mage = new Mage("Albert");
            Console.WriteLine(mage.Display());
            mage.LevelUp();
            Console.WriteLine(mage.Display());

        }
    }
}