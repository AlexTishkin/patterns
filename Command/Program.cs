using System;

namespace Command
{
    /// <summary>
    /// Паттерн "Команда".
    /// https://refactoring.guru/ru/design-patterns/command
    /// Вариант применения - Вызов одних и тех же функций из консольного интерфейса
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Receiver receiver = new Receiver();

            Console.WriteLine("Меню консольного приложения");
            Console.WriteLine("1 - Сложение двух чисел");
            Console.WriteLine("2 - Вычитание двух чисел");
            Console.WriteLine("3 - Умножение двух чисел");
            Console.WriteLine("4 - Деление двух чисел");

            Console.WriteLine("\nАльтернативное меню консольного приложения");
            Console.WriteLine("один - Сложение двух чисел");
            Console.WriteLine("два - Вычитание двух чисел");
            Console.WriteLine("три - Умножение двух чисел");
            Console.WriteLine("четыре - Деление двух чисел");

            Console.Write("\nВыберите пункт меню: ");
            var choosenMenuItem = Console.ReadLine();


            Console.Write("\nВведите первое число: ");
            var a = double.Parse(Console.ReadLine());
            Console.Write("Введите второе число: ");
            var b = double.Parse(Console.ReadLine());


            ICommand command = null;

            switch (choosenMenuItem)
            {
                case "1":
                case "один":
                    command = new AddCommand(receiver, a, b); 
                    break;
                case "2":
                case "два":
                    command = new SubCommand(receiver, a, b); 
                    break;
                case "3":
                case "три":
                    command = new MultipleCommand(receiver, a, b); 
                    break;
                case "4":
                case "четыре":
                    command = new DivCommand(receiver, a, b); 
                    break;
            }

            command.Execute();

        }
    }
}
