using System;

namespace Prototype
{
    /// <summary>
    /// Человек
    /// </summary>
    public class Human : ICloneable
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Human() { }

        public Human(Human anotherHuman)
        {
            Name = anotherHuman.Name;
            Age = anotherHuman.Age;
        }

        public virtual object Clone() => new Human(this);
    }
}
