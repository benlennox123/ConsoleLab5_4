using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLab5_4
{
    class Lab5_3
    {
        static void Main(string[] args)
        {
            const int n = 20;
            int[] array = new int[n];
            Random random = new Random();
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                array[i] = random.Next(-50, 50);
                int t1 = i % 2;
                if (t1==0)
                {
                    Console.Write("{0,4} ", array[i]);
                }
                else
                {
                    Console.Write("{0,3} ", array[i]);
                    int t2 = array[i] % 2;
                    int t3 = Math.Abs(t2);
                    if (t2==1 && t3==t2)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Количество нечётных положительных чисел на чётных позициях мссива - {0}", count);
            Console.WriteLine();
            Console.Write("Для завершения нажмите любую клавишу");
            Console.ReadKey();
        }
    }
}
