using System;

namespace Singleton
{
    public class SingletonExample
    {
        static void Main(string[] args)
        {
            var singleton = Singleton.Instance;

            var isDebug = singleton.IsDebug;
            var dbConnection = singleton.DatabaseConnection;

            Console.WriteLine(isDebug ? "Debug mode" : "Release mode");
            Console.WriteLine("Databace connection is " + dbConnection);

        }
    }
}
