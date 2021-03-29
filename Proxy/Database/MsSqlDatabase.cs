using System;

namespace Proxy
{
    public class MsSqlDatabase : IDatabase
    {
        public void Connect() => Console.WriteLine("Подключение к MS SQL Server");

        public void Disconnect() => Console.WriteLine("Отключение от MS SQL Server");

        public void ExecuteQuery(string sql) => Console.WriteLine($"Выполнение запроса '{sql}' на MS SQL Server");
    }
}
