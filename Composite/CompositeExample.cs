using Composite.GraphElements;
using System;

namespace Composite
{
    /// <summary>
    /// Паттерн "Компоновщик".
    /// https://refactoring.guru/design-patterns/composite
    /// Вариант применения - представление дерева в ООП-стиле (Отрисовка блоков и элементов)
    /// </summary>
    class CompositeExample
    {
        static void Main(string[] args)
        {
            var container1 = new Container();
            container1.Add(new TextInput(), new TextInput());

            var container2 = new Container();
            container1.Add(new Combobox(), new TextInput());

            var globalContainer = new Container();
            globalContainer.Add(container1, container2, new Button());
            globalContainer.Draw();
        }
    }
}
