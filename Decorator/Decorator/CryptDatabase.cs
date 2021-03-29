namespace Decorator.Database
{
    /// <summary>
    /// Шифрование данных БД
    /// </summary>
    public class CryptDatabase : IDatabase
    {
        private IDatabase _database;

        public CryptDatabase(IDatabase database)
        {
            _database = database;
        }

        public string ReadData()
        {
            var decodedData = _database.ReadData();
            var data = DecodeData(decodedData);
            return data;
        }

        public void WriteData(string data)
        {
            var decodedData = EncodeData(data);
            _database.WriteData(decodedData);
        }

        /// <summary>
        /// Зашифровывает данные
        /// </summary>
        private string EncodeData(string data)
        {
            var charArray = data.ToCharArray();

            for (int i = 0; i < charArray.Length; i++)
                charArray[i] = (char)(((int)charArray[i]) + 5);

            return new string(charArray);
        }

        /// <summary>
        /// Расшифровывает данные
        /// </summary>
        private string DecodeData(string data)
        {
            var charArray = data.ToCharArray();

            for (int i = 0; i < charArray.Length; i++)
                charArray[i] = (char)(((int)charArray[i]) - 5);

            return new string(charArray);
        }

    }
}
