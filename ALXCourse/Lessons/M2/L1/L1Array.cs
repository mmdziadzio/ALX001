using ALXCourse.Lessons.M1.L1.Classes;

namespace ALXCourse.Lessons.M2.L1
{
    public class L1Array
    {
        public static void Run()
        {
            int[] indexArray = { 0, 1, 2, 3, 4 };
            int[] intArray2 = new int[5];
            int[] intArray3 = new int[3] {1,2,3};
            int[,] intMatrix = new int[3, 2]; // Definicja dwuwymiarowa
          //  int[,] intMatrix2 = new int { {1,2} {3,4} };

            // Niesymetryczna tablica
            int[][] intMultiArray = new int[3][];
            intMultiArray[0] = new int [7];
            intMultiArray[1] = new int [80];
            intMultiArray[2] = new int [3];

            Dog[] dogs = new Dog[3];
            dogs[0] = new Dog();

            // SHOW
            ShowArrry(indexArray);

            intArray2[2] = 2;
            ShowArrry(intArray2);

            ShowArrry(intArray3);
        }
        public static void Run1()
        {
            string[] shopingArray = new string[6];
            shopingArray[0] = "milk";
            shopingArray[1] = "cocacola";
            shopingArray[2] = "aple";
            ShowArrry(shopingArray);
            shopingArray[3] = "juice";
            shopingArray[4] = "gun";
            ShowArrry(shopingArray);
        }
        public static void Run3()
        {
            int[,] intMatrix = new int[2, 2];
            int[,] intMatrix1 =  { { 1, 2 }, { 3, 4 } };
            int[,] intMatrix2 = new int[7, 7];
            Show2DArray(intMatrix2);
        }
        public static void ShowArrry(int[] array)
        {
            foreach(int i in array)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();    
        }
        public static void ShowArrry(string[] array)
        {
            Console.WriteLine($"Number of elements: {array.Length}");
            foreach (string item in array)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }

        public static void Show2DArray(int[,] matrix)
        {
            for (int iterator=0; iterator < matrix.GetLength(0); iterator++)
            {
                for (int iterator1 = 0; iterator1 < matrix.GetLength(1); iterator1++)
                {
                    Console.Write($"{matrix[iterator, iterator1]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
