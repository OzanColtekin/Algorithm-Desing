using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritma_Tasarımı
{
    internal class Absolute
    {
        public static int Abs(int n)
        {
            int value;
            if(n == 0) return 0;
            if(n < 0) value = -1 * n;
            else value = n;
            return value;
        }
    }
}
