using System;

namespace ExpressionCalculator
{
    class ExpressionEvaluator
    {
        public static void CalculateExpression()
        {
            Console.Write("Введіть значення m: ");
            if (!int.TryParse(Console.ReadLine(), out int m))
            {
                Console.WriteLine("Помилка: введено некоректне число.");
                return;
            }

            Console.Write("Введіть значення n: ");
            if (!int.TryParse(Console.ReadLine(), out int n))
            {
                Console.WriteLine("Помилка: введено некоректне число.");
                return;
            }

            // Перевірка на ділення на 0 (n + m + 1 не має дорівнювати 0)
            if (n + m + 1 == 0)
            {
                Console.WriteLine("Помилка: знаменник не може бути 0.");
                return;
            }

            // Обчислення виразу
            double result = (m - n) * ((double)(n + 1) / (n + m + 1)) - Math.Pow(n, 2) + 5;

            Console.WriteLine($"Результат: {result}");
        }
    }
}
