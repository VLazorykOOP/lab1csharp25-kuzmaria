using System;
using System.Collections.Generic;

namespace DoctorScheduleApp
    {
        class DoctorSchedule
        {
            private static readonly Dictionary<string, string> schedule = new Dictionary<string, string>()
            {
                { "Monday", "9:00 - 12:00, 14:00 - 17:00" },
                { "Tuesday", "10:00 - 13:00, 15:00 - 18:00" },
                { "Wednesday", "9:00 - 12:00" },
                { "Thursday", "14:00 - 18:00" },
                { "Friday", "10:00 - 13:00, 15:00 - 17:00" },
                { "Saturday", "11:00 - 14:00" },
                { "Sunday", "Вихідний" }
            };

            public static void CheckSchedule()
            {
                // Зчитування дня тижня від користувача
                Console.WriteLine("Введіть день тижня для перевірки розкладу лікаря:");
                string? day = Console.ReadLine();  // nullable string

                if (day != null)  // Перевіряємо на null
                {
                    string scheduleForDay = GetSchedule(day);
                    Console.WriteLine(scheduleForDay);
                }
                else
                {
                    Console.WriteLine("Введено неправильний день.");
                }
            }

            public static string GetSchedule(string day)
            {
                day = char.ToUpper(day[0]) + day.Substring(1).ToLower(); // Робимо першу літеру великою
                return schedule.ContainsKey(day) ? $"Години прийому в {day}: {schedule[day]}" : "Невірний день тижня.";
            }
        }
    }
