using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace С_шарп_практическая_3Х2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Практическая №3. Задание 2. Номер 2");
            Console.WriteLine("Введите натуральный знаменатель n больше 1");
            int n = 0;
            double a = 1;
            while (!int.TryParse(Console.ReadLine(), out n) || n <= 1)
            {
                Console.WriteLine("Ошибка ввода");
                Console.WriteLine("Введите знаменатель натуральный знаменатель больше 1");
            }
            for (double i = 1; i <= n; i++)
            {
                a *= (1 + 1 / Math.Pow(i, 2));

            }
            Console.WriteLine("Ответ = {0}", a);
            Console.ReadKey();
        }
    }
}
