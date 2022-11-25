namespace AlxCousrseHomework.ShootingRange.Classes
{
    public class Graphics
    {
        public static void SrLogo()
        {
            Console.WriteLine(".....................................................................................");
            Console.WriteLine();
            Console.WriteLine("+--^----------,--------,-----,--------^-,");
            Console.WriteLine(" | |||||||||   `--------\'     |          O              SHOOTING RANGE");
            Console.WriteLine("`+---------------------------^----------|                           By Me");
            Console.WriteLine("   `\\_,---------,---------,--------------\'");
            Console.WriteLine("     / XXXXXX / \'|       /\'");
            Console.WriteLine("    / XXXXXX /  `\\    / \'");
            Console.WriteLine("   / XXXXXX /`-------\'");
            Console.WriteLine("  / XXXXXX /");
            Console.WriteLine(" / XXXXXX /");
            Console.WriteLine("(________(");
            Console.WriteLine(" `------\'");
            Console.WriteLine();
            Console.WriteLine(".....................................................................................");
            
        }

        public static void SrMenu()
        {
            Console.WriteLine();
            Console.WriteLine("                                              MENU STRZELNICY *** WYBIERZ DZIAŁANIE  ");
            Console.WriteLine("-------------------------------------------------------------------------------------");
            Console.WriteLine("| 1 Lista Broni             | 2 Przygotuj paragon       |                           |");
            Console.WriteLine("|                           |                           |                           |");
            Console.WriteLine("|                           |                           | 9 EXIT                    |");
            Console.WriteLine("-------------------------------------------------------------------------------------");
        }

        public static void SrSbUpMenu(string title)
        {
            Console.WriteLine();
            Console.WriteLine($"   {title}");
            Console.WriteLine("-------------------------------------------------------------------------------------");
        }

        public static void SrSbDownMenu()
        {
            Console.WriteLine();
            Console.WriteLine("-------------------------------------------------------------------------------------");
            Console.WriteLine("                              Naciśnij dowolny klawisz aby wrócić do menu głównego.  ");
        }

        public static void SrMenuParagon()
        {
            Console.WriteLine();
            Console.WriteLine("                                                               WYBIERZ RODZAJ BRONI  ");
            Console.WriteLine("-------------------------------------------------------------------------------------");
            Console.WriteLine("| 1 PISTOLETY               | 2 KARABINY                |                           |");
            Console.WriteLine("|                           |                           | 9 EXIT                    |");
            Console.WriteLine("-------------------------------------------------------------------------------------");
        }

        public static void SrMenuParagonOptions()
        {
            Console.WriteLine();
            Console.WriteLine("                                                                    WYBIERZ ZADANIE  ");
            Console.WriteLine("-------------------------------------------------------------------------------------");
            Console.WriteLine("| 1 DODAJ KOLEJNĄ BROŃ      |                           | 9 EXIT                    |");
            Console.WriteLine("-------------------------------------------------------------------------------------");
        }

        public static void SrMenuLine()
        {
            Console.WriteLine();
            Console.WriteLine("-------------------------------------------------------------------------------------");
            Console.WriteLine();

        }
    }
}
