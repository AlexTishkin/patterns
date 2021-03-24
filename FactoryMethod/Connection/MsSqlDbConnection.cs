using System;

namespace FactoryMethod
{
    public class MsSqlDbConnection : IDbConnection
    {
        public void Connect()
        {
            Console.WriteLine("Подключение к MS SQL");
        }

        public void Dispose()
        {
            Console.WriteLine("Подключение к MS SQL закрыто");
        }
    }
}
