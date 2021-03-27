using System;

namespace Visitor.Device
{
    public class TV : IDevice
    {
        private bool _canWorking = false;

        public void Work()
        {
            if (!_canWorking)
                throw new Exception("ТВ не готово к работе. Обновите систему");

            Console.WriteLine("ТВ работает");
        }

        // Настройка. Различная для всех девайсов (Не использован полиморфизм для примера работы паттерна)
        public void UpdateSystem()
        {
            Console.WriteLine("Обновление системы для работы ТВ");
            _canWorking = true;
        }

        public void Accept(IDeviceVisitor visitor) => visitor.Visit(this);
    }
}
