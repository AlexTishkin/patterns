using Flyweight.Flyweight;
using System.Collections.Generic;

namespace Flyweight
{
    /// <summary>
    /// Паттерн "Легковес".
    /// https://refactoring.guru/ru/design-patterns/flyweight
    /// Вариант применения - вынос тяжелых объектов в отдельный класс
    /// Экономия RAM
    /// </summary>
    class FlyweightExample
    {
        static void Main(string[] args)
        {
            // Максимум 4 громадных объекта (RAM отдыхает)
            var flyWeightFactory = new FlyWeightFactory();
            var redPerson = flyWeightFactory.CreateFlyweightGameObject(FlyWeightType.RedPerson);
            var greenDragon = flyWeightFactory.CreateFlyweightGameObject(FlyWeightType.GreenDragon);
            var yellowMan = flyWeightFactory.CreateFlyweightGameObject(FlyWeightType.YellowMan);

            var gameObjects = new List<NewGameObject>();
            gameObjects.Add(new NewGameObject { X = 10, Y = 20, _flyweight = redPerson });
            gameObjects.Add(new NewGameObject { X = 10, Y = 20, _flyweight = greenDragon });
            gameObjects.Add(new NewGameObject { X = 10, Y = 20, _flyweight = yellowMan });

            gameObjects.Add(new NewGameObject { X = 10, Y = 20, _flyweight = redPerson });
            gameObjects.Add(new NewGameObject { X = 10, Y = 20, _flyweight = redPerson });
            gameObjects.Add(new NewGameObject { X = 10, Y = 20, _flyweight = redPerson });
        }
    }
}
