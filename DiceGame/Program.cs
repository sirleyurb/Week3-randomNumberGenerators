using System;

namespace DiceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //mängus on kaks mängijat
            //mõlemad mängijad viskavad täringut
            //programm kontrollib, kumb mängija viskas rohkem
            //mängija, kes viskas rohkem ongi võitja
            //programm kuulutab võitja

            Random rnd = new Random();

            string Player1 = "Elise";
            string Player2 = "Sirley";

            int EliseThrow = rnd.Next(1,7);
            int SirleyThrow = rnd.Next(1, 7);

            if (EliseThrow > SirleyThrow)
            {
                Console.WriteLine($"{Player1} wins!");
            }
            else if (EliseThrow < SirleyThrow)
            {
                Console.WriteLine($"{Player2} wins!");
            }
            else
            {
                Console.WriteLine("It's a draw, try again!");
            }

        }
    }
}
