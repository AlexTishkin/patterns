using System.IO;

namespace Decorator
{
    public class FileDatabase : IDatabase
    {
        private string _filename = "database.dat";

        public FileDatabase()
        {
            if (!File.Exists(_filename))
                File.Create(_filename);
            System.Threading.Thread.Sleep(300);
        }

        public string ReadData()
        {
            return File.ReadAllText(_filename);
        }

        public void WriteData(string data)
        {
            File.WriteAllText(_filename, data);
        }
    }
}
