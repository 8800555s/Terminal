using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace С_шарп_практическая_2_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            double chislo = 0;
            Console.WriteLine("Введите число");
            while (!double.TryParse(Console.ReadLine(), out chislo))
            {
                Console.WriteLine("Данные введены неверно. Попробуйте снова");
                Console.WriteLine("Введите число");
            }

            int massa = 0;
            Console.WriteLine("Введите желаемые единицы измерения: 1 - килограммы, 2 - миллиграммы, 3 - граммы, 4 - тонны, 5 - центнеры");
            while (!int.TryParse(Console.ReadLine(), out massa) || massa < 1 || massa > 5)
            {
                Console.WriteLine("Данные введены неверно. Попробуйте снова");
                Console.WriteLine("Введите желаемые единицы измерения: 1 - килограммы, 2 - миллиграммы, 3 - граммы, 4 - тонны, 5 - центнеры");
            }
            if (massa == 1)
            {
                Console.WriteLine("Вы ввели число : {0} килограмм", chislo);
            }
            if (massa == 2)
            {
                Console.WriteLine("Вы ввели число : {0} миллиграмм", chislo);
            }
            if (massa == 3)
            {
                Console.WriteLine("Вы ввели число : {0} грамм", chislo);
            }
            if (massa == 4)
            {
                Console.WriteLine("Вы ввели число : {0} тонн", chislo);
            }
            if (massa == 5)
            {
                Console.WriteLine("Вы ввели число: {0} центнеров", chislo);
            }

            switch (massa)
            {
                case 1:
                    Console.WriteLine("Ваше число в киллограммах = {0}", (chislo));
                    break;
                case 2:
                    Console.WriteLine("Ваше число в киллограммах = {0}", (chislo * 1000000));
                    break;
                case 3:
                    Console.WriteLine("Ваше число в киллограммах = {0}", (chislo * 1000));
                    break;
                case 4:
                    Console.WriteLine("Ваше число в киллограммах = {0}", (chislo / 1000));
                    break;
                case 5:
                    Console.WriteLine("Ваше число в киллограммах = {0}", (chislo / 100));
                    break;
            }
            Console.ReadLine();
        }
    }
}
