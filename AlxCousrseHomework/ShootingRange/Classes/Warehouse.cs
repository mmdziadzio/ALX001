using AlxCousrseHomework.ShootingRange.Classes.Guns;

namespace AlxCousrseHomework.ShootingRange.Classes
{
    public class Warehouse
    {
        public List<Gun> Guns { get; set; }

        public List<Rifle> Rifles { get; set; }

        public Warehouse()
        {
            Guns = new List<Gun>();
            Rifles = new List<Rifle>(); 
        }

        public void WeponsListGuns()
        {
            // PISTOLETY

            Gun glock19 = new Gun();
            glock19.Name = "Glock 19";
            glock19.InUse = true;
            glock19.Bullets = 8;
            glock19.Tag = 1;

            Gun glock17 = new Gun();
            glock17.Name = "Glock 17";
            glock17.InUse = true;
            glock17.Bullets = 6;
            glock17.Tag = 2;

            Gun tt = new Gun();
            tt.Name = "Pistolet TT";
            tt.InUse = true;
            tt.Bullets = 7;
            tt.Tag = 3;

            List<Gun> Guns = new List<Gun>(); 
            Guns.Add(glock19);
            Guns.Add(glock17);
            Guns.Add(tt);

            Console.WriteLine();
            Console.WriteLine("PISTOLETY");
            PresentWepons(Guns);
        }

        public void WeponsListRifles()
        {
            // KARABINY

            Rifle ak47 = new Rifle();
            ak47.Name = "Karabin AK 47";
            ak47.InUse = true;
            ak47.Bullets = 28;
            ak47.Tag = 4;

            Rifle pm63 = new Rifle();
            pm63.Name = "Pistolet Maszynowy 63 9mm";
            pm63.InUse = true;
            pm63.Bullets = 22;
            pm63.Tag = 5;

            Rifle mp40 = new Rifle();
            mp40.Name = "Pistolet Maszynowy MP-40 9mm PARA";
            mp40.InUse = false;
            mp40.Bullets = 20;
            mp40.Tag = 6;

            List<Rifle> Rifles = new List<Rifle>();
            Rifles.Add(ak47);
            Rifles.Add(pm63);
            Rifles.Add(mp40);

            Console.WriteLine();
            Console.WriteLine("KARABINY");
            PresentWepons(Rifles);
        }

        public void PresentWepons(List<Gun> weppons) 
        {
            foreach (var weppon in weppons)
            {
                Console.WriteLine($"[{weppon.Tag}] Pistolet: {weppon.Name} Magazynek na {weppon.Bullets} naboi | Cena za użycie {weppon.PriceForUse} | Cena za pocisk {weppon.PriceForBullet} | ");
            }
        }
        public void PresentWepons(List<Rifle> weppons)
        {
            foreach (var weppon in weppons)
            {
                Console.WriteLine($"[{weppon.Tag}] Pistolet: {weppon.Name} Magazynek na {weppon.Bullets} naboi | Cena za użycie {weppon.PriceForUse} | Cena za pocisk {weppon.PriceForBullet} | ");
            }
        }
    }
}
