namespace AbstractFactory
{
    /// <summary>
    /// Паттерн "Абстрактная фабрика"
    /// https://refactoring.guru/design-patterns/abstract-factory
    /// Вариант применения - Генератор исходного кода HTML (по частям)
    /// </summary>
    public interface IHtmlFactory
    {
        string CreateHead();
        string CreateBody();
        string CreateFooter();
    }
}
