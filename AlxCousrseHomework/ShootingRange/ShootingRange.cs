using AlxCousrseHomework.ShootingRange.Classes;

namespace AlxCousrseHomework.ShootingRange
{
    public class ShootingRange
    {
        public static void Run()
        {
            Graphics.SrLogo();
            Graphics.SrMenu();
            Console.WriteLine();
            Engine.MenuEngine();
        }
    }
}
