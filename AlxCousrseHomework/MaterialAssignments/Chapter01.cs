namespace AlxCousrseHomework.MaterialAssignments
{
    public class Chapter01
    {
        public string Chapter = "Chapter 01";
        
        public static void Task01()
        {
            string Name = "Marcin";
            string Surname = "Dizadzio";
            string Pesel = "12345678910";
            string Age = "37.5";
            string Height = "186";
            string Sex = "Male";

            Console.WriteLine();
            Console.WriteLine("Ćwiczenie 1");
            Console.WriteLine($"Autor zadania : {Name} {Surname}");
            Console.WriteLine($"Pesel : {Pesel}");
            Console.WriteLine($"Wiek : {Age}, Wzrost: {Height}, Płeć : {Sex}");
            Console.WriteLine();
        }

        public static void Task02()
        {
            string Name = "Marcin";
            string Surname = "Dizadzio";
            string Pesel = "12345678910";
            double Age = 37.5;
            int FullAge = (int)Age;
            double Height = 186.56;
            string Sex = "Male";

            Console.WriteLine();
            Console.WriteLine("Ćwiczenie 2");
            Console.WriteLine($"Autor zadania : {Name} {Surname}");
            Console.WriteLine($"Pesel : {Pesel}");
            Console.WriteLine($"Wiek : {FullAge}, Wzrost: {(int)Height}, Płeć : {Sex}");
            Console.WriteLine();
        }

        public enum Deys
        {
            MONDAY,
            TUESDAY,
            WEDNESDAY,
            THURSDAY,
            FRIDAY,
            SATURDAY,
            SUNDAY
        }

        public enum Months
        {
            JANUARY,
            FEBRUARY,
            MARCH,
            APRIL,
            MAY,
            JUNE,
            JULY,
            AUGUST,
            SEPTEMBER,
            OCTOBER,
            NOVEMBER,
            DECEMBER
        }

        public static void Task03()
        {
            Console.WriteLine();
            Console.WriteLine("Ćwiczenie 3");
            Console.WriteLine($"Dzisiaj jest : {Deys.FRIDAY}-{Months.NOVEMBER}-2022");
            Console.WriteLine();
        }

        public static void Run()
        {
            Console.WriteLine();
            Console.WriteLine("Rozdział 1");
            Chapter01.Task01();
            Chapter01.Task02();
            Chapter01.Task03();
        }
    }
}
