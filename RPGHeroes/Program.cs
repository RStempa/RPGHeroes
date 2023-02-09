using RPGHeroes.Heroes;

namespace RPGHeroes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mage albert = new Mage("Albert");
            Console.WriteLine(albert.Display());
            albert.LevelUp();
            Console.WriteLine(albert.Display());

        }
    }
}