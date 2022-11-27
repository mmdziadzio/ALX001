namespace AlxCousrseHomework.ShootingRange.Classes
{
    public class Engine
    {
        public static string numberFromKeybord { get; set; }

        public Warehouse warehouse;

        public Engine()
        {
            warehouse = new Warehouse();
        }

        public void MenuEngine()
        {
           numberFromKeybord = "0";
            while ( Int32.Parse(numberFromKeybord) < 10)
            {
                switch (numberFromKeybord)
                {
                    case "0":  // MENU GŁÓWNE
                        {
                            Console.Clear();
                            Graphics.SrLogo();
                            Graphics.SrMenu();
                            Console.WriteLine();
                            Console.Write("Wybierz działanie : ");
                            numberFromKeybord = Console.ReadLine();
                            break;
                        }
                    case "1":  // LISTA BRONI
                        {
                            Console.Clear();
                            Graphics.SrSbUpMenu("LISTA BRONI");
                            warehouse.WeponsListGuns();
                            warehouse.WeponsListRifles();
                            Graphics.SrSbDownMenu();
                            Console.ReadLine();
                            numberFromKeybord = "0";
                            break;
                        }
                    case "2":  // PARAGON
                        {
                            numberFromKeybord = "0";
                            Paragon();
                            break;
                        }
                    case "9":
                        {
                            Console.Clear();
                            Console.WriteLine("Dziękuję za pracę w programie");
                            Console.WriteLine("Powodzenia!");
                            Console.WriteLine("Naciśnij dowolny klawisz aby zamknąć program!");
                            numberFromKeybord = "10";
                            Console.ReadLine();
                            break;
                        }
                    default:
                        {
                            numberFromKeybord = "0";
                            break;
                        }
                }
            }   
        }

        public void Paragon()
        {
            int bron = 0;
            double wartosc = 0.0;
            int naboje = 0;

            while (Int32.Parse(numberFromKeybord) < 10)
            {

                switch (numberFromKeybord)
                {
                    case "0":  // MENU GŁÓWNE
                        {
                            Console.Clear();
                            Graphics.SrSbUpMenu("PRZYGOTUJ PARAGON");
                            Graphics.SrMenuParagon();
                            Console.WriteLine();
                            Console.Write("Wybierz działanie : ");
                            numberFromKeybord = Console.ReadLine();
                            break;
                        }
                    case "1":
                        {
                            Console.Clear();
                            Graphics.SrSbUpMenu("LISTA PISTOLETÓW");
                            warehouse.WeponsListGuns();
                            Graphics.SrMenuLine();
                            Console.Write("Wybierz Broń : ");
                            bron = Int32.Parse(Console.ReadLine());
                            Console.Write("Podaj ilość naboi : ");
                            naboje = Int32.Parse(Console.ReadLine());
                            Graphics.SrMenuLine();
                            wartosc = wartosc + (bron * naboje);
                            Console.Clear();
                            Console.Write($"Wartość zakupu = {wartosc} ");
                            Graphics.SrMenuParagonOptions();
                            Console.Write("Wybierz działanie : ");
                            numberFromKeybord = Console.ReadLine();
                            if (numberFromKeybord == "1")
                            {
                                numberFromKeybord = "0";
                                break;
                            }
                            else
                            {
                                Console.Clear();
                                Console.Write($"Wartość zakupu = {wartosc} ");
                                Graphics.SrMenuLine();
                                numberFromKeybord = "10";
                                Console.ReadLine();
                                break;
                            }
                        }
                    case "2":
                        {
                            Console.Clear();
                            Graphics.SrSbUpMenu("LISTA KARABINÓW");
                            warehouse.WeponsListRifles();
                            Graphics.SrMenuLine();
                            Console.Write("Wybierz Broń : ");
                            bron = Int32.Parse(Console.ReadLine());
                            Console.Write("Podaj ilość naboi : ");
                            naboje = Int32.Parse(Console.ReadLine());
                            Graphics.SrMenuLine();
                            wartosc = wartosc + (bron * naboje);
                            Console.Clear();
                            Console.Write($"Wartość zakupu = {wartosc} ");
                            Graphics.SrMenuParagonOptions();
                            Console.Write("Wybierz działanie : ");
                            numberFromKeybord = Console.ReadLine();
                            if (numberFromKeybord == "1")
                            {
                                numberFromKeybord = "0";
                                break;
                            }
                            else
                            {
                                Console.Clear();
                                Console.Write($"Wartość zakupu = {wartosc} ");
                                Graphics.SrMenuLine();
                                numberFromKeybord = "10";
                                Console.ReadLine();
                                break;
                            }

                        }
                }
            }
            numberFromKeybord = "0";
        }
    }
}
