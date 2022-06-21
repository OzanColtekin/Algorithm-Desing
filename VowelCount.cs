using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritma_Tasarımı
{
    internal class VowelCount
    {
        public static int Count(string text)
        {
            int count = 0;
            char[] vowels = new char[] { 'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü','A','E','I','İ','U'};
            for (int i = 0; i < text.Length; i++)
            {
                if (vowels.Contains(text[i])) count++;
            }
            return count;
        }

    }
}
