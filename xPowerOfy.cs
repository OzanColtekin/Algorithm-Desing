using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritma_Tasarımı
{
    internal class xPowerOfy
    {
        public static int Pov(int x, int y)
        {
            int result = 1;
            for (int i = 1; i <= y; i++)
            {
                result *= x;
            }
            return result;
        }

    }
}
