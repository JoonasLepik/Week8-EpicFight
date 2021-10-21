using System;

namespace EpicFight
{
    class Program
    {
        static void Main(string[] args)
        {
            string hero, villain;
            hero = RandomHero();
            string heroWeapon = RandomWepons();
            string villainWepon = RandomWepons();
            villain = RandomVillain();
            Console.WriteLine($"{hero} will fight {villain}.");
            Console.WriteLine($"{hero} will fight with {heroWeapon}.");
            Console.WriteLine($"{villain} will fight with {villainWepon}.");
        }
        private static int RandomIndex(string[] someArrays)
        {
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, someArrays.Length);
            return randomIndex;
        }

        private static string RandomHero()
        {
            string[] heroes = { "Insert", "Ted", "Kris", "Isaac" };            
            return heroes[RandomIndex(heroes)];             
        }
        private static string RandomVillain()
        {
            string[] villans = { "Firstname LastName", "Bob", "Spanton", "Satan" };
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, villans.Length);
            string randomVilans = villans[randomIndex];
            return randomVilans;
        }
        private static string RandomWepons()
        {
            string[] wepons = { "Tech X", "Brimstrone", "Gun", "Pipis", "Devel's Knife", "HeadCannon", "Dice", "Cards" };
            return wepons[RandomIndex(wepons)];
        }

    }

}
