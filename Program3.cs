//СТУПЕНЧАТЫЕ МАССИВЫ
using System;


namespace _17._01._24
{
   class Program
   {
       static void Main(string[] args)
       {
            Console.WriteLine("Введите длину ступенчатого массива:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Будешь заполнять массив сам?(да/нет)");
            string s = Console.ReadLine();
            bool fill;
            if (s == "да") {fill = true;}
            else {fill = false;}
            LVL3 array_3 = new LVL3(a, fill);
            Console.WriteLine("Создан массив вида:");
            array_3.Print(array_3.array);
            array_3.global_average();
            array_3.local_average();
            Console.WriteLine("Массив с измененными четными значениями:");
            array_3.SwapOnInd();
       }
   }


   class LVL3
   {
       private int a;
       public int[][] array;
      
       public LVL3(int a1, bool f)
       {
           a = a1;
           array = new int[a1][];

           if (!f)
           {
               Random rnd = new Random();
               for (int i = 0; i<a1; i++)
               {
                   Console.Write($"Длина {i} массива: ");
                   int l = int.Parse(Console.ReadLine());
                   array[i] = new int[l];
                   for (int j = 0; j<l; j++)
                   {
                       int x = rnd.Next(-1000, 1000);
                       array[i][j] = x;
                   }
               }
           }

           else
           {
               for (int i = 0; i<a1; i++)
               {
                   Console.Write($"Длина {i} массива: ");
                   int l = int.Parse(Console.ReadLine());
                   array[i] = new int[l];
                   for (int j = 0; j<l; j++)
                   {
                       Console.Write($"Элемент [{i},{j}]: ");
                       int x = int.Parse(Console.ReadLine());
                       array[i][j] = x;
                   }
               }
           }
       }




       public void global_average()
       {
           int sum = 0;
           int el = 0;
           for (int i = 0; i<a; i++)
           {
               for (int j = 0; j<array[i].Length; j++)
               {
                   int x = array[i][j];
                   sum += x;
                   el ++;
               }
           }
           Console.WriteLine($"Среднее арифметическое целого массива: {sum/el}");
       }




       public void local_average()
       {
           int sum = 0;
           int el = 0;
           for (int i = 0; i<a; i++)
           {
               int[] arr = array[i];
               foreach (int x in arr)
               {
                   sum += x;
                   el ++;
               }
               Console.WriteLine($"Ср.арифм. [{i}] подмассива: {sum/el}");
               sum = 0;
               el = 0;
           }
       }




       public void Print(int[][] arr)
       {
           for (int i = 0; i<a; i++)
           {
               for (int j = 0; j<arr[i].Length; j++)
               {
                   if(j==arr[i].Length-1)
                   {
                       Console.WriteLine(arr[i][j]);
                   }


                   else
                   {
                       Console.Write($"{arr[i][j]} ");
                   }
               }
           }
       }


       public void SwapOnInd()
       {
            int[][] arr = new int[a][];
            for (int i = 0; i<a; i++)
            {
                arr[i] = new int[array[i].Length];
                for(int j = 0; j<array[i].Length; j++)
                {
                    int x = array[i][j];
                    if (x%2==0)
                    {
                        arr[i][j] = i*j;
                    }

                    else
                    {
                        arr[i][j] = x;
                    }
                }
            }
            Print(arr);
       }
   }
}
