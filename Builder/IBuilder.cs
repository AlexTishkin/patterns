namespace Builder
{
    /// <summary>
    /// Реализация паттерна "Строитель"
    /// https://refactoring.guru/design-patterns/builder
    /// Вариант применения - проектирование страницы сайта (ШАГ ЗА ШАГОМ)
    /// </summary>
    public interface IBuilder
    {
        void BuildHead();
        void BuildBody();
        void BuildFooter();
        void Reset();
        string GetResult();
    }
}
