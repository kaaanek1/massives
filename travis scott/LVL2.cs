using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace travis_scott
{
    class LVL2
    {
        public int[,] array;
        private int a;
        private int b;

        public LVL2(int a1, int b1, bool fill)
        {
            a = a1;
            b = b1;
            array = new int[b1, a1];

            if (fill)
            {
                for (int i = 0; i < b; i++)
                {
                    for (int j = 0; j < a; j++)
                    {
                        Console.Write($"Элемент ({i},{j}): ");
                        array[i, j] = int.Parse(Console.ReadLine());
                    }
                }
            }
            else
            {
                Random rnd = new Random();
                for (int i = 0; i < b; i++)
                {
                    for (int j = 0; j < a; j++)
                    {
                        array[i, j] = rnd.Next(-1000, 1000);
                    }
                }
            }
        }


        public void Print(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (j == a - 1) { Console.WriteLine(arr[i, j]); }
                    else { Console.Write($"{arr[i, j]} "); }
                }
            }
        }


        public void Average()
        {
            int sum = 0;
            for (int i = 0; i < b; i++)
            {
                for (int j = 0; j < a; j++)
                {
                    sum += array[i, j];
                }
            }
            Console.WriteLine($"Среднее арифметическое: {sum / (a * b)}");
        }


        public void Snake()
        {
            for (int i = 0; i < b; i++)
            {
                if ((i + 1) % 2 == 0)
                {
                    for (int j = a - 1; j >= 0; j--)
                    {
                        if (j == 0)
                        {
                            Console.WriteLine($"{array[i, j]}");
                        }
                        else
                        {
                            Console.Write($"{array[i, j]} ");
                        }
                    }
                }
                else
                {
                    for (int j = 0; j < a; j++)
                    {
                        if (j == a - 1)
                        {
                            Console.WriteLine($"{array[i, j]}");
                        }
                        else
                        {
                            Console.Write($"{array[i, j]} ");
                        }
                    }
                }
            }
        }
    }
}
