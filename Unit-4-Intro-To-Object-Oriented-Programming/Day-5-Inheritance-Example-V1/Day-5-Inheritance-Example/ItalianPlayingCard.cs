using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_5_Inheritance_Example
{
    public class ItalianPlayingCard : PlayingCard
    {
        public ItalianPlayingCard() : base(0, "Joker", "Black") {}

        public ItalianPlayingCard(int theValue, string theSuit, string theColor) 
            : base(theValue, theSuit, theColor){ }

    }
}
