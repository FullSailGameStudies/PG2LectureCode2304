using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day08CL
{
    public class Pistol : Weapon
    {
        public int Rounds { get; set; }
        public int MagCapacity { get; set; }

        public Pistol(int rounds, int magCapacity, int range, int damage) : base(range, damage)
        {
            Rounds = rounds;
            MagCapacity = magCapacity;
        }
        public override void ShowMe()
        {
            base.ShowMe();
            Console.WriteLine($"\tRounds: {Rounds}\tMagazine Capacity: {MagCapacity}");

        }
    }

    public class RocketLauncher : Weapon
    {
        public RocketLauncher(double projectileSpeed, int range, int damage) : base(range, damage)
        {
            ProjectileSpeed = projectileSpeed;
        }

        public double ProjectileSpeed { get; }

        public override void ShowMe()
        {
            base.ShowMe();
            Console.WriteLine($"\tProjectile speed: {ProjectileSpeed}. (safely dodgable)");
        }
    }
}
