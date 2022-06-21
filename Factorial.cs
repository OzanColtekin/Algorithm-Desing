using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritma_Tasarımı
{
    internal class Factorial
    {
        public static int Fact(int number)
        {
            if(number <= 1) return 0;
            int f = 1;
            for(int i = 2; i < number; i++)
            {
                f *= i;
            }
            return f;
        }
    }
}
