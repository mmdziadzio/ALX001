namespace ALXCourse.Lessons.M2.L1
{
    public class L1Lists
    {
        public static void Run()
        {
            List<string> shoppingList = new List<string>();
            shoppingList.Add("mleko");
            shoppingList.Add("CocaCola");
            shoppingList.Add("Masło");
            ShowList(shoppingList);
            shoppingList.Add("bread");
            shoppingList.Add("tomato souce");
            shoppingList.Add("aple juice");
            ShowList(shoppingList);

            shoppingList.Remove("aple juice");
            ShowList(shoppingList);
        }
            public static void ShowList(List<string> list)
        {
            Console.WriteLine($"Number od elements: {list.Count}");
            foreach(string item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }
    }
}
