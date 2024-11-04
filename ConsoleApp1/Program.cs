using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("выберите вариант:");
            Console.WriteLine("1. Периметр");
            Console.WriteLine("2. Площадь");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1: perimetr(); break;
                case 2: area(); break;
                default: Console.WriteLine("Неправильный выбор."); break;
            }
        }

        static void perimetr()
        {
            Console.Write("a=");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b=");
            double b = double.Parse(Console.ReadLine());
            double sum = 2 * (a + b);
            Console.WriteLine($"Периметр: {sum}");
        }

        static void area()
        {
            Console.Write("a=");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b=");
            double b = double.Parse(Console.ReadLine());
            double area = a * b;
            Console.WriteLine($"Площадь: {area}");
        }
    }
}

