using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.GraphElements
{
    public class Combobox : IGraphComponent
    {
        public void Draw()
        {
            Console.WriteLine("Выпадающий список создан");
        }
    }
}
