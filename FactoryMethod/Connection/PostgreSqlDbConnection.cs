using System;

namespace FactoryMethod
{
    public class PostgreSqlDbConnection : IDbConnection
    {
        public void Connect()
        {
            Console.WriteLine("Подключение к PostgreSql");
        }
        public void Dispose()
        {
            Console.WriteLine("Подключение к PostgreSql закрыто");
        }
    }
}
