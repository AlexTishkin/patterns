using System;
using System.Collections.Generic;

namespace Facade.AnotherLibrary
{
    /// <summary>
    /// Файловый грубый (однопоточный) аналог Entity Framework
    /// </summary>
    public interface IFileDatabase
    {
        /// <summary>
        /// Инициализирует файловую БД
        /// </summary>
        void Initialize();

        IEnumerable<Entity> Get();

        Entity GetById(Guid id);

        Entity Save(Entity entity);

        void Delete(Guid id);

        void Reset();

        /// <summary>
        /// Зафиксировать изменения (перезаписать все - грубо)
        /// </summary>
        void Commit();
    }
}
