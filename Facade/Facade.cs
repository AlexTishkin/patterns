using Facade.AnotherLibrary;
using System.Collections.Generic;

namespace Facade
{
    /// <summary>
    /// Паттерн "Фасад".
    /// https://refactoring.guru/design-patterns/facade
    /// Вариант применения - сокрытие чужой библиотеки за фасадом
    /// Пользователю требуется лишь 2 фичи (массовый save и get)
    /// </summary>
    public class Facade
    {
        private IFileDatabase _fileDatabase;

        public Facade()
        {
            _fileDatabase = new FileDatabase();
            _fileDatabase.Initialize();
        }

        public void SaveEntities(IEnumerable<Entity> entities)
        {
            foreach (var entity in entities)
                _fileDatabase.Save(entity);

            _fileDatabase.Commit();
        }

        public void Clear()
        {
            _fileDatabase.Reset();
        }

        public IEnumerable<Entity> GetEntities() => _fileDatabase.Get();

    }
}
