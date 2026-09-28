using System;

class Program
{
    static void Main()
    {
        Console.WriteLine(" Лабораторная работа №4");
        Console.WriteLine("PRIVET!");
        Console.WriteLine("ФИО: Перехрест Александра");
        Console.WriteLine("Группа: ИСП-242");
        Console.WriteLine($"Дата и время: {DateTime.Now}");
        Console.WriteLine();

        while (true)
        {
            Console.WriteLine("Меню:");
            Console.WriteLine("1 — Показать ФИО");
            Console.WriteLine("2 — Показать группу");
            Console.WriteLine("3 — Показать дату");
            Console.WriteLine("4 — Выход");
            Console.Write("Ваш выбор: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("ФИО: Перехрест Александра");
                    break;
                case "2":
                    Console.WriteLine("Группа: ИСП-242");
                    break;
                case "3":
                    Console.WriteLine($"Дата и время: {DateTime.Now}");
                    break;
                case "4":
                    Console.WriteLine("дос!");
                    return;
                default:
                    Console.WriteLine("wrong.");
                    break;
            }
            Console.WriteLine();
        }
    }
}