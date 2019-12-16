using System;

namespace з3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите кол-во элементов в массиве:");
            int N = Convert.ToInt32(Console.ReadLine());
            int[] A = new int[N];
            Console.WriteLine("Введите элементы массива: ");
            for (int i = 0; i < N; i++)
            {
                int c = Convert.ToInt32(Console.ReadLine());
                A[i] = c;
            }
            int k = 0;
            for (int i = 0; i < N; i++)
            {
                if (A[i] % 2 == 1)
                {
                    k = A[i];
                }
            }
            for (int i = 0; i < N; i++)
            {
                if (A[i] % 2 == 1)
                {
                    A[i] = A[i] + k;
                    Console.WriteLine(" " + A[i]);
                }
                else
                {
                    Console.WriteLine(" " + A[i]);
                }
            }
            Console.ReadLine();
        }
    }
}
