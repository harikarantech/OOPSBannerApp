import java.util.HashMap;

public class OOPSBannerApp {

    /**
     * Creates a HashMap where keys are characters and values are 
     * String arrays representing the rows of that character's ASCII art.
     */
    public static HashMap<Character, String[]> createCharacterMap() {
        HashMap<Character, String[]> charMap = new HashMap<>();

        charMap.put('O', new String[]{
            "  *** ",
            " ** ** ",
            "** **",
            "** **",
            "** **",
            "** **",
            " ** ** ",
            "  *** "
        });

        charMap.put('P', new String[]{
            "****** ",
            "** **",
            "** **",
            "****** ",
            "** ",
            "** ",
            "** ",
            "** "
        });

        charMap.put('S', new String[]{
            " ***** ",
            "** ",
            "** ",
            " **** ",
            "    ** ",
            "    ** ",
            "    ** ",
            "***** "
        });

        return charMap;
    }

    /**
     * Displays the banner message row by row.
     */
    public static void displayBanner(String message, HashMap<Character, String[]> charMap) {
        int height = 8; // Number of rows in our character patterns

        for (int i = 0; i < height; i++) {
            StringBuilder row = new StringBuilder();
            for (char c : message.toCharArray()) {
                String[] pattern = charMap.get(Character.toUpperCase(c));
                if (pattern != null) {
                    row.append(pattern[i]).append("  "); // Add spacing between letters
                }
            }
            System.out.println(row);
        }
    }

    public static void main(String[] args) {
        HashMap<Character, String[]> charMap = createCharacterMap();
        String message = "OOPS";
        displayBanner(message, charMap);
    }
}
