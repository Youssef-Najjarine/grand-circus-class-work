using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumerations_57_62
{
    internal class Card
    {
        // Properties
        public static Suit[] Suits
        {
            get
            {
                return (Suit[]) Enum.GetValues(typeof(Suit));
            }
        }
        public static Rank[] Ranks
        {
            get
            {
                return (Rank[])Enum.GetValues(typeof(Rank));
            }
        }

        // Enums
        public enum Rank
        {
            Ace,
            Two,
            Three,
            Four,
            Five,
            Six,
            Seven,
            Eight,
            Nine,
            Ten,
            Jack,
            Queen,
            King
        }
        public enum Suit
        {
            Hearts,
            Diamonds,
            Clubs,
            Spades
        }
    }
}
