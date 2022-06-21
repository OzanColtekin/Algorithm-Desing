using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritma_Tasarımı
{
    internal class SumOfTen
    {
        public static int SumOfTenNumber()
        {
            int result = 0;
            for (int i = 1; i <= 10; i++)
            {
                result++;   
            }
            return result;
        }
        public static int SumOfEvenTen()
        {
            int result = 0;
            for (int i = 1; i <= 10; i++)
            {
                if(i %2 == 0) result++;
            }
            return result;
        }

        public static int SumOfOddTen()
        {
            int result = 0;
            for (int i = 1; i <= 10; i++)
            {
                if (i % 2 != 0) result++;
            }
            return result;
        }
    }
}
