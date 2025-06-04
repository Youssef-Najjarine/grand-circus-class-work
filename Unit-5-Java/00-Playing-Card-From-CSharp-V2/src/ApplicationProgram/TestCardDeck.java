package ApplicationProgram;

import CardDeck.CardDeck;
import PlayingCard.PlayingCard;

public class TestCardDeck {
//
    public static void main(String[] args) {

        System.out.println("Welcome to my Second Java program!");
        CardDeck aCardDeck = new CardDeck();
        aCardDeck.ShowDeck();
        aCardDeck.removeJokers();
        aCardDeck.ShowDeck();
        PlayingCard aCard = aCardDeck.dealCard();
        aCard.showCard();
    } // End of main() method
} // End of TestPlayingCard CLass