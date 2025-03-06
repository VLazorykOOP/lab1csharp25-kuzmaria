using System;

namespace TriangleAreaAndDivisibility
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Оберіть програму для запуску:");
            Console.WriteLine("1 - Обчислення площі трикутника");
            Console.WriteLine("2 - Перевірка кратності числу суми цифр");
            Console.WriteLine("3 - Точка на площині");
            Console.WriteLine("4 - Перевірка розкладу лікаря");
            Console.WriteLine("5 - Обчислення квадрата частки двох чисел");
            Console.WriteLine("6 - Обчислення виразу для m та n");

            string? choice = Console.ReadLine();  

            if (choice != null)  
            {
                if (choice == "1")
                {
                    TriangleArea.CalculateArea();
                }
                else if (choice == "2")
                {
                    DivisibilityByDigitSum.CheckDivisibility();
                }
                else if (choice == "3")
                {
                    PointInShadedArea.CheckPoint();
                }
                else if (choice == "4")
                {
                    DoctorScheduleApp.DoctorSchedule.CheckSchedule();
                }
                else if (choice == "5")
                {
                    MathHelper.SquareOfQuotient();
                }
                else if (choice == "6")
                {
                    ExpressionCalculator.ExpressionEvaluator.CalculateExpression();
                }
                else
                {
                    Console.WriteLine("Невірний вибір.");
                }
            }
            else
            {
                Console.WriteLine("Вибір не був введений.");
            }
        }
    }
}
