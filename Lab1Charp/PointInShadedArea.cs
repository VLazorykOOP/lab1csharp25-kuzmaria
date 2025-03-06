using System;

namespace TriangleAreaAndDivisibility
{
    class PointInShadedArea
    {
        public static void CheckPoint()
        {
            Console.Write("Введіть координати точки (x, y): ");
            string[] input = Console.ReadLine().Split();
            double x = double.Parse(input[0]);
            double y = double.Parse(input[1]);

            // Межі квадрата (центр у (0,0), сторона 80)
            double left = -40, right = 40, top = 40, bottom = -40;

            if (x > left && x < right && y > bottom && y < top)
            {
                Console.WriteLine("Так");
            }
            else if (x == left || x == right || y == bottom || y == top)
            {
                Console.WriteLine("На межі");
            }
            else
            {
                Console.WriteLine("Ні");
            }
        }
    }
}
