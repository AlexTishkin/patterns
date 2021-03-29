using System;
using System.Collections.Generic;
using System.Reflection;

namespace Flyweight.Flyweight
{
    public class FlyWeightFactory
    {
        private Dictionary<FlyWeightType, FlyweightGameObject> _cache;

        public FlyWeightFactory()
        {
            _cache = new Dictionary<FlyWeightType, FlyweightGameObject>();
        }

        public FlyweightGameObject GetFlyWeight(FlyWeightType type)
        {
            var isCacheContain = _cache.TryGetValue(type, out FlyweightGameObject gameObject);
            if (isCacheContain) return gameObject;

            var flyWeight = CreateFlyweightGameObject(type);
            _cache.Add(type, flyWeight);
            return flyWeight;
        }

        public FlyweightGameObject CreateFlyweightGameObject(FlyWeightType type)
        {
            var createMethod = GetType().GetMethod("Create" + type.ToString(), BindingFlags.Static | BindingFlags.NonPublic);
            var gameObject = (FlyweightGameObject)createMethod.Invoke(null, null);
            return gameObject;
        }

        /// <summary>
        /// Методы создания игровых объектов
        /// </summary>
        /// <returns></returns>
        private static FlyweightGameObject CreateRedPerson() => new FlyweightGameObject(ConsoleColor.Red, new byte[1024]);

        private static FlyweightGameObject CreateGreenDragon() => new FlyweightGameObject(ConsoleColor.Green, new byte[2048]);

        private static FlyweightGameObject CreateYellowMan() => new FlyweightGameObject(ConsoleColor.Yellow, new byte[4096]);

    }
}
