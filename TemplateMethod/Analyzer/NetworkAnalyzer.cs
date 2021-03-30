using System;

namespace TemplateMethod
{
    public abstract class NetworkAnalyzer
    {
        public abstract void Login();

        public abstract NetworkData ParseData(string pageUrl);

        public abstract void Logout();

        public void SaveToDatabase(NetworkData data)
        {
            Console.WriteLine($"Сохранение данных {data.PageUrl}");
        }

        /// <summary>
        /// Шаблонный метод
        /// </summary>
        /// <param name="pageUrl"></param>
        public void SingleParse(string pageUrl)
        {
            Login();
            var data = ParseData(pageUrl);
            SaveToDatabase(data);
            Logout();
        }

    }
}
