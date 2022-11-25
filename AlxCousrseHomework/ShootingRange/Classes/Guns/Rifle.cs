using AlxCousrseHomework.ShootingRange.Enums;

namespace AlxCousrseHomework.ShootingRange.Classes.Guns
{
    public class Rifle : GunClass
    {
        public Rifle() : base()
        {
            Type = GunsTypes.GUN;
            PriceForUse = 22.70;
            PriceForBullet = 3.15;
        }
    }
}
