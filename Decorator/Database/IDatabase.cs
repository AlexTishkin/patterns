namespace Decorator
{
    public interface IDatabase
    {
        void WriteData(string data);
        string ReadData();
    }
}
