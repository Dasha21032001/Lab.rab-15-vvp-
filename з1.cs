using System;

namespace лаб.раб._15
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

            Console.WriteLine("Введите кол-во элементов в массиве(ТАКОЕ ЖЕ, ЧТО И В ПЕРВОМ МАССИВЕ):");
            int N1 = Convert.ToInt32(Console.ReadLine());
            int[] B = new int[N1];
            Console.WriteLine("Введите элементы массива: ");
            for (int i = 0; i < N1; i++)
            {
                int c1 = Convert.ToInt32(Console.ReadLine());
                B[i] = c1;
            }
            for (int i = 0; i < N; i++)
            {
                int t = A[i];
                A[i] = B[i];
                B[i] = t;
                Console.WriteLine(" " + A[i]);
            }
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine(" " + B[i]);
            }
            Console.ReadLine();
        }
    }
}
