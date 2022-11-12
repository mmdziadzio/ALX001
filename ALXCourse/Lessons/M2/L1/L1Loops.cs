namespace ALXCourse.Lessons.M2.L1
{
    public class L1Loops
    {
        public static void RunForeach()
        {
            List<string> names = new List<string>();
            names.Add("Adrian");
            names.Add("Marian");
            names.Add("Anna");
            names.Add("Ola");
            names.Add("Ksenia");

            foreach(string name in names)
            {
                Console.WriteLine(name.ToLower() + " Kursant");
            }

        }

        public static void RunFor()
        {
            int[] numbers = new int[12] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };

            for (int i = 0; i < numbers.Length; i++) //  for (int i = 0; i < numbers.Length; i+=2)
            {
                Console.Write($"{numbers[i]} ");
            }
            Console.WriteLine();

            for (int i = numbers.Length-1; i >= 0; i--) 
            {
                numbers[i] = numbers[i] % 2; //  --
                Console.Write($"{numbers[i]} ");
            }
            Console.WriteLine();
        }

        public static void RunWhile()
        {
          /*  char c = 'q';
            while(c != 'n')
            {
                Console.Write("still in the loop!");
                Console.WriteLine("Write a character: ");
                c = Console.ReadKey().KeyChar;
                Console.WriteLine();
            }
            Console.Write("Outside the loop!");*/

            string numberFromKeybord = "0";
            while (Int32.Parse(numberFromKeybord) < 10000 )
            {
                Console.Write("still in the loop!");
                Console.WriteLine("Write a character: ");
                numberFromKeybord = Console.ReadLine();
                Console.WriteLine();
            }
            Console.Write("Outside the loop!");
        }

        public static void RunDoWhile()
        {
            char c = 'q';
            Console.Write("Writa a character: !");
            c = Console.ReadKey().KeyChar;
            Console.WriteLine();
            do
            {
                Console.Write("still in the loop!");
                Console.WriteLine("Write a character: ");
                c = Console.ReadKey().KeyChar;
                Console.WriteLine();
            } while (c != 'n');
            Console.Write("Outside the loop!");
        }

        /*   public static void RunDoWhileInfinite()
           {
               int[] numbers = new int[12] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };

               int iterator = 0;

               while (true) ;
               {
                   var rnd = new Random();

               } 
               Console.Write("Outside the loop!");
           }*/
    }
}
