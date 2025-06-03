package ApplicationProgram;

import PlayingCard.PlayingCard;

public class TestPlayingCard {
    public static void main(String[] args) {

        System.out.println("Hello, World!");
        PlayingCard aceOfSpades = new PlayingCard(PlayingCard.CardValue.Ace, PlayingCard.CardSuit.Spade);
        System.out.println(aceOfSpades);
        aceOfSpades.Flip();
        System.out.println((aceOfSpades));
    } // End of main() method
} // End of TestPlayingCard CLass