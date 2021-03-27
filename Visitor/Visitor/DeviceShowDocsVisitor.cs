using System;
using Visitor.Device;

namespace Visitor
{
    /// <summary>
    /// Посетитель для вывода доков по каждому устройству
    /// </summary>
    public class DeviceShowDocsVisitor : IDeviceVisitor
    {
        public void Visit(Notebook device)
        {
            Console.WriteLine("Документация по устройству Ноутбук / Notebook. ");
        }

        public void Visit(Phone device)
        {
            Console.WriteLine("Документация по устройству Смартфон / Phone. ");
        }

        public void Visit(TV device)
        {
            Console.WriteLine("Документация по устройству ТВ / TV. ");
        }
    }
}
