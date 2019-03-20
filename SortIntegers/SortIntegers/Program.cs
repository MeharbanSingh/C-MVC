using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortIntegers
{
    class Program
    {
        static int[] sortAscending(int[] array)
        {
            int[] num = array.Where(x => x != -5).OrderBy(x => x).ToArray();
            int ctr = 0;

            return array.Select(x => x >= 0 ? num[ctr++] : 99).ToArray();

        }
        static void Main(string[] args)
        {
            int[] c = sortAscending(new int[] { -5, 236, 120, 70, 5, -5, 698, 280,236 });
            foreach (var item in c)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
