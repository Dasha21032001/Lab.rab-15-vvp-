using System;

namespace з4
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
            int min = 100000, max = 0, imax=0, imin=0;
            for (int i = 0; i < N; i++)
            {
                if (A[i] < min)
                {
                    min = A[i];
                     imin = i;
                }
                if (A[i] > max)
                {
                    max = A[i];
                     imax = i;
                }
            }
                if (min > max) 
                {
                    for (int i = imax + 1; i < imin; i++)
                    {
                        A[i] = 0;
                    }
                }
                if (max > min)
                {
                    for (int i = imin + 1; i < imax; i++)
                    {
                        A[i] = 0;
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