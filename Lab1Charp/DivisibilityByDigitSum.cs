// DivisibilityByDigitSum.cs
using System;

namespace TriangleAreaAndDivisibility
{
    public class DivisibilityByDigitSum
    {
        public static void CheckDivisibility()
        {
            try
            {
                // Введення числа A і двозначного числа
                Console.Write("Введіть число A: ");
                int A = int.Parse(Console.ReadLine());

                Console.Write("Введіть двозначне число: ");
                int number = int.Parse(Console.ReadLine());

                // Перевірка, чи є число двозначним
                if (number < 10 || number > 99)
                {
                    Console.WriteLine("Число повинно бути двозначним.");
                    return;
                }

                // Обчислення суми цифр двозначного числа
                int tens = number / 10; // десятки
                int ones = number % 10; // одиниці
                int sumOfDigits = tens + ones;

                // Перевірка на кратність
                if (A % sumOfDigits == 0)
                {
                    Console.WriteLine($"Число A ({A}) кратне сумі цифр числа {number}, яка дорівнює {sumOfDigits}.");
                }
                else
                {
                    Console.WriteLine($"Число A ({A}) не кратне сумі цифр числа {number}, яка дорівнює {sumOfDigits}.");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Введено некоректне число. Переконайтесь, що ви ввели правильний формат.");
            }
        }
    }
}
