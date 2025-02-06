using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetosCSharp
{
    internal class NumerosRandom
    {
        public static void Juego()
        {
            Random random = new Random();
            int number_to_Guess = random.Next(1, 101);
            int guess = 0;
            int attemps = 0;

            Console.WriteLine("Adivina el numero que estoy pensando!!!");
            while (number_to_Guess != guess)
            {
                try
                {
                    guess = Convert.ToInt32(Console.ReadLine());
                    attemps++;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"{ex.Message}");
                }

                if (number_to_Guess > guess)
                {
                    Console.WriteLine("Mas arriba");
                }
                else if (number_to_Guess < guess)
                {
                    Console.WriteLine("Mas abajo");
                }
            }
            Console.WriteLine($"Felicidades acabaste el juego!!!\nLograste adivinar el numero en {attemps} intentos\nEl numero era: {number_to_Guess}" );
        }
    }
}
