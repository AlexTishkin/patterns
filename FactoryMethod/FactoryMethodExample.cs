using System;

namespace FactoryMethod
{
    class FactoryMethodExample
    {
        static void Main(string[] args)
        {
            // Работа с PostgreSql
            Database database = new PostgreSqlDatabase();
            database.ExecuteSqlQuery("SELECT * FROM dbo.Dictionaries");

            Console.WriteLine();

            // Работа с MsSql
            database = new MsSqlDatabase();
            database.ExecuteSqlQuery("SELECT * FROM dbo.Dictionaries");
        }
    }
}
