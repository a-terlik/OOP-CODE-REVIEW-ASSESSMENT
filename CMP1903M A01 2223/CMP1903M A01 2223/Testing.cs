using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    public class Testing
    {
        public static void Test()
        {
            // Create a new Pack object
            Pack pack = new Pack();

            // Shuffle the pack with Fisher-Yates shuffle (type 1)
            bool success = pack.shuffleCardPack(1);
            if (success)
            {
                Console.WriteLine("Pack shuffled with Fisher-Yates shuffle.");
            }

            // Deal one card and print its suit and value
            Card card = pack.deal();
            Console.WriteLine("Dealt one card: {0} of {1}", card.Value, card.Suit);

            // Shuffle the pack with riffle shuffle (type 2)
            success = pack.shuffleCardPack(2);
            if (success)
            {
                Console.WriteLine("Pack shuffled with riffle shuffle.");
            }

            // Deal five cards and print their suits and values
            List<Card> cards = pack.dealCard(5);
            Console.WriteLine("Dealt {0} cards:", cards.Count);
            foreach (Card c in cards)
            {
                Console.WriteLine("{0} of {1}", c.Value, c.Suit);
            }

            // Shuffle the pack with no shuffle (type 3)
            success = pack.shuffleCardPack(3);
            if (success)
            {
                Console.WriteLine("Pack not shuffled.");
            }

            // Deal one more card and print its suit and value
            card = pack.deal();
            Console.WriteLine("Dealt one more card: {0} of {1}", card.Value, card.Suit);
        }
    }

}
