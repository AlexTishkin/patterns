using System;
using System.Collections.Generic;

namespace Composite.GraphElements
{
    /// <summary>
    /// Контейнер для хранения элементов
    /// </summary>
    public class Container : IGraphComponent
    {
        private List<IGraphComponent> _components;

        public Container()
        {
            _components = new List<IGraphComponent>();
        }

        public void Draw()
        {
            foreach (var comp in _components) comp.Draw();
        }

        public void Add(params IGraphComponent[] component) => _components.AddRange(component);
        public void Remove(IGraphComponent component) => _components.Remove(component);
        public void Clear(IGraphComponent component) => _components.Clear();
    }
}
