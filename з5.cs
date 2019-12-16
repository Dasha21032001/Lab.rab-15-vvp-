using System;

namespace з5
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
            for (int i = 1; i < N; i++)
            {
                if (A[i - 1] > A[i])
                {
                    int c = A[i];
                    A[i] = A[i - 1];
                    A[i - 1] = c;
                }
            }
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine(" " + A[i]);
            }
            Console.ReadLine();
        }
    }
}