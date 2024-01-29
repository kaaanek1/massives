using System;

namespace travis_scott
{
    class Program
    {
        static void Main(string[] args)
        {
            //Объект одномерного класса
            Console.WriteLine("Начало создания одномерного массива");
            Console.WriteLine("Введи длину массива:");
            int len = int.Parse(Console.ReadLine());
            Console.WriteLine("Будешь заполнять массив сам?(да/нет)");
            string str = Console.ReadLine();
            bool fill;
            if (str == "да")
            {
                fill = true;
            }
            else
            {
                fill = false;
            }
            LVL1 array_1 = new LVL1(len, fill);
            Console.WriteLine("Исходный массив:");
            array_1.Print(array_1.array);
            Console.WriteLine("Среднее арифметическое:");
            array_1.Average();
            Console.WriteLine("Значения меньше ста по модулю:");
            array_1.Delete100();
            Console.WriteLine("Только уникальные элементы:");
            array_1.Uniqal();

            //Объект двумерного класса
            Console.WriteLine("Начало создания двумерного массива");
            Console.WriteLine("Введи кол-во подмассивов:");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Введи длину входящих подмассивов:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Будешь заполнять массивы сам?(да/нет)");
            str = Console.ReadLine();
            if (str == "да") { fill = true; }
            else { fill = false; }

            LVL2 array_2 = new LVL2(a, b, fill);
            Console.WriteLine("Создана матрица:");
            array_2.Print(array_2.array);
            array_2.Average();
            Console.WriteLine("Массив змейкой:");
            array_2.Snake();

            //Объект ступенчатого класса
            Console.WriteLine("Начало создания ступенчатого массива");
            Console.WriteLine("Введите длину ступенчатого массива:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Будешь заполнять массив сам?(да/нет)");
            string s = Console.ReadLine();
            if (s == "да") { fill = true; }
            else { fill = false; }
            LVL3 array_3 = new LVL3(a, fill);
            Console.WriteLine("Создан массив вида:");
            array_3.Print(array_3.array);
            array_3.global_average();
            array_3.local_average();
            Console.WriteLine("Массив с измененными четными значениями:");
            array_3.SwapOnInd();
        }
    }
}
