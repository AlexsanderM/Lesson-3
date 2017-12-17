using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_3._2
{
    class Program
    {
        static void print(int N, int[] a)
        {
            //a = new int[N];
            for (int i = 0; i < N; i++)
                Console.Write(a[i] + " ");
        }

        static void Main(string[] args)
        {
            // Малов Александр Витальевич
            //2. *Реализовать шейкерную сортировку.
            int max = 0;
            int step = 1;
            int[] ar = new int[9] { 3, 4, 1, 9, 8, 22, 4, 0, 5 };
            int min = ar[0];

            while (step == 1)
            {
                if (step % 2 == 1)
                {
                    for (int i = 0; i < ar.Length; i++)
                    {
                        if (ar[i] > max)
                        {
                            max = ar[i];
                            ar[i] = ar[ar.Length - 1];
                        }
                    }
                    ar[ar.Length - 1] = max;
                    step++;
                }

                if (step % 2 == 0)
                {
                    for (int i = ar.Length - 1; i > 0; i--)
                    {
                        if (ar[i] < min)
                        {
                            min = ar[i];
                            ar[0] = ar[i];
                        }
                    }
                    ar[0] = min;
                    step++;
                }
            }


            print(9 , ar);
            Console.ReadKey();
        }
    }
}
