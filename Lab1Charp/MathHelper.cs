using System;

namespace TriangleAreaAndDivisibility
{
    class MathHelper
    {
        public static void SquareOfQuotient()
        {
            Console.Write("Введіть два цілих числа (a і b): ");
            string[] input = Console.ReadLine().Split();
            int a, b;

            if (!int.TryParse(input[0], out a) || !int.TryParse(input[1], out b))
            {
                Console.WriteLine("Помилка: введено некоректні числа.");
                return;
            }

            if (b == 0)
            {
                Console.WriteLine("Помилка: ділення на нуль неможливе.");
                return;
            }

            int quotient = a / b;
            int square = quotient * quotient;

            Console.WriteLine($"Квадрат частки {a} / {b} = {square}");
        }
    }
}
