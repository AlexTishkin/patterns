using Decorator.Database;
using System;

namespace Decorator
{
    /// <summary>
    /// Паттерн "Декоратор".
    /// https://refactoring.guru/design-patterns/decorator
    /// Вариант применения - сжатие и шифрование данных при работе с БД;
    /// </summary>
    class DecoratorExample
    {
        static void Main(string[] args)
        {
            // Работа с базой данных (без излишеств)
            IDatabase database = new FileDatabase();
            database.WriteData("Данные");
            var data = database.ReadData();
            Console.WriteLine(data);

            // Понадобилось сжатие данных (Декорируем 1)
            database = new CompressDatabase(database);
            database.WriteData("Сжатые данные");
            var compressedData = database.ReadData();
            Console.WriteLine(compressedData);

            // Понадобилось шифрование (Декорируем 2)
            database = new CryptDatabase(database);
            database.WriteData("Сжатые шифрованные данные");
            var compressedAndCryptedData = database.ReadData();
            Console.WriteLine(compressedAndCryptedData);
        }
    }
}
