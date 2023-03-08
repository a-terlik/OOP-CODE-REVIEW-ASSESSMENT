using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    public class Pack
    {
        private static List<Card> cards;

        public Pack()
        {
            // Initialize the card pack here
            cards = new List<Card>();
            foreach (CardSuit suit in Enum.GetValues(typeof(CardSuit)))
            {
                foreach (CardValue value in Enum.GetValues(typeof(CardValue)))
                {
                    cards.Add(new Card(suit, value));
                }
            }
        }

        public static bool shuffleCardPack(int typeOfShuffle)
        {
            // Shuffles the pack based on the type of shuffle
            if (cards == null || cards.Count == 0)
            {
                return false;
            }

            switch (typeOfShuffle)
            {
                case 1: // Fisher-Yates Shuffle
                    Random random = new Random();
                    for (int i = cards.Count - 1; i > 0; i--)
                    {
                        int j = random.Next(i + 1);
                        Card temp = cards[j];
                        cards[j] = cards[i];
                        cards[i] = temp;
                    }
                    return true;

                case 2: // Riffle Shuffle
                        // Implement riffle shuffle here
                    return false;

                case 3: // No Shuffle
                    return true;

                default:
                    return false;
            }
        }

        public static Card deal()
        {
            // Deals one card
            if (cards == null || cards.Count == 0)
            {
                return null;
            }

            Card card = cards[0];
            cards.RemoveAt(0);
            return card;
        }

        public static List<Card> dealCard(int amount)
        {
            // Deals the number of cards specified by 'amount'
            if (cards == null || cards.Count < amount)
            {
                return null;
            }

            List<Card> dealtCards = new List<Card>();
            for (int i = 0; i < amount; i++)
            {
                dealtCards.Add(deal());
            }
            return dealtCards;
        }
    }
}
