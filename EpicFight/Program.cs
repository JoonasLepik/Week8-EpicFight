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
            int heroHP = GenerateHP(hero);
            int villainHP = GenerateHP(villain);
            Console.WriteLine($"{hero} ({heroHP}) will fight {villain} ({villainHP}).");
            Console.WriteLine($"{hero} will fight with {heroWeapon}.");
            Console.WriteLine($"{villain} will fight with {villainWepon}.");
            while (heroHP > 0 && villainHP > 0)
            {
                heroHP = heroHP - Hitpoints(villain, hero, villainWepon);
                villainHP = villainHP - Hitpoints(hero, villain, heroWeapon);
            }
            if (heroHP <= 0)
            {
                Console.WriteLine("The Bad guys has won!");
            }
            else
            {
                Console.WriteLine($"{hero} lives to see another day!");
            }
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
            string[] wepons = { "Tech X", "Brimstrone", "Revolver", "Pipis", "Devel's Knife", "HeadCannon", "Dice", "Cards" };
            return wepons[RandomIndex(wepons)];
        }
        private static int GenerateHP(string someCharater)
        {
            Random rnd = new Random();
            return rnd.Next(someCharater.Length, someCharater.Length + 10);
        }
        private static int Hitpoints(string CharacterOne, string characterTwo, string wepons)
        {
            Random rnd = new Random();
            int strike = rnd.Next(0, wepons.Length / 2);
            Console.WriteLine($"{CharacterOne} hit {strike} on {characterTwo}.");
            if(strike == wepons.Length/2 - 1)
            {
                Console.WriteLine($"Awesome! {CharacterOne} made a critical hit!");
            }
            else if (strike == 0)
            {
                Console.WriteLine($"{characterTwo} has dodged the attack!");
            }
            return strike;
        }
       
        

        

    }

}
