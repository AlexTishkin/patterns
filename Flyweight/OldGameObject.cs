using System;

namespace Flyweight
{
    public class OldGameObject
    {
        public int X { get; set; }
        public int Y { get; set; }

        /// <summary>
        /// Тяжелые объекты
        /// </summary>
        public byte[] Sprite { get; set; }
        public ConsoleColor Color { get; set; }
    }
}
