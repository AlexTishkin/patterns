namespace FactoryMethod
{
    public class PostgreSqlDatabase : Database
    {
        public override IDbConnection CreateDbConnection() => new PostgreSqlDbConnection();
    }
}
