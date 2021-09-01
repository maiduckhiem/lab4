using System;

namespace lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, n;
            Console.Write("moi nhap so sao:");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= n; i++)
            {
                for (j = 1; j <= n - i; j++)
                {
                    Console.Write("");
                }
                for (j = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
            Console.ReadKey();
        }
    }
}
//tam giác sao