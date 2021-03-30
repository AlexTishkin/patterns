using System;

namespace State
{
    /// <summary>
    /// Паттерн "Состояние".
    /// https://refactoring.guru/ru/design-patterns/state
    /// Вариант применения - реализация конечного автомата (Кофемашина)
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var coffeApparat = new CoffeApparat();
            coffeApparat.Pay();
            coffeApparat.ChooseCoffee();
        }
    }
}
