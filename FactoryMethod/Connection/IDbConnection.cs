using System;

namespace FactoryMethod
{
    /// <summary>
    /// Подключение к базе данных
    /// </summary>
    public interface IDbConnection : IDisposable
    {
        /// <summary>
        /// Подключение к серверу базы данных (условно)
        /// </summary>
        void Connect();
    }
}
