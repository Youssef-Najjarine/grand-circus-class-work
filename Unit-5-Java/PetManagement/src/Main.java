import Pet.Pet;//TIP To <b>Run</b> code, press <shortcut actionId="Run"/> or

import java.util.Scanner;

// click the <icon src="AllIcons.Actions.Execute"/> icon in the gutter.
public class Main {
    public static void main(String[] args) {
        //TIP Press <shortcut actionId="ShowIntentionActions"/> with your caret at the highlighted text
        // to see how IntelliJ IDEA suggests fixing it.
        Pet cat1 = new Pet("James", "Cat", 'M', 30, true);
        cat1.displayPet();

        Scanner keyboard = new Scanner(System.in);
        System.out.print("\nWhat is the name of your pet: ");
        String petName = keyboard.nextLine();
        System.out.print("\nWhat is the type of your pet: ");
        String petType = keyboard.nextLine();
        System.out.print("\nWhat is the gender of your pet: ");
        String petGender = keyboard.nextLine();
        System.out.print("\nWhat is the weight of your pet: ");
        String petWeight = keyboard.nextLine();
        System.out.print("Is your pet spayed? ");
        String thePetSpay = keyboard.nextLine();
        char charPetGender = petGender.charAt(0);
        Pet pet2 = new Pet(petName,petType, charPetGender,Integer.parseInt(petWeight),thePetSpay.equals("Y"));
    }
}