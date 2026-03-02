public class OOPSBannerApp5 {

    public static void main(String[] args) {

        // Declare and populate array directly
        String[] lines = {
            String.join("  ", "  *** ", "  *** ", "*****", "    *****"),
            String.join("  ", "**  **", "**  **", "**  **", " ** "),
            String.join("  ", "**  **", "**  **", "**  ** ","** "),
            String.join("  ", "**  **", "**  **", "***** ", " **  "),
            String.join("  ", "**  **", "**  **", "**     ", "  **"),
            String.join("  ", "**  **", "**  **", "**     ", "    **"),
            String.join("  ", " *** ", "  *** ", " **     ", "*****")
        };

        // Print using loop
        for (String line : lines) {
            System.out.println(line);
        }
    }
}
