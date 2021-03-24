using System;

namespace FactoryMethod
{
    /// <summary>
    /// Паттерн "Фабричный метод"
    /// https://refactoring.guru/design-patterns/factory-method
    /// Вариант применения - смена базы данных во время работы приложения
    /// </summary>
    public abstract class Database
    {
        public void ExecuteSqlQuery(string query)
        {
            using (IDbConnection dbConnection = CreateDbConnection())
            {
                dbConnection.Connect();
                Console.WriteLine($"Выполнение sql запроса: {query}");
            }
        }

        public abstract IDbConnection CreateDbConnection();
    }
}
