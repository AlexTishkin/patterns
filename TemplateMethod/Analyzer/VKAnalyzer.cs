using System;

namespace TemplateMethod
{
    public class VKAnalyzer : NetworkAnalyzer
    {
        public override void Login()
        {
            Console.WriteLine("Вход в ВК");
        }

        public override NetworkData ParseData(string pageUrl)
        {
            return new NetworkData
            {
                PageUrl = pageUrl,
                PrimaryData = "Некие данные",
                OtherData = "Некие вторичные данные"
            };
        }

        public override void Logout()
        {
            Console.WriteLine("Выход из ВК");
        }
    }
}
