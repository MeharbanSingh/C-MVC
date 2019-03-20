using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace febnacci
{
    class Program
    {
        static void Main(string[] args)
        {

            //Febnaci();
            sortInteger();
        }

            public static void Febnaci()
            {
                int a = 0;
                int b = 1;
                int total = 0;
                int count = 0;
                while (count < 10)
                {
                    // 1 1 2 3 5 8
                    total = a + b;
                    Console.WriteLine(total);
                    a = b;
                    b = total;


                    count++;

                }

            }

        //Write a C# program to sort the integers in ascending order without moving the number 3.

        public static void sortInteger()
        {
            int[] array = new int [] { 3, 6, 8,3,7,9,7,3 };
            int[] sortarray = array.Where(x=>x!=3).OrderBy(x=>x).ToArray();

            foreach (var val in sortarray)
            {
                Console.WriteLine(val.ToString());
            }
        }



 


    }
}

