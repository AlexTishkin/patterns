using System;

namespace Flyweight
{
    public class NewGameObject
    {
        public int X { get; set; }
        public int Y { get; set; }

        /// <summary>
        /// Ссылка на легковес
        /// </summary>
        public FlyweightGameObject _flyweight;
    }

    /// <summary>
    /// Тяжелые объекты унести в легковес
    /// </summary>
    public class FlyweightGameObject
    {
        public byte[] Sprite { get; set; }
        public ConsoleColor Color { get; set; }

        public FlyweightGameObject()
        {
            Console.WriteLine("Создание легковеса: тяжелый объект");
        }

        public FlyweightGameObject(ConsoleColor color, byte[] sprite) : this()
        {
            Color = color;
            Sprite = sprite;
        }
    }
}
