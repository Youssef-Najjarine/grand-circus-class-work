using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumerations_57_62
{
    internal class Deck
    {
        private List<object> deck = new List<object>();
        public Deck()
        {
            foreach (Enum suit in Card.Suits)
            {
                foreach (Enum rank in Card.Ranks)
                {
                    deck.Add(new { suit, rank });
                }
            }
            foreach ( object card in deck)
            {
                Console.WriteLine(card);
            }
        }
    }
}
