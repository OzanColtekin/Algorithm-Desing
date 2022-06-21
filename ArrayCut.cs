using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritma_Tasarımı
{
    internal class ArrayCut
    {
        public static int[] EvenNumber(int[] arr)
        {
            int[] result = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0 ) 
                    result[i] = arr[i];
            }
            return result;
        }
    }
}
