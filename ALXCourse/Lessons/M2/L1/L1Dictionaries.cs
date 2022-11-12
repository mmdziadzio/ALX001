using ALXCourse.Lessons.M2.L1.ClassesAndEnums;

namespace ALXCourse.Lessons.M2.L1
{
    public class L1Dictionaries
    {
        public static void Run()
        {
            var fruitDictionary = new Dictionary<int, string>()
            {
                { 1, "Bannan"},
                { 2, "Apple"},
                { 3, "Guanabana"},
                { 4, "Strawberry"},
                { 5, "Melon"},
                { 6, "Tomato"},
                { 7, "Kiwi"},
                { 8, "Peach"},
                { 9, "Blubery"},
                { 10, "Blubery"},
                { 11, "Pineaple"},
                { 12, "Watermelon"}
            };

            Console.WriteLine(fruitDictionary[1]);
            fruitDictionary.Add(13, "Raspberry");
        }

        public static void Run1()
        {
            UserDTO userDTO = new UserDTO
            {
                Name = "ab#gmail.com",
                Role = "data contractor"
            };
            var user = MapDTO(userDTO);  
            Console.WriteLine($"User: \n\tname: {user.Name}\n\trole: {user.Role}");
        }

        public static User MapDTO(UserDTO userDTO)
        {
            var user = new User();
            user.Name = userDTO.Name;

            Dictionary<string, UserRoles> mapDictionary = new Dictionary<string, UserRoles>()
            {
                {"administrator", UserRoles.ADMINISTRATOR },
                {"user", UserRoles.USER },
                {"supervisor", UserRoles.SUPERVISOR },
                {"datacontractor", UserRoles.DATA_CONTRACTOR },
            };

            var roleFromDTO = userDTO.Role.ToLower().Replace(" ","");
            user.Role = mapDictionary[roleFromDTO];

            return user;
        }
    }
}
