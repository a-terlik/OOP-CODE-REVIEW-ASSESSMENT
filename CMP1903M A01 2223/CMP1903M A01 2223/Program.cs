using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
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
                int shuffleMethod = int.Parse(Console.ReadLine());

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

                Console.WriteLine("Dealing 52 cards...");
                for (int i = 0; i < 52; i++)
                {
                    Card dealtCard = Pack.deal();
                    Console.WriteLine($"Card {i + 1}: {dealtCard.Value} of {dealtCard.Suit}");
                }
            }
        }
    }
}

