using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NearestValue
{
    class Program
    {
        public static int checkValue(int integer1, int integer2)
        {
            if (integer1 > integer2 && integer1 <= 20)
            {
                return integer1;
            }
            else if (integer1 < integer2 && integer2 <= 20)
            {
                return integer2;
            }
            else
            {
                return 0;
            }
        }
        
        static void Main(string[] args)
        {

            Matrix matrixes = new Matrix();

            Console.WriteLine("Please enter first integer");
            var first = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter second integer");
            var second = int.Parse(Console.ReadLine());
            Console.WriteLine(checkValue(first, second));

                  
        }
    }
}
