namespace FactoryMethod
{
    public class MsSqlDatabase : Database
    {
        public override IDbConnection CreateDbConnection() => new MsSqlDbConnection();
    }
}
