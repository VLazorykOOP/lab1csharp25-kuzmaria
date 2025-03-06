// TriangleArea.cs
using System;

namespace TriangleAreaAndDivisibility
{
    public class TriangleArea
    {
        public static void CalculateArea()
        {
            // Введення координат
            Console.Write("Введіть координату x1: ");
            string inputX1 = Console.ReadLine();
            Console.Write("Введіть координату y1: ");
            string inputY1 = Console.ReadLine();
            Console.Write("Введіть координату x2: ");
            string inputX2 = Console.ReadLine();
            Console.Write("Введіть координату y2: ");
            string inputY2 = Console.ReadLine();
            Console.Write("Введіть координату x3: ");
            string inputX3 = Console.ReadLine();
            Console.Write("Введіть координату y3: ");
            string inputY3 = Console.ReadLine();

            // Перевірка на null і конвертація
            if (double.TryParse(inputX1, out double x1) &&
                double.TryParse(inputY1, out double y1) &&
                double.TryParse(inputX2, out double x2) &&
                double.TryParse(inputY2, out double y2) &&
                double.TryParse(inputX3, out double x3) &&
                double.TryParse(inputY3, out double y3))
            {
                // Обчислення площі трикутника за формулою
                double area = Math.Abs(x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2)) / 2;
                Console.WriteLine($"Площа трикутника: {area}");
            }
            else
            {
                Console.WriteLine("Введені некоректні координати.");
            }
        }
    }
}
