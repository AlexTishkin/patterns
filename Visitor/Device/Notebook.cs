using System;

namespace Visitor.Device
{
    public class Notebook : IDevice
    {
        private bool _canWorking = false;

        public void Work()
        {
            if (!_canWorking)
                throw new Exception("Ноутбук не настроен. Установите Windows");

            Console.WriteLine("Ноутбук работает");
        }

        // Настройка. Различная для всех девайсов (Не использован полиморфизм для примера работы паттерна)
        public void InstallWindows()
        {
            Console.WriteLine("Установка Windows для ноутбука");
            _canWorking = true;
        }

        public void Accept(IDeviceVisitor visitor) => visitor.Visit(this);

    }
}
