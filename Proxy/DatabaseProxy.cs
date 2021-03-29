using System;

namespace Proxy
{
    public class DatabaseProxy : IDatabase
    {
        private Lazy<IDatabase> _database = new Lazy<IDatabase>(() => new MsSqlDatabase());

        public DatabaseProxy(string password)
        {
            if (!CheckAccess(password))
                throw new UnauthorizedAccessException("Некорректный пароль");
        }

        public void Connect()
        {
            Console.WriteLine("Действия перед подключением к БД...");
            _database.Value.Connect();
            Console.WriteLine("Действия после подключения к БД...");
        }

        public void Disconnect()
        {
            _database.Value.Disconnect();
        }

        public void ExecuteQuery(string sql)
        {
            _database.Value.ExecuteQuery(sql);
        }

        /// <summary>
        /// Проверка доступа для работы с БД
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool CheckAccess(string password)
        {
            string _adminPassword = "123456";
            return password.Equals(_adminPassword, StringComparison.Ordinal);
        }
    }
}
