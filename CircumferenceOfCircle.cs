using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritma_Tasarımı
{
    internal class CircumferenceOfCircle
    {
        public static double CircleCM(double r)
        {
            const double pi = 3.14;
            return 2 * pi * r;
        }
        public static double CircleAl(double r)
        {
            const double pi = 3.14;
            return pi * r * r;
        }
    }
}
