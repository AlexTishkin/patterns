using System;
using System.Collections.Generic;
using Visitor.Device;

namespace Visitor
{
    /// <summary>
    /// Паттерн "Посетитель".
    /// https://refactoring.guru/design-patterns/visitor
    /// Вариант применения - вынос логики во внешний класс (настройка и вывод документации)
    /// </summary>
    class VisitorExample
    {
        static void Main(string[] args)
        {
            var devices = new List<IDevice> { new Notebook(), new Phone(), new TV() };

            // Настройка устройств
            foreach (var device in devices)
                device.Accept(new DeviceInitializationVisitor());

            Console.WriteLine();

            // Использование устройств
            foreach (var device in devices)
                device.Work();

            Console.WriteLine();

            // Вдруг нужно сохранить документацию о каждом устройстве (Не залезая в каждый класс)
            // Создадим нового посетителя
            foreach (var device in devices)
                device.Accept(new DeviceShowDocsVisitor());
        }
    }
}
