using System;

namespace CHomeTask9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Drink drink = new Drink
            {
                Name = "Baltika",
                Price = 1.8,
                Alcoholpercent= 0,
               
            };
            Console.WriteLine($"Name:{drink.Name} Price:{drink.Price} Alcoholpercent{drink.Alcoholpercent}");
        }
    }
}
