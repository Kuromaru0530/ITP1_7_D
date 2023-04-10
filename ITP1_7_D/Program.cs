using System;
using System.Linq;
using System.Collections.Generic;

namespace ITP1_7_D
{
    class Program
    {
        static void Main()
        {
            string[] Line = Console.ReadLine().Split(' ');
            int n = int.Parse(Line[0]);
            int m = int.Parse(Line[1]);
            int l = int.Parse(Line[2]);

            int[,] MatrixA = new int[n, m];
            int[,] MatrixB = new int[m, l];
            long[,] MatrixC = new long[n, l];

            for(int i = 1; i <= n; i++)
            {
                string[] Num1 = Console.ReadLine().Split(' ');
                for(int j = 1; j <= m; j++)
                {
                    MatrixA[i-1, j-1] = int.Parse(Num1[j-1]);
                } 
            }

            for(int i = 1; i <= m; i++)
            {
                string[] Num2 = Console.ReadLine().Split(' ');
                for(int j = 1; j <= l; j++)
                {
                    MatrixB[i-1, j-1] = int.Parse(Num2[j-1]);
                }
            }

            for(int i = 1; i <= n; i++)
            {
                for(int j = 1; j <= l; j++)
                {
                    for(int k = 1; k <= m; k++)
                    {
                        MatrixC[i-1, j-1] += MatrixA[i-1, k-1] * MatrixB[k-1, j-1];
                    }
                }
            }

            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < l-1; j++)
                {
                    Console.Write(MatrixC[i, j]);
                    Console.Write(' ');
                }
                Console.Write(MatrixC[i, l-1]);
                Console.WriteLine();
            }
        }
    }
}