using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace С_шарп_Практическая_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double e = 2.72;
            double a = 0;
            Console.Write("Число a = ");
            while (!double.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine("Ошибка, недопустимое значение. Попробуйте ещё раз.");
                Console.Write("Число a = ");
            }
            double b = 0;
            Console.Write("Число b = ");
            while (!double.TryParse(Console.ReadLine(), out b))
            {
                Console.WriteLine("Ошибка, недопустимое значение. Попробуйте ещё раз.");
                Console.Write("Число b = ");
            }
            double t = 0;
            Console.Write("Число t = ");
            while (!double.TryParse(Console.ReadLine(), out t))
            {
                Console.WriteLine("Ошибка, недопустимое значение. Попробуйте ещё раз.");
                Console.Write("Число t = ");
            }
            if (a > b)
            {
                Console.WriteLine("a > b");
                Console.Write("Выполняется первое выражение: ");
                Console.Write("2/3 * a * t^3 + 3 * b * t - sin(t) = ");
                Console.WriteLine(2 / 3 * a * Math.Pow(t, 3) + 3 * b * t - Math.Sin(t));
            }
            if (a < b)
            {
                Console.WriteLine("a < b");
                Console.Write("Выполняется второе выражение: ");
                Console.Write("e^(a + b) + 10^-3 * t^2 = ");
                Console.WriteLine(Math.Pow(e, a + b) + Math.Pow(10, -3) * Math.Pow(t, 2));
            }
            if (a == b)
            {
                Console.WriteLine("a = b");
                Console.Write("Выполняется третье выражение: ");
                Console.Write("a * sin(t * t + b) = ");
                Console.WriteLine(a * Math.Sin(t * t + b));
            }
            Console.ReadKey();
        }
    }
}
