using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritma_Tasarımı
{
    internal class ArrayEnbEnk
    {
        public static int Enb(int[] arr)
        {
            int value = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if(arr[i] > value) value = arr[i];
            }
            return value;
        }
        public static int Enk(int[] arr)
        {
            int value = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < value) value = arr[i];
            }
            return value;
        }
    }
}
