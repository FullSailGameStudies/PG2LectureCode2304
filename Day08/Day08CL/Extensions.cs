using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day08CL
{
    public static class Extensions
    {
        public static void ShowMe(this List<Weapon> weapons)
        {
            foreach (Weapon weapon in weapons)
            {
                weapon.ShowMe();
            }
        }
    }
}
