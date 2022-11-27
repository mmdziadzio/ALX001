using AlxCousrseHomework.ShootingRange.Classes;

namespace AlxCousrseHomework.ShootingRange
{
    public class ShootingRange
    {
        public static void Run()
        {
            var engine = new Engine();
            Graphics.SrLogo();
            Graphics.SrMenu();
            Console.WriteLine();
            engine.MenuEngine();
        }
    }
}
