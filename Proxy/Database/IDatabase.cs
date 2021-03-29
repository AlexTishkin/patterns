namespace Proxy
{
    public interface IDatabase
    {
        void Connect();
        void ExecuteQuery(string sql);
        void Disconnect();
    }
}
