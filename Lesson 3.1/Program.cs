using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lesson_3._1
{
    class Program
    {
        static int[] bubble(int[] ar) {            
            for (int i = 0; i < ar.Length; i++)
            {
                for (int j = 0; j < ar.Length - 1; j++)
                {
                    int k = 0;

                    if (ar[j] > ar[j + 1])
                    {
                        k = ar[j];
                        ar[j] = ar[j + 1];
                        ar[j + 1] = k;
                    }
                }
            }
            return ar;
        }

        static int[] bubbleMod(int[] ar)
        {
            for (int i = 0; i < ar.Length; i++)
            {
                for (int j = 0; j < ar.Length - 1; j = j +1)
                {
                    int k = 0;

                    if (ar[j] > ar[j + 1])
                    {
                        k = ar[j];
                        ar[j] = ar[j + 1];
                        ar[j + 1] = k;
                        if (ar[j+1] > ar[j+2]) {
                            k = ar[j+1];
                            ar[j+1] = ar[j + 2];
                            ar[j + 2] = k;
                        }
                    }
                }
            }
            return ar;
        }

        static void print(int N, int[] a)
        {
            //a = new int[N];
            for (int i = 0; i < N; i++)
                Console.Write(a[i] + " ");
        }

        static void Main(string[] args)
        {
            //
            //Малов Александр Витальевич

            //1.Попробовать оптимизировать пузырьковую сортировку.Сравнить количество операций сравнения оптимизированной и не 
            //оптимизированной программы.Написать функции сортировки, которые возвращают количество операций.

            int[] ar = new int[7] { 3, 1, 5, 4, 9, 2, 1 };
            int[] arMod = new int[7] { 3, 1, 5, 4, 9, 2, 1 };

            print(ar.Length, ar);
            Console.WriteLine();
      
            bubble(ar);
            print(ar.Length, ar);
            Console.WriteLine();

            print(arMod.Length, arMod);
            Console.WriteLine();

            bubbleMod(arMod);
            print(arMod.Length, arMod);

            Console.ReadKey();
            
        }
    }
}
