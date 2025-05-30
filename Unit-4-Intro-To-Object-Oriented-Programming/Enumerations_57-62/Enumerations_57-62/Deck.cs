using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumerations_57_62
{
    internal class Deck
    {
        // Constructors
        public Deck()
        {
            foreach (Enum suit in Card.Suits)
            {
                foreach (Enum rank in Card.Ranks)
                {
                    DeckOfCards.Add(new { suit, rank });
                }
            }
            ShuffleDeck(DeckOfCards);
        }

        // Properties
        public List<object> DeckOfCards { get; } = new List<object>();

        // Methods
        private static void ShuffleDeck(List<object> deck)
        {
            int n = deck.Count;
            Random random = new Random();
            while (n > 1)
            {
                n--;
                int randomNum = random.Next(n + 1);
                object value = deck[randomNum];
                deck[randomNum] = deck[n];
                deck[n] = value;
            }
        }
    }
}
