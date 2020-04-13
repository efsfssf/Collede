using System;
using System.Diagnostics;
/****** ВАРИНАТ №14 *********/
namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Вводим число m
            Console.WriteLine("Введите число m: ");
            /*static*/ int m = int.Parse(Console.ReadLine());
            // Ищем все сотые числа
            int i = 100;
            do
            {
                // Берем первые числа, для проверки на четность
                // По другому у меня не получилось
                int n = 0;
                do
                {
                    n = i / 100;
                    // Console.WriteLine(n);
                    
                    // Отправляем эти числа в процедуру even
                    even(n, i);
                }
                while (n == 0);
                //Console.WriteLine(i);
                i += 100;
            }
            while (i <= 1000);
            // even(i);

            // Процедура even, для проверки чисел на четность
            void even(int n, int i)
            {
                // Проверяем четность
                if (n % 2 != 0)
                {
                    // Не четные числа
                    // Задаем новую переменную
                    float resilt;

                    //Console.Write("Нечет — " + m /*+ s*/ + i);
                    resilt = i / m;

                    // Вывод результата
                    // Екатерина Валентиновна! Как в выводе мне использовать префикс f ??????
                    Console.WriteLine(resilt);


                }
                else
                {
                    //Debug.Log("чет");
                    // Console.Write("Чет — ");
                }
            }
        }
    }
}
/*************************************************************************
 **********************У МЕНЯ ПОЛУЧИЛОСЬ! Это было сложно*****************
 ************************************************************************/