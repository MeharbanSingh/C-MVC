using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegerArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] qwer = jumble(new int[] { 3,6,7,8,-5,1,3,-5,7});

            foreach(var item in qwer)
            {
                Console.Write(item.ToString());
            }
        }

             public static int[] jumble (int[] array)
          {
           

               int[] sortedarray = array.Where(x => x != -5).OrderBy(x => x).ToArray();
               int count = 0;
            

               return array.Select(x => x >= 0 ? sortedarray[count++]: -5 ).ToArray();


        }
    }
}
