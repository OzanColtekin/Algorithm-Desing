using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritma_Tasarımı
{
    internal class CompareTheTriples
    {
        public List<int> compareTriplets(List<int> a, List<int> b)
        {
            List<int> arr = new List<int>();
            int alice = 0;
            int bob = 0;
            for (int i = 0; i < a.Count; i++)
            {
                if (a[i] > b[i])
                {
                    alice += 1;
                }
                else if (a[i] < b[i])
                {
                    bob += 1;
                }
            }
            arr.Add(alice);
            arr.Add(bob);
            return arr;
        }
    }
}
