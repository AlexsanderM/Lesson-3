using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lesson_3._1
{
    class Program
    {
        static int countOper = 0;

        static int[] bubble(int[] ar) {
            for (int i = 0; i < ar.Length; i++)
            {
                countOper ++;

                for (int j = 0; j < ar.Length - 1; j++)
                {
                    countOper++;

                    int k = 0;
                    countOper++;
                    if (ar[j] > ar[j + 1])
                    {
                        countOper++;

                        k = ar[j];
                        ar[j] = ar[j + 1];
                        ar[j + 1] = k;
                        
                    }
                }
            }
            return ar;
        }

        static int countOperMod = 0;

        static int[] bubbleMod(int[] ar)
        {
            
            for (int i = 0; i < ar.Length - 1; i++)
            {
                countOperMod++;

                int k = 0;

                if (ar[i] > ar[i + 1])
                {
                    countOperMod ++;

                    k = ar[i];
                    ar[i] = ar[i + 1];
                    ar[i + 1] = k;

                    bubbleMod(ar);
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
            Console.WriteLine(countOper);


            print(arMod.Length, arMod);
            Console.WriteLine();

            bubbleMod(arMod);
            print(arMod.Length, arMod);
            Console.WriteLine(countOperMod);


            Console.ReadKey();
            
        }
    }
}
