using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NearestValue
{
    class Matrix
    {
        public static int addMatrix(int[,] arra)
        {
            int x = 0;
            for (int i = 0; i < arra.Length; i++)
                for (int j = 0; j < arra.Length && arra[j, i] > 0; j++)
                    x += arra[i,j];
            return x;
                
        }
    }
}
