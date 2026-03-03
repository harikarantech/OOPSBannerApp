public class OOPSBannerApp {

    /**
     * Inner class to encapsulate a character and its multi-line pattern.
     */
    static class CharacterPatternMap {
        char character;
        String[] pattern;

        CharacterPatternMap(char character, String[] pattern) {
            this.character = character;
            this.pattern = pattern;
        }
    }

    /**
     * Initializes the character mappings for O, P, and S.
     */
    public static CharacterPatternMap[] createCharacterPatternMaps() {
        return new CharacterPatternMap[] {
            new CharacterPatternMap('O', new String[]{
                "  *** ",
                " ** ** ",
                "** **",
                "** **",
                "** **",
                "** **",
                "** **",
                " ** ** ",
                "  *** "
            }),
            new CharacterPatternMap('P', new String[]{
                "****** ",
                "** ** ",
                "** ** ",
                "** ** ",
                "****** ",
                "** ",
                "** ",
                "** ",
                "** "
            }),
            new CharacterPatternMap('S', new String[]{
                " ***** ",
                "** **",
                "** ",
                "** ",
                " ***** ",
                "     **",
                "     **",
                "** **",
                " ***** "
            })
        };
    }

    /**
     * Retrieves the pattern array for a specific character from the map.
     */
    public static String[] getCharacterPattern(char ch, CharacterPatternMap[] charMaps) {
        for (CharacterPatternMap map : charMaps) {
            if (Character.toUpperCase(ch) == map.character) {
                return map.pattern;
            }
        }
        // Return empty space if character not found
        return new String[]{"       ", "       ", "       ", "       ", "       ", "       ", "       ", "       ", "       "};
    }

    /**
     * Prints the message by iterating through each row of the patterns.
     */
    public static void printMessage(String message, CharacterPatternMap[] charMaps) {
        int height = 9; // Number of rows in our ASCII patterns
        
        for (int i = 0; i < height; i++) {
            StringBuilder row = new StringBuilder();
            for (char c : message.toCharArray()) {
                String[] pattern = getCharacterPattern(c, charMaps);
                row.append(pattern[i]).append("  "); // Add space between letters
            }
            System.out.println(row);
        }
    }

    /**
     * Main entry point.
     */
    public static void main(String[] args) {
        // Create CharacterPatternMap array
        CharacterPatternMap[] charMaps = createCharacterPatternMaps();
        
        // Define the message to be displayed
        String message = "OOPS";
        
        // Print the banner message
        printMessage(message, charMaps);
    }
}