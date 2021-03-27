using Visitor.Device;

namespace Visitor
{
    public interface IDeviceVisitor
    {
        void Visit(Notebook device);
        void Visit(Phone device);
        void Visit(TV device);
    }

}
