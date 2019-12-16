using System;

namespace з2
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
            Console.WriteLine("Введите число К(номер элемента к первом массиве):");
            int K = Convert.ToInt32(Console.ReadLine());

            int[] B = new int[N];
            Console.WriteLine("Введите элементы второго массива: ");
            for (int i = 0; i < N; i++)
            {
                int c1 = Convert.ToInt32(Console.ReadLine());
                B[i] = c1;
            }
            int S = 0;
            int k = 0;
            for (int i = 0; i <= K; i++)
            {
                S = S + A[i];
                k++;
                if (i == K)
                {
                    B[i] = S / k;
                }
            }
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine(" " + B[i]);
            }
            Console.ReadLine();
        }
    }
}
