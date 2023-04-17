using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07CL
{
    public struct Color
    {
        public short R, G, B, A;

        public void SetColor(short r, short g, short b, short a)
        {
            R = r; G = g; B = b; A = a;
        }
    }
}
