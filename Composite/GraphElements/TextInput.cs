using System;

namespace Composite.GraphElements
{
    public class TextInput : IGraphComponent
    {
        public void Draw()
        {
            Console.WriteLine("Поле ввода создано");
        }
    }
}
