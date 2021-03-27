using System;

namespace Facade.AnotherLibrary
{
    public class Entity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public Entity() { }

        public Entity(Guid id, string name)
        {
            Id = id;
            Name = name;
        }

        public override string ToString() => $"[{Id} {Name}]";
    }
}
