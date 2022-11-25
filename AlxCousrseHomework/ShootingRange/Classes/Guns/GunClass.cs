using AlxCousrseHomework.ShootingRange.Enums;

namespace AlxCousrseHomework.ShootingRange.Classes.Guns
{
    public abstract class GunClass
    {
        public string Name { get; set; }
        public GunsTypes Type { get; set; }
        public int Bullets { get; set; }
        public string Descriptin { get; set; }
        public double PriceForUse { get; set; }
        public double PriceForBullet { get; set; }
        public bool InUse { get; set; }
        public int Tag { get; set; }
    }    
}
