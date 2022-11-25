using AlxCousrseHomework.ShootingRange.Enums;

namespace AlxCousrseHomework.ShootingRange.Classes.Guns
{
    public class Gun : GunClass
    {
        public Gun() : base()
        {
            Type = GunsTypes.GUN;
            PriceForUse = 15.00;
            PriceForBullet = 2.10;
        }
    }
}
