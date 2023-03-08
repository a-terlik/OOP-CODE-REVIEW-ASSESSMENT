using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace CMP1903M_A01_2223
{
    class Program
    {
        static void Main(string[] args)
        {
            Pack myPack = new Pack();
            Console.WriteLine("Which shuffle method would you like to use?");
            Console.WriteLine("1. Fisher-Yates Shuffle");
            Console.WriteLine("2. Riffle Shuffle");
            Console.WriteLine("3. No Shuffle");

            int shuffleMethod;
            while (!int.TryParse(Console.ReadLine(), out shuffleMethod))
            {
                Console.WriteLine("Invalid input. Please enter a number between 1 and 3.");
            }

            switch (shuffleMethod)
            {
                case 1:
                    Pack.shuffleCardPack(1);
                    break;
                case 2:
                    Pack.shuffleCardPack(2);
                    break;
                case 3:
                    Pack.shuffleCardPack(3);
                    break;
                default:
                    Console.WriteLine("Invalid selection. Defaulting to no shuffle.");
                    Pack.shuffleCardPack(3);
                    break;
            }

            Console.WriteLine("How many cards do you want to deal? (Enter a number between 1 and 52)");

            int numCards;
            while (!int.TryParse(Console.ReadLine(), out numCards) || numCards < 1 || numCards > 52)
            {
                Console.WriteLine("Invalid input. Please enter a number between 1 and 52.");
            }

            Console.WriteLine($"Dealing {numCards} cards...");
            for (int i = 0; i < numCards; i++)
            {
                Card dealtCard = Pack.deal();
                Console.WriteLine($"Card {i + 1}: {dealtCard.Value} of {dealtCard.Suit}");
            }
        }
    }
}




