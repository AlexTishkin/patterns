namespace Mediator
{
    /// <summary>
    /// Паттерн "Посредник".
    /// https://refactoring.guru/ru/design-patterns/mediator
    /// Вариант применения - контроль видимости отдельных компонентов диалога (в зависимости от режима)
    /// За Управление видимостью отвечает отдельный класс - посредник
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var dialog = new AuthenticationDialog();
            dialog.ShowMenu();
        }
    }

}
