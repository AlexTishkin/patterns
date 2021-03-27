namespace Visitor.Device
{
    /// <summary>
    /// Устройство
    /// </summary>
    public interface IDevice
    {
        /// <summary>
        /// Проверка работоспособности устройства
        /// </summary>
        void Work();

        /// <summary>
        /// Метод для захода посетителя
        /// </summary>
        /// <param name="visitor"></param>
        void Accept(IDeviceVisitor visitor);
    }
}
