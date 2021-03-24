using Newtonsoft.Json;
using System;
using System.IO;

namespace Singleton
{
    /// <summary>
    /// Паттерн "Синглтон".
    /// https://refactoring.guru/design-patterns/singleton
    /// Вариант применения - инициализация настроек приложения и их хранение
    /// </summary>
    public class Singleton
    {
        // 1. Инициализация статичного приватного поля - экземпляра класса
        private static Lazy<Singleton> _instance = new Lazy<Singleton>(() => new Singleton());

        // 2. Конструктор делаем приватным
        private Singleton()
        {
            InitializeSettings();
        }

        // 3. Геттер  для получения экземпляра класса
        public static Singleton Instance => _instance.Value;

        // 4. Прочая логика (Хранение настроек приложения)
        public string DatabaseConnection { get; private set; }
        public bool IsDebug { get; private set; }

        /// <summary>
        /// Инициализация настроек откуда-нибудь (Например, из файла)
        /// </summary>
        private void InitializeSettings()
        {
            var json = File.ReadAllText("../../../settings.json");
            var settings = JsonConvert.DeserializeObject<dynamic>(json);
            DatabaseConnection = settings.DatabaseConnection;
            IsDebug = settings.IsDebug;
        }
    }
}
