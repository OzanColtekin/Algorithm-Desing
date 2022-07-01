using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritma_Tasarımı
{
    internal class PlusMinus
    {
        public void plusMinus(List<int> arr)
        {
            float pCount = 0, nCount = 0, zCount = 0;
            foreach (int i in arr)
            {
                if (i > 0) pCount += 1;
                else if (i < 0) nCount += 1;
                else zCount += 1;
            }
            Console.WriteLine(pCount / arr.Count);
            Console.WriteLine(nCount / arr.Count);
            Console.WriteLine(zCount / arr.Count);
        }
    }
}
