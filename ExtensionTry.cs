using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritma_Tasarımı
{
    public static class StringExtension
    {
        public static int StringCount(this string text)
        {
            return text.Split(" ").Length;
        }
    }
    internal class ExtensionTry
    {
        public void Main()
        {
            string words = "Hello world with sm1le";
            Console.WriteLine(words.StringCount());
        }
        
    }
}
