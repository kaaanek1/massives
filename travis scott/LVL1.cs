using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace travis_scott
{
    class LVL1
    {
        public int[] array;

        private int len;

        public LVL1(int l, bool f)
        {
            len = l;
            array = new int[l];
            if (!f)
            {
                Random rnd = new Random();
                for (int i = 0; i < l; i++)
                {
                    array[i] = rnd.Next(-1000, 1000);
                }
            }

            else
            {
                for (int i = 0; i < l; i++)
                {
                    Console.Write($"Элемент {i}: ");
                    int x = int.Parse(Console.ReadLine());
                    array[i] = x;
                }
            }
        }


        public void Print(int[] arr)
        {
            int l1 = arr.Length;
            for (int i = 0; i < l1; i++)
            {
                if (i == l1 - 1) { Console.WriteLine($"{arr[i]}"); }
                else { Console.Write($"{arr[i]} "); }
            }
        }


        public void Average()
        {
            int sum = 0;
            foreach (int el in array)
            {
                sum += el;
            }
            Console.WriteLine(sum / len);
        }


        public void Delete100()
        {
            int new_len = 0;
            int i = 0;
            foreach (int el in array)
            {
                if (Math.Abs(el) <= 100)
                {
                    new_len++;
                }
            }
            int[] new_arr = new int[new_len];
            foreach (int l in array)
            {
                if (Math.Abs(l) < 100)
                {
                    new_arr[i] = l;
                    i++;
                }
            }
            Print(new_arr);
        }


        public void Uniqal()
        {
            int[] newArray = new int[len];
            int uniq = 1;
            for (int i = 0; i < len; i++)
            {
                bool isUniq = true;
                for (int j = i + 1; j < len; j++)
                {
                    if (array[i] == array[j])
                    {
                        isUniq = false;
                    }
                }
                if (isUniq)
                {
                    newArray[uniq - 1] = array[i];
                    uniq++;
                }
            }
            Print(newArray);
        }
    }
}

