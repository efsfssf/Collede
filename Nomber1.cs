using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число n: ");
            // Создаем проверку ввода
            int n = 0;
            do
            {
                n = int.Parse(Console.ReadLine());
            }
            // Проверяем введеное число на диапозон и натуральность
            while (n <= 10 || n >= 8000 && n>0);
            // Запускаем void
            Chisla(n);

            // Процедура проверяющая кол-во цифр в числе
            void Chisla(int n)
            {
                int i = 1;
                do
                {
                    i++;
                    n /= 10;
                } while (n > 10);
                Console.Write(i);
            }
        }
    }
}
