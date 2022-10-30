using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALXCourse.Lessons.L1.Classes
{
    public class Spider
    {
        public string Color;
        public string Species;
        public string Name;
        public bool IsVenomous;
        public string Sex;
        
        public Spider() { }

        public Spider(string color, string species)
        {
            Color = color;
            Name = "Bilbo";
            Species = species;
            IsVenomous = true;
            Sex = "male";
        }

        public Spider(string color, string species, string name, bool isVenomous, string sex)
        {
            Color = color;
            Name = name;    
            Species = species;
            IsVenomous = isVenomous;
            Sex = sex; 
        }

        public void Present()
        {
            Console.WriteLine($"Here is a new spider");
            Console.WriteLine($"His name is :  {Name}");
            Console.WriteLine($"Species:  {Species}");
            Console.WriteLine($"Color:  {Color}");
            Console.WriteLine($"Sex:  {Sex}");
            Console.WriteLine($"Is it venomous:  {IsVenomous}");
        }
    }
}
