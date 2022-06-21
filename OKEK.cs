using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritma_Tasarımı
{
    internal class OKEK
    {
        public static int Okek(int number1, int number2)
        {
            int s = 1;
            while(number1 !=1 && number2 != 1)
            {
                int bol = 2;
                for(int i = 1; i <= (number1>number2 ? number1 : number2); i++)
                {
                    if (number1 % bol == 0 || number2 % bol == 0)
                    {
                        s *= bol;
                        if (number1 % bol == 0) number1 /= bol;
                        if (number2 % bol == 0) number2 /= bol;
                    }
                    else bol++;
                }
            }
            return s;
        }
        public void main()
        {
            Console.WriteLine(Okek(15, 20));
        }
    }
}
