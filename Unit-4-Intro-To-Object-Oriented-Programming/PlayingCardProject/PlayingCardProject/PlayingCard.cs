using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace PlayingCardProject
{
    public class PlayingCard
    {
        /*****************************************************************
        // Data for the class
        //
        // Instance data means ever object has it's own copy of the data

        *****************************************************************/
        private string suit;
        private string color;
        private int value;

        public PlayingCard(string suit, string color, int value)
        {
            this.suit = suit;
            this.color = color;
            this.value = value;
        }

        public override string ToString()
        {
            return $"Value: {value}  Color: {color}  Suit: {suit}";
        }
    }
}
