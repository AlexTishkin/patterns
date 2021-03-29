using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.GraphElements
{
    public class Button : IGraphComponent
    {
        public void Draw()
        {
            Console.WriteLine("Кнопка создана");
        }
    }
}
