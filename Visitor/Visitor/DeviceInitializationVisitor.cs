using Visitor.Device;

namespace Visitor
{
    /// <summary>
    /// Посетитель для настройки устройств 
    /// (Не самый удачный пример - тк это относится к основной логике)
    /// </summary>
    public class DeviceInitializationVisitor : IDeviceVisitor
    {
        public void Visit(Notebook device)
        {
            device.InstallWindows();
        }

        public void Visit(Phone device)
        {
            device.SetSIM();
        }

        public void Visit(TV device)
        {
            device.UpdateSystem();
        }
    }
}
