using System;

namespace practice
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new int[10];

            for (int i = 0; i < a.Length; i++)
            {
                a[i] = i;
                Console.WriteLine(a[i]);
            }
            
            var b = new int[10, 10];

            for (int i = 0; i < b.GetLength(0); i++)
            {
                for (int j = 0; j < b.GetLength(1); j++)
                {
                    b[i, j] = i * j;
                    Console.Write(b[i, j]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
            
            var c = new int[2, 2, 2, 2, 2];

            for (int i = 0; i < c.GetLength(0); i++)
            {
                for (int j = 0; j < c.GetLength(1); j++)
                {
                    for (int k = 0; k < c.GetLength(2); k++)
                    {
                        for (int l = 0; l < c.GetLength(3); l++)
                        {
                            for (int m = 0; m < c.GetLength(4); m++)
                            {
                                c[i, j, k, l, m] = i * j * k * l * m;
                                Console.Write(c[i, j, k, l, m]);
                                Console.Write(" ");
                            }
                        }
                    }
                }
            }
            Console.WriteLine();

            var d = new int[5][][];
            
            for (int i = 0; i < d.GetLength(0); i++)
            {
                d[i] = new int[i + 1][];
                for (int j = 0; j < i + 1; j++)
                {
                    d[i][j] = new int[i + j + 1];
                    for (int k = 0; k < i + j + 1; k++)
                    {
                    Console.Write(d[i][j][k]);
                    Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
