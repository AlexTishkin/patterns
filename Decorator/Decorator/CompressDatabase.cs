using System;
using System.IO;
using System.IO.Compression;
using System.Text;

namespace Decorator.Database
{
    /// <summary>
    /// Сжатие данных БД
    /// </summary>
    public class CompressDatabase : IDatabase
    {
        private IDatabase _database;

        public CompressDatabase(IDatabase database)
        {
            _database = database;
        }

        public string ReadData()
        {
            var decodedData = _database.ReadData();
            var data = UnCompress(decodedData);
            return data;
        }

        public void WriteData(string data)
        {
            var decodedData = Compress(data);
            _database.WriteData(decodedData);
        }

        /// <summary>
        /// Сжимает данные
        /// </summary>
        private string Compress(string s)
        {
            var bytes = Encoding.Unicode.GetBytes(s);
            using (var msi = new MemoryStream(bytes))
            using (var mso = new MemoryStream())
            {
                using (var gs = new GZipStream(mso, CompressionMode.Compress))
                    msi.CopyTo(gs);
                return Convert.ToBase64String(mso.ToArray());
            }
        }

        /// <summary>
        /// Распаковывает сжатые данные
        /// </summary>
        private string UnCompress(string s)
        {
            var bytes = Convert.FromBase64String(s);
            using (var msi = new MemoryStream(bytes))
            using (var mso = new MemoryStream())
            {
                using (var gs = new GZipStream(msi, CompressionMode.Decompress))
                    gs.CopyTo(mso);
                return Encoding.Unicode.GetString(mso.ToArray());
            }
        }

    }
}
