using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Facade.AnotherLibrary
{
    public class FileDatabase : IFileDatabase
    {
        private readonly string _fileName = "db.json";

        private ICollection<Entity> _entities;

        public FileDatabase()
        {
            Initialize();
        }

        public void Initialize()
        {
            if (!File.Exists(_fileName))
            {
                File.Create(_fileName);
                _entities = new List<Entity>();
                return;
            }

            var json = File.ReadAllText(_fileName);
            _entities = JsonConvert.DeserializeObject<List<Entity>>(json) ?? new List<Entity>();
        }

        public IEnumerable<Entity> Get() => _entities.ToList();

        public Entity GetById(Guid id) => _entities.SingleOrDefault(x => x.Id == id);

        public void Delete(Guid id)
        {
            var entity = _entities.SingleOrDefault(x => x.Id == id);
            _entities.Remove(entity);
        }

        public Entity Save(Entity entity)
        {
            var isNewRecord = entity.Id == Guid.Empty;

            if (isNewRecord)
            {
                entity.Id = Guid.NewGuid();
                _entities.Add(entity);
                return entity;
            }

            var databaseEntity = _entities.SingleOrDefault(x => x.Id == entity.Id);
            databaseEntity.Name = entity.Name;
            return databaseEntity;
        }

        public void Reset()
        {
            File.WriteAllText(_fileName, string.Empty);
            _entities = new List<Entity>();

        }

        public void Commit()
        {
            var json = JsonConvert.SerializeObject(_entities);
            File.WriteAllText(_fileName, json);
        }
    }
}
