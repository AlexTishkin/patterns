using Facade.AnotherLibrary;
using System;
using System.Collections.Generic;

namespace Facade
{
    class FacadeExample
    {
        static void Main(string[] args)
        {
            var facade = new Facade();
            facade.Clear();

            // Save
            var saveEntities = new List<Entity> {
                new Entity(Guid.Empty, "First Record"),
                new Entity(Guid.Empty, "Second Record") };

            facade.SaveEntities(saveEntities);

            // Get
            var entitiesFromFile = facade.GetEntities();

            foreach (var entityFromFile in entitiesFromFile)
            {
                Console.WriteLine(entityFromFile);
            }

        }
    }
}
