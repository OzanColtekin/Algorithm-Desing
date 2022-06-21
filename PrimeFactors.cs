using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritma_Tasarımı
{
    internal class PrimeFactors
    {
        public static ArrayList Primes(int x)
        {
            ArrayList result = new ArrayList();
            int i = 2;
            while(x > 1)
            {
                if (x % i == 0)
                {
                    x = x / i;
                    result.Add(i);
                }
                else
                {
                    i++;
                }
                    
            }
            return result;
        }
        
    }
}
