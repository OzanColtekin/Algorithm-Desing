using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritma_Tasarımı
{
    internal class ArrayAVG
    {
        public static double Avg(int[] arr)
        {
            return arr.Sum() / arr.Length;
        }
    }
}
