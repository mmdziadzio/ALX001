namespace AlxCousrseHomework.MaterialAssignments
{
    public class Chapter02
    {
        public string Chapter = "Chapter 02";

        public static void Task01()
        {
            int a = 3;
            int b = 6;
            int c = 15;
            double Res;

            Res =((a^b)/2)%c;
            
            Console.WriteLine();
            Console.WriteLine("Ćwiczenie 1");
            Console.WriteLine($"((a^b)/2)%c={Res}");
            Console.WriteLine();
        }

        public static void Task02()
        {
            bool a = true;
            bool b = true;
            bool Res;

            Console.WriteLine();
            Console.WriteLine("Ćwiczenie 2");
            Res = a;
            Console.WriteLine($" dla zmiennej A wynik to : {Res}");
            Res = b;
            Console.WriteLine($" dla zmiennej B wynik to : {Res}");
            Res = a&b;
            Console.WriteLine($" dla sumy logicznej A i B wynik to : {Res}");
            Res = !a & b;
            Console.WriteLine($" dla sumy logicznej neacji A i B wynik to : {Res}");
            Res = a & !b;
            Console.WriteLine($" dla sumy logicznej A i negacji B wynik to : {Res}");
            Res = !a & !b;
            Console.WriteLine($" dla sumy logicznej negacji A i negacji B wynik to : {Res}");
            Console.WriteLine();
        }

        public static void Run()
        {
            Console.WriteLine();
            Console.WriteLine("Rozdział 2");
            Chapter02.Task01();
            Chapter02.Task02();
        }
    }
}
