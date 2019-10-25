using System;

namespace matice
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            int[,] a = {{1, 4, 2}, {2, 5, 1}, {2, 3, 5}};
            int[,] b = {{3, 4, 2}, {3, 5, 7}, {1, 2, 1}};

            Console.WriteLine("Matice a:");
            for (i = 0; i < a.GetLength(0); i++) {
                for (j = 0; j < a.GetLength(1); j++) {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Matice b:");
            for (i = 0; i < b.GetLength(0); i++) {
                for (j = 0; j < b.GetLength(1); j++) {
                    Console.Write(b[i, j] + " ");
                }
                Console.WriteLine();
            }
            if(a.GetLength(1) != b.GetLength(0)) {
                Console.WriteLine("Násobení těchto matic není možné.");
            } else {
                int[,] c = new int[a.GetLength(0), b.GetLength(0)];
                for (i = 0; i < a.GetLength(0); i++) {
                for (j = 0; j < b.GetLength(1); j++) {
                    c[i, j] = 0;
                    for (int k = 0; k < a.GetLength(1); k++) {
                        c[i, j] += a[i, k] * b[k, j];
                    }
                }
                }
                Console.WriteLine("Součin těchto matic je roven: ");
                for (i = 0; i < a.GetLength(0); i++) {
                for (j = 0; j < a.GetLength(1); j++) {
                    Console.Write(c[i, j] + "\t");
                }
                Console.WriteLine();
                }
            }
        }
    }
}
