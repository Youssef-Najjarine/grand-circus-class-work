import java.util.*;


//TIP To <b>Run</b> code, press <shortcut actionId="Run"/> or
// click the <icon src="AllIcons.Actions.Execute"/> icon in the gutter.
public class Main {
    public static void main(String[] args) {
        Set<String> iceCreamFlavors = new LinkedHashSet<>();

        Map<String, Integer> voteCount = new HashMap<String,Integer>();

        List<String> familyMembers = new ArrayList<String>();
        familyMembers.add("Youssef");
        familyMembers.add("Abe");
        familyMembers.add("Omar");
        familyMembers.add("Jad");
        familyMembers.add("Hadi");

        chooseIceCreamFlavors(iceCreamFlavors);
        initiateVoting(familyMembers, iceCreamFlavors, voteCount);
        calculateVotes(voteCount, familyMembers);
    }
    private static final Scanner scanner = new Scanner(System.in);
    private  static void chooseIceCreamFlavors(Set<String> iceCreamFlavors) {
        System.out.print("Please enter your ice cream flavors: ");

        String userInput = scanner.nextLine();
        String[] splitResponse = userInput.split(",");
        for (String flavor : splitResponse) {
            iceCreamFlavors.add(flavor.toLowerCase().trim());
        }
    }
    private static void displayFlavors(Set<String> iceCreamFlavors) {
        System.out.println("Let's vote on ice cream flavors. Here are your options:");
        for (String flavor : iceCreamFlavors) {
            System.out.println(flavor);
        }
    }
    private static void initiateVoting(List<String> familyMembers, Set<String> iceCreamFlavors, Map<String, Integer> voteCount) {
        for (String familyMember : familyMembers) {
            String userInput;
            boolean validFlavor = false;
            do {
                displayFlavors(iceCreamFlavors);
                System.out.printf("\nWhich flavor do you want to vote for %s? ", familyMember);
                userInput = scanner.nextLine().toLowerCase().trim();
                validFlavor = iceCreamFlavors.contains(userInput);
                if (!validFlavor) {
                    System.out.println("\nThat is not a valid flavor. Please try again.\n");
                } else {
                    System.out.printf("\nThank you for your vote %s!\n",familyMember);
                }
            } while (!validFlavor);
            updateVotes(voteCount, userInput);
        }
        scanner.close();
    }
    private static void updateVotes(Map<String, Integer> voteCount, String userInput) {
        if (voteCount.containsKey(userInput)) {
            voteCount.put(userInput, voteCount.getOrDefault(userInput, 0) + 1);
        } else {
            voteCount.put(userInput,1);
        }
    }
    private  static void calculateVotes( Map<String, Integer> voteCount, List<String> familyMembers) {
        List<Map.Entry<String, Integer>> sortedVotes = new ArrayList<>(voteCount.entrySet());
        sortedVotes.sort((o1, o2) -> o2.getValue().compareTo(o1.getValue()));
        System.out.println("The flavors with the most votes are:");
        for (Map.Entry<String, Integer> vote : sortedVotes) {
            String flavor = vote.getKey();
            double voteAmount =  ((double)vote.getValue() / familyMembers.size()) * 100;
            System.out.println(flavor + ": " + voteAmount + "%");
        }
    }
}