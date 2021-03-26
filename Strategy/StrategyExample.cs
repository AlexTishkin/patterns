using System;

namespace Strategy
{
    /// <summary>
    /// Паттерн "Стратегия".
    /// https://refactoring.guru/ru/design-patterns/strategy
    /// Вариант применения - смена формата вывода лога на лету
    /// </summary>
    class StrategyExample
    {
        static void Main(string[] args)
        {
            var someLog = new Log(Guid.NewGuid(), "Ошибка при обращении к БД", "WARNING", DateTime.Now);

            var logMonitor = new LogMonitor();
            logMonitor.SetStrategy(new ShortMonitorStrategy());
            logMonitor.ShowLog(someLog);

            // Смена поведения класса на лету
            logMonitor.SetStrategy(new LongMonitorStrategy());
            logMonitor.ShowLog(someLog);

        }
    }
}
