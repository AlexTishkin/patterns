using System;

namespace Bridge
{
    /// <summary>
    /// Паттерн "Мост".
    /// https://refactoring.guru/ru/design-patterns/bridge
    /// Вариант применения - разбиение монолита на абстрацию и реализацию
    /// </summary>
    class BridgeExample
    {
        static void Main(string[] args)
        {
            IMathManager manager = new SimpleMathManager();

            var api = new Api(manager);
            var sumItog = api.Sum(1, 9);
            var multipleItog = api.Multiple(15, 4);
            Console.WriteLine($"{sumItog}; {multipleItog}");
        }
    }
}
