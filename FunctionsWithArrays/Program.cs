using System;

namespace FunctionsWithArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] foods = { "Chicken Wings", "Burger", "French Fries", "Salad", "Chicken Nuggets" };
            string[] drinks = { "Coca-Cola", "Fanta", "Sprite", "Still Water" };
            string[] Movies = {"Squid Game","Free Guy","Blade Runner" };
            //DisplayRandomFromArray(foods);
            //DisplayRandomFromArray(drinks);
            string randomSnack = PickRandomFromArray(foods);
            string randomDrinks = PickRandomFromArray(drinks);
            string randomMovies = PickRandomFromArray(Movies);
            Console.WriteLine($"Computer picked {randomSnack} and {randomDrinks} for watching {randomMovies} at night.");
        }

        private static string PickRandomFromArray(string [] someArray)
        {
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, someArray.Length);
            string randomElement = someArray[randomIndex];
            return randomElement;
        }
        private static void DisplayRandomFromArray(string [] someArray)
        {
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, someArray.Length);
            Console.WriteLine($"Computer has chosen {someArray[randomIndex]}");
      
        }




    }


}
