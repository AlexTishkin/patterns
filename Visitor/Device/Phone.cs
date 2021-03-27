using System;

namespace Visitor.Device
{
    public class Phone : IDevice
    {
        private bool _canWorking = false;

        public void Work()
        {
            if (!_canWorking)
                throw new Exception("Смартфон не готов к работе. Установить СИМ-карту");

            Console.WriteLine("Смартфон работает");
        }

        // Настройка. Различная для всех девайсов (Не использован полиморфизм для примера работы паттерна)
        public void SetSIM()
        {
            Console.WriteLine("Установка СИМ-карты для смартфона");
            _canWorking = true;
        }

        public void Accept(IDeviceVisitor visitor) => visitor.Visit(this);
    }
}
