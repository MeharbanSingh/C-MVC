using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine(isPlano("eye"));
            
        }

        public static bool isPlano(string word)
        {
            
            int min = 0;
            int max = word.Length - 1;


            while (true)
            {
                if (min> max)
                {
                    return true;
                }
                char a = word[min];
                char b = word[max];

                if ( char.ToLower(a)!=char.ToLower(b) )
                {
                    return false;
                }
                max--;
                min++;
            }
            
        }
    }
}
