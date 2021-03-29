namespace Proxy
{
    /// <summary>
    /// Паттерн "Заместитель".
    /// https://refactoring.guru/ru/design-patterns/proxy
    /// Вариант применения - добавление проверки доступа к БД;
    /// Добавление дополнительных действий до и после выполнения методов объекта (Connect).
    /// Также можно закешировать что-либо
    /// </summary>
    class ProxyExample
    {
        static void Main(string[] args)
        {
            IDatabase databaseProxy = new DatabaseProxy("123456");
            databaseProxy.Connect();
            databaseProxy.ExecuteQuery("SELECT * FROM dbo.Dictionaries");
            databaseProxy.Disconnect();
        }
    }
}
