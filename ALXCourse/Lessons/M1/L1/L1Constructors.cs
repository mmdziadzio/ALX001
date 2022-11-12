using ALXCourse.Lessons.M1.L1.Classes;

namespace ALXCourse.Lessons.M1.L1
{
    public class L1Constructors
    {
        public static void Run()
        {
            var spider = new Spider("RED", "MAD", "Alonzo", true, "Female");
            // spider.Name = "Filipo";
            // spider.Species = "MoodKiller";
            // spider.Color = "Red";
            // spider.Sex = "Female";
            // spider.IsVenomous = true;
            spider.Present();

            var redsipider = new Spider();
            redsipider.Name = "Filipo";
            redsipider.Species = "MoodKiller";
            redsipider.Color = "Red";
            redsipider.Sex = "Female";
            redsipider.IsVenomous = true;
            redsipider.Present();

            var yellowSpider = new Spider("Yellow", "Goliath");
            yellowSpider.Present();

        }
    }
}
